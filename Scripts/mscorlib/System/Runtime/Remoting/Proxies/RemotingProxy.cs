using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Proxies;

internal class RemotingProxy : RealProxy, IRemotingTypeInfo
{
	private static MethodInfo _cache_GetTypeMethod;

	private static MethodInfo _cache_GetHashCodeMethod;

	private IMessageSink _sink;

	private bool _hasEnvoySink;

	private ConstructionCall _ctorCall;

	public string TypeName => null;

	internal RemotingProxy(Type type, ClientIdentity identity)
	{
	}

	internal RemotingProxy(Type type, string activationUrl, object[] activationAttributes)
	{
	}

	public override IMessage Invoke(IMessage request)
	{
		return null;
	}

	internal void AttachIdentity(Identity identity)
	{
	}

	internal IMessage ActivateRemoteObject(IMethodMessage request)
	{
		return null;
	}

	public bool CanCastTo(Type fromType, object o)
	{
		return false;
	}

	~RemotingProxy()
	{
	}
}
