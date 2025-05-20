namespace System.Runtime.Remoting;

internal class ClientIdentity : Identity
{
	private WeakReference _proxyReference;

	public MarshalByRefObject ClientProxy
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string TargetUri => null;

	public ClientIdentity(string objectUri, ObjRef objRef)
		: base(null)
	{
	}

	public override ObjRef CreateObjRef(Type requestedType)
	{
		return null;
	}
}
