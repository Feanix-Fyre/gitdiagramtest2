using System;

namespace Steamworks;

public static class SteamNetworkingMessages
{
	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel)
	{
		return default(EResult);
	}

	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages)
	{
		return 0;
	}

	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote)
	{
		return false;
	}

	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote)
	{
		return false;
	}

	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel)
	{
		return false;
	}

	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus)
	{
		pConnectionInfo = default(SteamNetConnectionInfo_t);
		pQuickStatus = default(SteamNetConnectionRealTimeStatus_t);
		return default(ESteamNetworkingConnectionState);
	}
}
