using System.Runtime.Remoting.Proxies;

namespace System.Runtime.Remoting.Messaging;

internal class StackBuilderSink : IMessageSink
{
	private MarshalByRefObject _target;

	private RealProxy _rp;

	public StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute)
	{
	}

	public IMessage SyncProcessMessage(IMessage msg)
	{
		return null;
	}

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		return null;
	}

	private void ExecuteAsyncMessage(object ob)
	{
	}

	private void CheckParameters(IMessage msg)
	{
	}
}
