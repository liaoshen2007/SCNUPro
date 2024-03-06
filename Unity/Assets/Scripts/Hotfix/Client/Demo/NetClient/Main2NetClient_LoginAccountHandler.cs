using System.Net;
using System.Net.Sockets;

namespace ET.Client
{
    [MessageHandler(SceneType.NetClient)]
    public class Main2NetClient_LoginAccountHandler: MessageHandler<Scene, Main2NetClient_LoginAccount, NetClient2Main_LoginAccount>
    {
        protected override async ETTask Run(Scene root, Main2NetClient_LoginAccount request, NetClient2Main_LoginAccount response)
        {
            string account = request.Account;
            string password = request.Password;
            
            root.RemoveComponent<RouterAddressComponent>();
            RouterAddressComponent routerAddressComponent =
                    root.AddComponent<RouterAddressComponent, string, int>(ConstValue.RouterHttpHost, ConstValue.RouterHttpPort);
            await routerAddressComponent.Init();
            root.AddComponent<NetComponent, AddressFamily, NetworkProtocol>(routerAddressComponent.RouterManagerIPAddress.AddressFamily, NetworkProtocol.UDP);
            root.GetComponent<FiberParentComponent>().ParentFiberId = request.OwnerFiberId;
        
            NetComponent netComponent = root.GetComponent<NetComponent>();
            
            IPEndPoint realmAddress = routerAddressComponent.GetRealmAddress(account);

            password = MD5Helper.StringMD5(password);
            A2C_LoginAccount a2CLoginAccount;
            Log.Error("a2CLoginAccount ComeHere!");
            using (Session session=await netComponent.CreateRouterSession(realmAddress,account,password))
            {
                a2CLoginAccount = (A2C_LoginAccount)await session.Call(new C2A_LoginAccount()
                {
                    AccountName = account, Password = password
                });
                Log.Error("AccountName ComeHere1111!");
            }
            Log.Error("AccountName ComeHere!");
            if (a2CLoginAccount.Error!=ErrorCode.ERR_Success)
            {
                response.Error = a2CLoginAccount.Error;
                return;
            }

            Session accountSession = await netComponent.CreateRouterSession(NetworkHelper.ToIPEndPoint(a2CLoginAccount.Address), account, password);
            accountSession.AddComponent<ClientSessionErrorComponent>();
            root.AddComponent<SessionComponent>().Session = accountSession;
            
            Log.Debug("登陆Account服成功!");
            response.Token = a2CLoginAccount.Token;
            response.AccountId = a2CLoginAccount.AccountId;
        }
    }
}

