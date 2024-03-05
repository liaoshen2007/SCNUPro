namespace ET.Server
{
    [ChildOf(typeof(AccountInfosComponent))]
    public class AccountInfo:Entity,IAwake
    {
        public string Account;

        public string Password;
        
        public long CreateTime{ get; set; }//账号创建时间
        
        public int AccountType{ get; set; }//账号类型

        public string PhoneNum{ get; set; }//手机号码
    }
    
    public enum AccountType
    {
        General=0,
        BlackList=1,
    }

}

