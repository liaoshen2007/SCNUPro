namespace ET
{
    public static partial class ErrorCode
    {
        public const int ERR_Success = 0;

        // 1-11004 是SocketError请看SocketError定义
        //-----------------------------------
        // 100000-109999是Core层的错误
        
        // 110000以下的错误请看ErrorCore.cs
        
        // 这里配置逻辑层的错误码
        // 110000 - 200000是抛异常的错误
        // 200001以上不抛异常
        public const int ERR_LoginInfoEmpty = 200002;//登录信息为空
        public const int ERR_LoginInfoError = 200003;//登录错误
        public const int ERR_AccountInfoError = 200004;//输入规则错误
        public const int ERR_PasswordInfoError = 200005;//密码格式错误
        public const int ERR_AccountBanError = 200006;//账号进入黑名单
        public const int ERR_RequestlyRepeatedly = 200007;//重复请求
        public const int ERR_PasswordError = 200008;//密码输入错误
        public const int ERR_TokenError = 200009;//令牌Token错误
        public const int ERR_RoleNameIsNull = 200010;//角色名称为空
        public const int ERR_RoleNameIsExist = 200011;//角色名称已经存在
        public const int ERR_RoleIsNotExist = 200012;//角色不存在
        public const int ERR_RequsetSceneTypeError = 200013;//场景请求错误
        public const int ERR_ConnetGateKeyError = 200013; //连接网关Key错误
        public const int ERR_OtherAccountLogin = 200014;//账号异地登录
        public const int ERR_PlayerSessionError = 200015;//角色session错误
        public const int ERR_NonePlayerError = 200016;//找不到玩家
        public const int ERR_SessionStateError = 200017;//找不到玩家
        public const int ERR_EnterGameError2 = 200018;//二次登录失败
        public const int ERR_EnterGameError = 200019;//登录游戏失败
        public const int ERR_ReEnterGameError = 200020;//重登失败
        public const int ERR_EnsurePasswordError = 200021;//重复输入密码不一样
        public const int ERR_AccountHasExist = 200022;//账号已经存在
        public const int ERR_AccountisNotExist = 200023;//账号不存在
        public const int ERR_NumericTypeNotExist = 200024;//数值类型不存在
        public const int ERR_NumericTypeNotAddpoint = 200025;//数值类型不能加点
        public const int ERR_AddpointNotEnough = 200026;//加点不足
        
        public const int ERR_AlreadyAdventureState = 200027;//已经在关卡状态
        public const int ERR_AdventureInDying = 200028;//闯关死亡
        public const int ERR_AdventureErrorLevel = 200029;//关卡错误
        public const int ERR_AdventureLevelNoEnough = 200030;//等级不足
        public const int ERR_AdventureLevelIdError = 200031;//关卡Id错误
        public const int ERR_AdventureRoundError = 200032;//关卡回合错误
        public const int ERR_AdventuredResultError = 200033;//关卡回合错误
        public const int ERR_AdventureWindResultError = 200034;//时间不足！
        public const int ERR_ExpNotEnough = 200035;//经验不足！
        public const int ERR_ExpNumError = 200036;//经验不足！

        public const int ERR_ItemNotExist = 200037;//物品不存在
        public const int ERR_AddBagItemError=200038;//添加背包物品错误
        public const int ERR_EquipItemError = 200039;//装备物品出错
        public const int ERR_BagMaxLoad = 200039;//背包容量达至上限

        public const int ERR_MakeConfigNoExit = 200040;//打造配置不存在！
        public const int ERR_MakeConfigNoError = 200041;//打造配置错误！
        public const int ERR_NoMakeFreeQueue= 200042;//无空闲制作队列！
        public const int ERR_MakeConsumeError= 200043;//制作耗材错误！
        public const int ERR_NoMakeQueueOver= 200044;//制作耗材错误！

        public const int ERR_NoTaskInfoExist = 200045;//无此任务信息
        public const int ERR_TaskNoCompleted = 200046;//任务未完成
        public const int ERR_NoTaskExist = 200047;//任务不存在
        public const int ERR_BeforeTaskNoOver=200048;//前置任务未结束
        public const int ERR_TaskRewarded=200049;//奖励已领取
        public const int ERR_ChatMessageEmpty = 200050;//聊天信息为空
        public const int ERR_CanNotMatch=200051;//该地图不能匹配
        public const int ERR_MatchIsNotExist = 200052;//匹配组不存在了

        public const int ERR_FriendNameEmpty = 200053;//查找姓名为空
        public const int ERR_FriendEntityEmpty = 200054;//好友组件为空
        public const int ERR_FriendNotExist = 200055;//好友不存在
        public const int ERR_ApplyFriendRepeated = 200056;//重复查询好友
        public const int ERR_AcceptFriendRepeated = 200057;//重复接收好友
        public const int ERR_FriendIsOffline = 200058;//好友下线了
    }
}