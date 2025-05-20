namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class EnvoyTerminatorSink : IMessageSink
{
	public static EnvoyTerminatorSink Instance;

	public IMessage SyncProcessMessage(IMessage msg)
	{
		return null;
	}

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		return null;
	}
}
