using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Lifetime;

internal class LeaseSink : IMessageSink
{
	private IMessageSink _nextSink;

	public LeaseSink(IMessageSink nextSink)
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

	private void RenewLease(IMessage msg)
	{
	}
}
