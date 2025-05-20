namespace System.Runtime.Remoting;

[Serializable]
internal class ChannelInfo : IChannelInfo
{
	private object[] channelData;

	public object[] ChannelData => null;

	public ChannelInfo()
	{
	}

	public ChannelInfo(object remoteChannelData)
	{
	}
}
