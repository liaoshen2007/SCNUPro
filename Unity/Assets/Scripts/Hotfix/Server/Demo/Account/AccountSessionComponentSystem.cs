namespace ET.Server
{
    [EntitySystemOf(typeof (AccountSessionsComponent))]
    [FriendOfAttribute(typeof (ET.Server.AccountSessionsComponent))]
    public static class AccountSessionComponentSystem
    {
        public static long Get(this AccountSessionsComponent self, long accountId)
        {
            if (!self.AccountSessionDictionary.TryGetValue(accountId, out long instanceId))
            {
                return 0;
            }

            return instanceId;
        }

        public static void Add(this AccountSessionsComponent self, long accountId, long sessionInstanceId)
        {
            if (self.AccountSessionDictionary.ContainsKey(accountId))
            {
                self.AccountSessionDictionary[accountId] = sessionInstanceId;
                return;
            }

            self.AccountSessionDictionary.Add(accountId, sessionInstanceId);
        }

        public static void Remove(this AccountSessionsComponent self, long accountId)
        {
            if (self.AccountSessionDictionary.ContainsKey(accountId))
            {
                self.AccountSessionDictionary.Remove(accountId);
            }

        }

        [EntitySystem]
        private static void Awake(this ET.Server.AccountSessionsComponent self)
        {

        }

        [EntitySystem]
        private static void Destroy(this ET.Server.AccountSessionsComponent self)
        {
            self.AccountSessionDictionary.Clear();
        }
    }
}

