using System;
using System.Text.RegularExpressions;

namespace ET.Server
{
    [MessageSessionHandler(SceneType.Account)]
    [FriendOfAttribute(typeof (ET.Server.AccountInfo))]
    public class C2A_LoginAccountHandler: MessageSessionHandler<C2A_LoginAccount, A2C_LoginAccount>
    {
        protected override async ETTask Run(Session session, C2A_LoginAccount request, A2C_LoginAccount response)
        {
            Log.Error("session comeHere!");
            if (session.Root().SceneType != SceneType.Account)
            {
                Log.Error("请求的scene错误，当前的scene为：" + session.Root().SceneType);
                session.Dispose(); //没有调用reply，所以可以直接释放！
                return;
            }

            session.RemoveComponent<SessionAcceptTimeoutComponent>();
            if (session.GetComponent<SessionLockingComponent>() != null)
            {
                response.Error = ErrorCode.ERR_Success;
                //reply();//返回值给客户端
                //TODO 断线处理！
                //session.Disconnect().Coroutine();
                return;
            }

            if (string.IsNullOrEmpty(request.AccountName) || string.IsNullOrEmpty(request.Password))
            {
                response.Error = ErrorCode.ERR_LoginInfoError;
                //reply();//返回值给客户端
                //session.Disconnect().Coroutine();
                return;
            }

            //md5加密的密码不能随便使用复杂的正则表达式来约束。
            if (!Regex.IsMatch(request.AccountName.Trim(), @"^(?=.*[0-9].*)(?=.*[a-z].*).{6,15}$"))
            {
                response.Error = ErrorCode.ERR_AccountInfoError;
                // reply();
                // session.Disconnect().Coroutine();
                return;
            }

            if (!Regex.IsMatch(request.Password.Trim(), @"^[A-Za-z0-9]+$"))
            {
                response.Error = ErrorCode.ERR_PasswordInfoError;
                // reply();
                // session.Disconnect().Coroutine();
                return;
            }

            using (session.AddComponent<SessionLockingComponent>())
            {
                using (await session.Root().GetComponent<CoroutineLockComponent>()
                               .Wait(CoroutineLockType.LoginAccount, request.AccountName.Trim().GetHashCode()))
                {
                    DBComponent dbComponent = session.Root().GetComponent<DBManagerComponent>().GetZoneDB(session.Zone());
                    var accountInfoList = await dbComponent.Query<AccountInfo>(d => d.Account.Equals(request.AccountName.Trim()));
                    AccountInfo account = null;
                    StartSceneConfig config = RealmGateAddressHelper.GetGate(session.Zone(), request.AccountName);
                    Log.Debug($"config address: {config}");
                    response.Address = config.InnerIPPort.ToString();
                    
                    if (accountInfoList != null && accountInfoList.Count > 0)
                    {
                        account = accountInfoList[0];
                        //todo 研究一下有没有必要ADD,按道理应该不需要add!
                        // AccountInfosComponent accountInfosComponent =
                        //         session.GetComponent<AccountInfosComponent>() ?? session.AddComponent<AccountInfosComponent>();
                        // AccountInfo accountInfo = accountInfosComponent.GetChild<AccountInfo>(account.InstanceId)??accountInfosComponent.AddChild<AccountInfo>();
                        // session.AddChild(account);
                        if (account.AccountType == (int)AccountType.BlackList)
                        {
                            response.Error = ErrorCode.ERR_AccountBanError;
                            // reply();
                            // session.Disconnect().Coroutine();
                            account?.Dispose();
                            return;
                        }

                        if (!account.Password.Equals(request.Password))
                        {
                            response.Error = ErrorCode.ERR_PasswordError;
                            // reply();
                            // session.Disconnect().Coroutine();
                            account?.Dispose();
                            return;
                        }
                    }
                    else
                    {

                        //以下代码是临时代码，就是判断数据库没有这个账号就直接添加，在实际场景是不正确的
                        AccountInfosComponent accountInfosComponent =
                                session.GetComponent<AccountInfosComponent>() ?? session.AddComponent<AccountInfosComponent>();
                        AccountInfo accountInfo = accountInfosComponent.AddChild<AccountInfo>();
                        accountInfo.Account = request.AccountName;
                        accountInfo.Password = request.Password;
                        accountInfo.CreateTime=TimeInfo.Instance.ServerNow();
                        await dbComponent.Save(accountInfo);
                        response.Error = ErrorCode.ERR_AccountisNotExist;
                        // reply();
                        // session.Disconnect().Coroutine();
                        return;
                    }
                    
                       //账号中心
                    //StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(session.Zone(), "LoginCenter");
                    var l2ALoginAccountResponse=(L2A_LoginAccountResponse)await session.Fiber().Root.GetComponent<MessageSender>().Call(config.ActorId,new A2L_LoginAccountRequest() { AccountId = account.Id});
                    if (l2ALoginAccountResponse.Error!=ErrorCode.ERR_Success)
                    {
                        response.Error = l2ALoginAccountResponse.Error;
                        // reply();
                        // session?.Disconnect().Coroutine();
                        account?.Dispose();
                        return;
                    }
                    
                    
                    //顶号下线
                    long accountSessionInstanceId=session.Root().GetComponent<AccountSessionsComponent>().Get(account.Id);
                    Session othersession=session.Root().GetChild<Session>(accountSessionInstanceId);
                    
                    //此处会空指针？
                    if (othersession!=null)
                    {
                        othersession.Send(new A2C_Disconnect(){Error = 0});
                        //othersession.Disconnect().Coroutine();
                    }

                    
                    session.Root().GetComponent<AccountSessionsComponent>().Add(account.Id,session.InstanceId);
                    session.AddComponent<AccountCheckOutTimeComponent, long>(account.Id);//检测组件可以按时释放超时的session

                    //todo token最好使用雪花算法！
                    string Token = TimeInfo.Instance.ServerNow().ToString() + RandomGenerator.RandomNumber(int.MinValue, int.MaxValue);
                    session.Root().GetComponent<TokenComponent>().Remove(account.Id);
                    session.Root().GetComponent<TokenComponent>().Add(account.Id,Token);

                    response.AccountId = account.Id;
                    response.Token = Token;

                    await ETTask.CompletedTask;
                }
            }
        }
    }
}