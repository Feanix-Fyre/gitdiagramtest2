using System.Collections;

namespace System.Runtime.Remoting;

internal class ChannelData
{
	internal string Ref;

	internal string Type;

	internal string Id;

	internal string DelayLoadAsClientChannel;

	private ArrayList _serverProviders;

	private ArrayList _clientProviders;

	private Hashtable _customProperties;

	internal ArrayList ServerProviders => null;

	public ArrayList ClientProviders => null;

	public Hashtable CustomProperties => null;

	public void CopyFrom(ChannelData other)
	{
	}
}
