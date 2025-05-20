namespace System.Runtime.Remoting.Messaging;

internal class ServerObjectReplySink : IMessageSink
{
	private IMessageSink _replySink;

	private ServerIdentity _identity;

	public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
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
