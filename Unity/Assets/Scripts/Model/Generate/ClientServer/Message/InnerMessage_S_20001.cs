using ET;
using MemoryPack;
using System.Collections.Generic;
namespace ET
{
// using
	[ResponseType(nameof(ObjectQueryResponse))]
	[Message(InnerMessage.ObjectQueryRequest)]
	[MemoryPackable]
	public partial class ObjectQueryRequest: MessageObject, IRequest
	{
		public static ObjectQueryRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectQueryRequest), isFromPool) as ObjectQueryRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public long Key { get; set; }

		[MemoryPackOrder(2)]
		public long InstanceId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Key = default;
			this.InstanceId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(A2M_Reload))]
	[Message(InnerMessage.M2A_Reload)]
	[MemoryPackable]
	public partial class M2A_Reload: MessageObject, IRequest
	{
		public static M2A_Reload Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(M2A_Reload), isFromPool) as M2A_Reload; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.A2M_Reload)]
	[MemoryPackable]
	public partial class A2M_Reload: MessageObject, IResponse
	{
		public static A2M_Reload Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(A2M_Reload), isFromPool) as A2M_Reload; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(G2G_LockResponse))]
	[Message(InnerMessage.G2G_LockRequest)]
	[MemoryPackable]
	public partial class G2G_LockRequest: MessageObject, IRequest
	{
		public static G2G_LockRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2G_LockRequest), isFromPool) as G2G_LockRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public long Id { get; set; }

		[MemoryPackOrder(2)]
		public string Address { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Id = default;
			this.Address = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.G2G_LockResponse)]
	[MemoryPackable]
	public partial class G2G_LockResponse: MessageObject, IResponse
	{
		public static G2G_LockResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2G_LockResponse), isFromPool) as G2G_LockResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(G2G_LockReleaseResponse))]
	[Message(InnerMessage.G2G_LockReleaseRequest)]
	[MemoryPackable]
	public partial class G2G_LockReleaseRequest: MessageObject, IRequest
	{
		public static G2G_LockReleaseRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2G_LockReleaseRequest), isFromPool) as G2G_LockReleaseRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public long Id { get; set; }

		[MemoryPackOrder(2)]
		public string Address { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Id = default;
			this.Address = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.G2G_LockReleaseResponse)]
	[MemoryPackable]
	public partial class G2G_LockReleaseResponse: MessageObject, IResponse
	{
		public static G2G_LockReleaseResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2G_LockReleaseResponse), isFromPool) as G2G_LockReleaseResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(ObjectAddResponse))]
	[Message(InnerMessage.ObjectAddRequest)]
	[MemoryPackable]
	public partial class ObjectAddRequest: MessageObject, IRequest
	{
		public static ObjectAddRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectAddRequest), isFromPool) as ObjectAddRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Type { get; set; }

		[MemoryPackOrder(2)]
		public long Key { get; set; }

		[MemoryPackOrder(3)]
		public ActorId ActorId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Type = default;
			this.Key = default;
			this.ActorId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.ObjectAddResponse)]
	[MemoryPackable]
	public partial class ObjectAddResponse: MessageObject, IResponse
	{
		public static ObjectAddResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectAddResponse), isFromPool) as ObjectAddResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(ObjectLockResponse))]
	[Message(InnerMessage.ObjectLockRequest)]
	[MemoryPackable]
	public partial class ObjectLockRequest: MessageObject, IRequest
	{
		public static ObjectLockRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectLockRequest), isFromPool) as ObjectLockRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Type { get; set; }

		[MemoryPackOrder(2)]
		public long Key { get; set; }

		[MemoryPackOrder(3)]
		public ActorId ActorId { get; set; }

		[MemoryPackOrder(4)]
		public int Time { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Type = default;
			this.Key = default;
			this.ActorId = default;
			this.Time = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.ObjectLockResponse)]
	[MemoryPackable]
	public partial class ObjectLockResponse: MessageObject, IResponse
	{
		public static ObjectLockResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectLockResponse), isFromPool) as ObjectLockResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(ObjectUnLockResponse))]
	[Message(InnerMessage.ObjectUnLockRequest)]
	[MemoryPackable]
	public partial class ObjectUnLockRequest: MessageObject, IRequest
	{
		public static ObjectUnLockRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectUnLockRequest), isFromPool) as ObjectUnLockRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Type { get; set; }

		[MemoryPackOrder(2)]
		public long Key { get; set; }

		[MemoryPackOrder(3)]
		public ActorId OldActorId { get; set; }

		[MemoryPackOrder(4)]
		public ActorId NewActorId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Type = default;
			this.Key = default;
			this.OldActorId = default;
			this.NewActorId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.ObjectUnLockResponse)]
	[MemoryPackable]
	public partial class ObjectUnLockResponse: MessageObject, IResponse
	{
		public static ObjectUnLockResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectUnLockResponse), isFromPool) as ObjectUnLockResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(ObjectRemoveResponse))]
	[Message(InnerMessage.ObjectRemoveRequest)]
	[MemoryPackable]
	public partial class ObjectRemoveRequest: MessageObject, IRequest
	{
		public static ObjectRemoveRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectRemoveRequest), isFromPool) as ObjectRemoveRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Type { get; set; }

		[MemoryPackOrder(2)]
		public long Key { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Type = default;
			this.Key = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.ObjectRemoveResponse)]
	[MemoryPackable]
	public partial class ObjectRemoveResponse: MessageObject, IResponse
	{
		public static ObjectRemoveResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectRemoveResponse), isFromPool) as ObjectRemoveResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(ObjectGetResponse))]
	[Message(InnerMessage.ObjectGetRequest)]
	[MemoryPackable]
	public partial class ObjectGetRequest: MessageObject, IRequest
	{
		public static ObjectGetRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectGetRequest), isFromPool) as ObjectGetRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Type { get; set; }

		[MemoryPackOrder(2)]
		public long Key { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Type = default;
			this.Key = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.ObjectGetResponse)]
	[MemoryPackable]
	public partial class ObjectGetResponse: MessageObject, IResponse
	{
		public static ObjectGetResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectGetResponse), isFromPool) as ObjectGetResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		[MemoryPackOrder(3)]
		public int Type { get; set; }

		[MemoryPackOrder(4)]
		public ActorId ActorId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			this.Type = default;
			this.ActorId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(G2R_GetLoginKey))]
	[Message(InnerMessage.R2G_GetLoginKey)]
	[MemoryPackable]
	public partial class R2G_GetLoginKey: MessageObject, IRequest
	{
		public static R2G_GetLoginKey Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(R2G_GetLoginKey), isFromPool) as R2G_GetLoginKey; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public string Account { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Account = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.G2R_GetLoginKey)]
	[MemoryPackable]
	public partial class G2R_GetLoginKey: MessageObject, IResponse
	{
		public static G2R_GetLoginKey Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2R_GetLoginKey), isFromPool) as G2R_GetLoginKey; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		[MemoryPackOrder(3)]
		public long Key { get; set; }

		[MemoryPackOrder(4)]
		public long GateId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			this.Key = default;
			this.GateId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.G2M_SessionDisconnect)]
	[MemoryPackable]
	public partial class G2M_SessionDisconnect: MessageObject, ILocationMessage
	{
		public static G2M_SessionDisconnect Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2M_SessionDisconnect), isFromPool) as G2M_SessionDisconnect; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.ObjectQueryResponse)]
	[MemoryPackable]
	public partial class ObjectQueryResponse: MessageObject, IResponse
	{
		public static ObjectQueryResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(ObjectQueryResponse), isFromPool) as ObjectQueryResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		[MemoryPackOrder(3)]
		public byte[] Entity { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			this.Entity = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(M2M_UnitTransferResponse))]
	[Message(InnerMessage.M2M_UnitTransferRequest)]
	[MemoryPackable]
	public partial class M2M_UnitTransferRequest: MessageObject, IRequest
	{
		public static M2M_UnitTransferRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(M2M_UnitTransferRequest), isFromPool) as M2M_UnitTransferRequest; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public ActorId OldActorId { get; set; }

		[MemoryPackOrder(2)]
		public byte[] Unit { get; set; }

		[MemoryPackOrder(3)]
		public List<byte[]> Entitys { get; set; } = new();

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.OldActorId = default;
			this.Unit = default;
			this.Entitys.Clear();
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.M2M_UnitTransferResponse)]
	[MemoryPackable]
	public partial class M2M_UnitTransferResponse: MessageObject, IResponse
	{
		public static M2M_UnitTransferResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(M2M_UnitTransferResponse), isFromPool) as M2M_UnitTransferResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(L2A_LoginAccountResponse))]
	[Message(InnerMessage.A2L_LoginAccountRequest)]
	[MemoryPackable]
	public partial class A2L_LoginAccountRequest: MessageObject, IRequest
	{
		public static A2L_LoginAccountRequest Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(A2L_LoginAccountRequest), isFromPool) as A2L_LoginAccountRequest; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(0)]
		public long AccountId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.AccountId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.L2A_LoginAccountResponse)]
	[MemoryPackable]
	public partial class L2A_LoginAccountResponse: MessageObject, IResponse
	{
		public static L2A_LoginAccountResponse Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(L2A_LoginAccountResponse), isFromPool) as L2A_LoginAccountResponse; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(G2L_DisconnectGateUnit))]
	[Message(InnerMessage.L2G_DisconnectGateUnit)]
	[MemoryPackable]
	public partial class L2G_DisconnectGateUnit: MessageObject, IRequest
	{
		public static L2G_DisconnectGateUnit Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(L2G_DisconnectGateUnit), isFromPool) as L2G_DisconnectGateUnit; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(0)]
		public long AccountId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.AccountId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.G2L_DisconnectGateUnit)]
	[MemoryPackable]
	public partial class G2L_DisconnectGateUnit: MessageObject, IResponse
	{
		public static G2L_DisconnectGateUnit Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2L_DisconnectGateUnit), isFromPool) as G2L_DisconnectGateUnit; 
		}

		[MemoryPackOrder(0)]
		public int RpcId { get; set; }

		[MemoryPackOrder(1)]
		public int Error { get; set; }

		[MemoryPackOrder(2)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(R2A_GetRealmKey))]
	[Message(InnerMessage.A2R_GetRealmKey)]
	[MemoryPackable]
	public partial class A2R_GetRealmKey: MessageObject, IRequest
	{
		public static A2R_GetRealmKey Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(A2R_GetRealmKey), isFromPool) as A2R_GetRealmKey; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(0)]
		public long AccountId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.AccountId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.R2A_GetRealmKey)]
	[MemoryPackable]
	public partial class R2A_GetRealmKey: MessageObject, IResponse
	{
		public static R2A_GetRealmKey Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(R2A_GetRealmKey), isFromPool) as R2A_GetRealmKey; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(90)]
		public int Error { get; set; }

		[MemoryPackOrder(91)]
		public string Message { get; set; }

		[MemoryPackOrder(0)]
		public string RealmKey { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			this.RealmKey = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(G2R_GetLogingGateKey))]
	[Message(InnerMessage.R2G_GetLogingGateKey)]
	[MemoryPackable]
	public partial class R2G_GetLogingGateKey: MessageObject, IRequest
	{
		public static R2G_GetLogingGateKey Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(R2G_GetLogingGateKey), isFromPool) as R2G_GetLogingGateKey; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(0)]
		public long AccountId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.AccountId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.G2R_GetLogingGateKey)]
	[MemoryPackable]
	public partial class G2R_GetLogingGateKey: MessageObject, IResponse
	{
		public static G2R_GetLogingGateKey Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2R_GetLogingGateKey), isFromPool) as G2R_GetLogingGateKey; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(90)]
		public int Error { get; set; }

		[MemoryPackOrder(91)]
		public string Message { get; set; }

		[MemoryPackOrder(0)]
		public string GateSessionKey { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			this.GateSessionKey = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(L2G_AddLoginRecord))]
	[Message(InnerMessage.G2L_AddLoginRecord)]
	[MemoryPackable]
	public partial class G2L_AddLoginRecord: MessageObject, IRequest
	{
		public static G2L_AddLoginRecord Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2L_AddLoginRecord), isFromPool) as G2L_AddLoginRecord; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(0)]
		public long AccountId { get; set; }

		[MemoryPackOrder(1)]
		public int ServerId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.AccountId = default;
			this.ServerId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.L2G_AddLoginRecord)]
	[MemoryPackable]
	public partial class L2G_AddLoginRecord: MessageObject, IResponse
	{
		public static L2G_AddLoginRecord Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(L2G_AddLoginRecord), isFromPool) as L2G_AddLoginRecord; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(90)]
		public int Error { get; set; }

		[MemoryPackOrder(91)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(M2G_RequestEnterGameState))]
	[Message(InnerMessage.G2M_RequestEnterGameState)]
	[MemoryPackable]
	public partial class G2M_RequestEnterGameState: MessageObject, ILocationRequest
	{
		public static G2M_RequestEnterGameState Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2M_RequestEnterGameState), isFromPool) as G2M_RequestEnterGameState; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.M2G_RequestEnterGameState)]
	[MemoryPackable]
	public partial class M2G_RequestEnterGameState: MessageObject, ILocationResponse
	{
		public static M2G_RequestEnterGameState Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(M2G_RequestEnterGameState), isFromPool) as M2G_RequestEnterGameState; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(90)]
		public int Error { get; set; }

		[MemoryPackOrder(91)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(M2G_RequestExitGame))]
	[Message(InnerMessage.G2M_RequestExitGame)]
	[MemoryPackable]
	public partial class G2M_RequestExitGame: MessageObject, ILocationRequest
	{
		public static G2M_RequestExitGame Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2M_RequestExitGame), isFromPool) as G2M_RequestExitGame; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.M2G_RequestExitGame)]
	[MemoryPackable]
	public partial class M2G_RequestExitGame: MessageObject, ILocationResponse
	{
		public static M2G_RequestExitGame Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(M2G_RequestExitGame), isFromPool) as M2G_RequestExitGame; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(90)]
		public int Error { get; set; }

		[MemoryPackOrder(91)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[ResponseType(nameof(L2G_RemoveLoginRecord))]
	[Message(InnerMessage.G2L_RemoveLoginRecord)]
	[MemoryPackable]
	public partial class G2L_RemoveLoginRecord: MessageObject, IRequest
	{
		public static G2L_RemoveLoginRecord Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(G2L_RemoveLoginRecord), isFromPool) as G2L_RemoveLoginRecord; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(0)]
		public long AccountId { get; set; }

		[MemoryPackOrder(1)]
		public int ServerId { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.AccountId = default;
			this.ServerId = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	[Message(InnerMessage.L2G_RemoveLoginRecord)]
	[MemoryPackable]
	public partial class L2G_RemoveLoginRecord: MessageObject, IResponse
	{
		public static L2G_RemoveLoginRecord Create(bool isFromPool = false) 
		{ 
			return ObjectPool.Instance.Fetch(typeof(L2G_RemoveLoginRecord), isFromPool) as L2G_RemoveLoginRecord; 
		}

		[MemoryPackOrder(89)]
		public int RpcId { get; set; }

		[MemoryPackOrder(90)]
		public int Error { get; set; }

		[MemoryPackOrder(91)]
		public string Message { get; set; }

		public override void Dispose() 
		{
			if (!this.IsFromPool) return;
			this.RpcId = default;
			this.Error = default;
			this.Message = default;
			
			ObjectPool.Instance.Recycle(this); 
		}

	}

	public static class InnerMessage
	{
		 public const ushort ObjectQueryRequest = 20002;
		 public const ushort M2A_Reload = 20003;
		 public const ushort A2M_Reload = 20004;
		 public const ushort G2G_LockRequest = 20005;
		 public const ushort G2G_LockResponse = 20006;
		 public const ushort G2G_LockReleaseRequest = 20007;
		 public const ushort G2G_LockReleaseResponse = 20008;
		 public const ushort ObjectAddRequest = 20009;
		 public const ushort ObjectAddResponse = 20010;
		 public const ushort ObjectLockRequest = 20011;
		 public const ushort ObjectLockResponse = 20012;
		 public const ushort ObjectUnLockRequest = 20013;
		 public const ushort ObjectUnLockResponse = 20014;
		 public const ushort ObjectRemoveRequest = 20015;
		 public const ushort ObjectRemoveResponse = 20016;
		 public const ushort ObjectGetRequest = 20017;
		 public const ushort ObjectGetResponse = 20018;
		 public const ushort R2G_GetLoginKey = 20019;
		 public const ushort G2R_GetLoginKey = 20020;
		 public const ushort G2M_SessionDisconnect = 20021;
		 public const ushort ObjectQueryResponse = 20022;
		 public const ushort M2M_UnitTransferRequest = 20023;
		 public const ushort M2M_UnitTransferResponse = 20024;
		 public const ushort A2L_LoginAccountRequest = 20025;
		 public const ushort L2A_LoginAccountResponse = 20026;
		 public const ushort L2G_DisconnectGateUnit = 20027;
		 public const ushort G2L_DisconnectGateUnit = 20028;
		 public const ushort A2R_GetRealmKey = 20029;
		 public const ushort R2A_GetRealmKey = 20030;
		 public const ushort R2G_GetLogingGateKey = 20031;
		 public const ushort G2R_GetLogingGateKey = 20032;
		 public const ushort G2L_AddLoginRecord = 20033;
		 public const ushort L2G_AddLoginRecord = 20034;
		 public const ushort G2M_RequestEnterGameState = 20035;
		 public const ushort M2G_RequestEnterGameState = 20036;
		 public const ushort G2M_RequestExitGame = 20037;
		 public const ushort M2G_RequestExitGame = 20038;
		 public const ushort G2L_RemoveLoginRecord = 20039;
		 public const ushort L2G_RemoveLoginRecord = 20040;
	}
}
