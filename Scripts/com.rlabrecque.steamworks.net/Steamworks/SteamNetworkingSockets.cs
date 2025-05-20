using System;

namespace Steamworks;

public static class SteamNetworkingSockets
{
	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		return default(HSteamListenSocket);
	}

	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		return default(HSteamNetConnection);
	}

	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		return default(HSteamListenSocket);
	}

	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		return default(HSteamNetConnection);
	}

	public static EResult AcceptConnection(HSteamNetConnection hConn)
	{
		return default(EResult);
	}

	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger)
	{
		return false;
	}

	public static bool CloseListenSocket(HSteamListenSocket hSocket)
	{
		return false;
	}

	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData)
	{
		return false;
	}

	public static long GetConnectionUserData(HSteamNetConnection hPeer)
	{
		return 0L;
	}

	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName)
	{
	}

	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen)
	{
		pszName = null;
		return false;
	}

	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber)
	{
		pOutMessageNumber = default(long);
		return default(EResult);
	}

	public static void SendMessages(int nMessages, IntPtr[] pMessages, long[] pOutMessageNumberOrResult)
	{
	}

	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn)
	{
		return default(EResult);
	}

	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages)
	{
		return 0;
	}

	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo)
	{
		pInfo = default(SteamNetConnectionInfo_t);
		return false;
	}

	public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes)
	{
		return default(EResult);
	}

	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf)
	{
		pszBuf = null;
		return 0;
	}

	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address)
	{
		address = default(SteamNetworkingIPAddr);
		return false;
	}

	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2)
	{
		pOutConnection1 = default(HSteamNetConnection);
		pOutConnection2 = default(HSteamNetConnection);
		return false;
	}

	public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int[] pLanePriorities, ushort[] pLaneWeights)
	{
		return default(EResult);
	}

	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity)
	{
		pIdentity = default(SteamNetworkingIdentity);
		return false;
	}

	public static ESteamNetworkingAvailability InitAuthentication()
	{
		return default(ESteamNetworkingAvailability);
	}

	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails)
	{
		pDetails = default(SteamNetAuthenticationStatus_t);
		return default(ESteamNetworkingAvailability);
	}

	public static HSteamNetPollGroup CreatePollGroup()
	{
		return default(HSteamNetPollGroup);
	}

	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
	{
		return false;
	}

	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup)
	{
		return false;
	}

	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages)
	{
		return 0;
	}

	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket)
	{
		pOutParsedTicket = default(SteamDatagramRelayAuthTicket);
		return false;
	}

	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket)
	{
		pOutParsedTicket = default(SteamDatagramRelayAuthTicket);
		return 0;
	}

	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		return default(HSteamNetConnection);
	}

	public static ushort GetHostedDedicatedServerPort()
	{
		return 0;
	}

	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
	{
		return default(SteamNetworkingPOPID);
	}

	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting)
	{
		pRouting = default(SteamDatagramHostedAddress);
		return default(EResult);
	}

	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		return default(HSteamListenSocket);
	}

	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob)
	{
		pcbSignedBlob = default(int);
		return default(EResult);
	}

	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		pSignaling = default(ISteamNetworkingConnectionSignaling);
		return default(HSteamNetConnection);
	}

	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext)
	{
		pContext = default(ISteamNetworkingSignalingRecvContext);
		return false;
	}

	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg)
	{
		pcbBlob = default(int);
		errMsg = default(SteamNetworkingErrMsg);
		return false;
	}

	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg)
	{
		errMsg = default(SteamNetworkingErrMsg);
		return false;
	}

	public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity)
	{
	}

	public static void RunCallbacks()
	{
	}

	public static bool BeginAsyncRequestFakeIP(int nNumPorts)
	{
		return false;
	}

	public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo)
	{
		pInfo = default(SteamNetworkingFakeIPResult_t);
	}

	public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
	{
		return default(HSteamListenSocket);
	}

	public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr)
	{
		pOutAddr = default(SteamNetworkingIPAddr);
		return default(EResult);
	}

	public static IntPtr CreateFakeUDPPort(int idxFakeServerPort)
	{
		return (IntPtr)0;
	}
}
