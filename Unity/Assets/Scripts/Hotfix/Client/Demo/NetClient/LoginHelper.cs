using System;

namespace ET.Client
{
    public static class LoginHelper
    {
        public static async ETTask Login(Scene root, string account, string password)
        {
            root.RemoveComponent<ClientSenderCompnent>();
            ClientSenderCompnent clientSenderCompnent = root.AddComponent<ClientSenderCompnent>();

            var response = await clientSenderCompnent.LoginAsync(account, password);

            if (response.Error!=ErrorCode.ERR_Success)
            {
                Log.Error("response.Error:"+response.Error);
                //todo 显示层飘出提示，提醒玩家的操作失败！
                return;
            }

            root.GetComponent<PlayerComponent>().MyId = response.PlayerId;
            
            await EventSystem.Instance.PublishAsync(root, new LoginFinish());
        }
        
        public static async ETTask<int> LoginAccount(Scene root, string account, string password, string address)
        {
            root.RemoveComponent<ClientSenderCompnent>();
            ClientSenderCompnent clientSenderCompnent = root.AddComponent<ClientSenderCompnent>();

            var response = await clientSenderCompnent.LoginAccountAsync(account, password,address);

            if (response.Error!=ErrorCode.ERR_Success)
            {
                Log.Error("response.Error:"+response.Error);
                //todo 显示层飘出提示，提醒玩家的操作失败！
                return response.Error;
            }
            
            //root.AddComponent<SessionComponent>().Session = accountSession;//保持连接。
            root.GetComponent<SessionComponent>().Session.AddComponent<PingComponent>();//每隔一段时间给服务器发送一条消息来保持连接。
            
            root.GetComponent<AccountInfoComponent>().Token = response.Token;
            root.GetComponent<AccountInfoComponent>().AccountId = response.AccountId;
            await EventSystem.Instance.PublishAsync(root, new LoginFinish());


            return ErrorCode.ERR_Success;
        }
    }
}