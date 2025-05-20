using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels;

[Serializable]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
{
	private static object s_lock;

	public virtual string ChannelName => null;

	public virtual int ChannelPriority => 0;

	public virtual object ChannelData => null;

	internal static void RegisterCrossAppDomainChannel()
	{
	}

	public virtual void StartListening(object data)
	{
	}

	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri)
	{
		uri = null;
		return null;
	}
}
