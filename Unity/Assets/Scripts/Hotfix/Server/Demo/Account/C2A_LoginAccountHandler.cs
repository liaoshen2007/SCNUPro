using System;
using System.Text.RegularExpressions;

namespace ET.Server
{
    [MessageSessionHandler(SceneType.Account)]
    [FriendOfAttribute(typeof(ET.Server.AccountInfo))]
    public class C2A_LoginAccountHandler:MessageSessionHandler<C2A_LoginAccount, A2C_LoginAccount>
    {
        protected override async ETTask Run(Session session, C2A_LoginAccount request, A2C_LoginAccount response)
        {


            await ETTask.CompletedTask;
        }
    }
}