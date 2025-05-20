using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace System.Runtime.Remoting.Activation;

internal class ActivationServices
{
	private static IActivator _constructionActivator;

	private static IActivator ConstructionActivator => null;

	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall)
	{
		return null;
	}

	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
	{
		return null;
	}

	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes)
	{
		return null;
	}

	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
	{
		return null;
	}

	public static object CreateProxyForType(Type type)
	{
		return null;
	}

	public static object AllocateUninitializedClassInstance(Type type)
	{
		return null;
	}

	public static void EnableProxyActivation(Type type, bool enable)
	{
	}
}
