namespace System.Runtime.Remoting.Messaging;

internal class ServerObjectTerminatorSink : IMessageSink
{
	private IMessageSink _nextSink;

	public ServerObjectTerminatorSink(IMessageSink nextSink)
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
}
