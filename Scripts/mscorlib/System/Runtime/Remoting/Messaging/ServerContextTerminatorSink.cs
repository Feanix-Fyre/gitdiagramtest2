namespace System.Runtime.Remoting.Messaging;

internal class ServerContextTerminatorSink : IMessageSink
{
	public IMessage SyncProcessMessage(IMessage msg)
	{
		return null;
	}

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		return null;
	}
}
