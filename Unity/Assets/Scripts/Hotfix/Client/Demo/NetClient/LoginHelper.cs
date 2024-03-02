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
    }
}