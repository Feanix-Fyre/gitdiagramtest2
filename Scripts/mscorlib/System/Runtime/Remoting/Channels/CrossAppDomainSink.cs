using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels;

[MonoTODO("Handle domain unloading?")]
internal class CrossAppDomainSink : IMessageSink
{
	private struct ProcessMessageRes
	{
		public byte[] arrResponse;

		public CADMethodReturnMessage cadMrm;
	}

	private static Hashtable s_sinks;

	private static MethodInfo processMessageMethod;

	private int _domainID;

	internal int TargetDomainId => 0;

	internal CrossAppDomainSink(int domainID)
	{
	}

	internal static CrossAppDomainSink GetSink(int domainID)
	{
		return null;
	}

	private static ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg)
	{
		return default(ProcessMessageRes);
	}

	public virtual IMessage SyncProcessMessage(IMessage msgRequest)
	{
		return null;
	}

	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		return null;
	}

	public void SendAsyncMessage(object data)
	{
	}
}
