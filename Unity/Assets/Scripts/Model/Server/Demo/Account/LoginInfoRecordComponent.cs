using System.Collections.Generic;

namespace ET.Server
{
    public class LoginInfoRecordComponent:Entity,IAwake,IDestroy
    {
        public Dictionary<long, int> AccountLoginInfoDict = new Dictionary<long, int>();

    }

}

