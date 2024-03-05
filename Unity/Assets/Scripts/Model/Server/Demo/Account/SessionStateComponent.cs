namespace ET.Server
{
    public enum SessionState
    {
        Normal,
        Game
    }


    public class SessionStateComponent:Entity,IAwake
    {
        public SessionState State;
    }
}

