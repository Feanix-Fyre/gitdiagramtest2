using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting;

internal abstract class ServerIdentity : Identity
{
	protected Type _objectType;

	protected MarshalByRefObject _serverObject;

	protected IMessageSink _serverSink;

	protected Context _context;

	protected Lease _lease;

	public Type ObjectType => null;

	public Lease Lease => null;

	public Context Context
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ServerIdentity(string objectUri, Context context, Type objectType)
		: base(null)
	{
	}

	public void StartTrackingLifetime(ILease lease)
	{
	}

	public virtual void OnLifetimeExpired()
	{
	}

	public override ObjRef CreateObjRef(Type requestedType)
	{
		return null;
	}

	public void AttachServerObject(MarshalByRefObject serverObject, Context context)
	{
	}

	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	protected void DisposeServerObject()
	{
	}
}
