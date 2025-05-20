using System;

namespace Steamworks;

public static class SteamGameServerNetworkingUtils
{
	public static IntPtr AllocateMessage(int cbAllocateBuffer)
	{
		return (IntPtr)0;
	}

	public static void InitRelayNetworkAccess()
	{
	}

	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails)
	{
		pDetails = default(SteamRelayNetworkStatus_t);
		return default(ESteamNetworkingAvailability);
	}

	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result)
	{
		result = default(SteamNetworkPingLocation_t);
		return 0f;
	}

	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2)
	{
		return 0;
	}

	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation)
	{
		return 0;
	}

	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize)
	{
		pszBuf = null;
	}

	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result)
	{
		result = default(SteamNetworkPingLocation_t);
		return false;
	}

	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds)
	{
		return false;
	}

	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP)
	{
		pViaRelayPoP = default(SteamNetworkingPOPID);
		return 0;
	}

	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID)
	{
		return 0;
	}

	public static int GetPOPCount()
	{
		return 0;
	}

	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz)
	{
		list = default(SteamNetworkingPOPID);
		return 0;
	}

	public static SteamNetworkingMicroseconds GetLocalTimestamp()
	{
		return default(SteamNetworkingMicroseconds);
	}

	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc)
	{
	}

	public static bool IsFakeIPv4(uint nIPv4)
	{
		return false;
	}

	public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4)
	{
		return default(ESteamNetworkingFakeIPType);
	}

	public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity)
	{
		pOutRealIdentity = default(SteamNetworkingIdentity);
		return default(EResult);
	}

	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg)
	{
		return false;
	}

	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult)
	{
		pOutDataType = default(ESteamNetworkingConfigDataType);
		return default(ESteamNetworkingGetConfigValueResult);
	}

	public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope)
	{
		pOutDataType = default(ESteamNetworkingConfigDataType);
		pOutScope = default(ESteamNetworkingConfigScope);
		return null;
	}

	public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars)
	{
		return default(ESteamNetworkingConfigValue);
	}

	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort)
	{
		buf = null;
	}

	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr)
	{
		pAddr = default(SteamNetworkingIPAddr);
		return false;
	}

	public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr)
	{
		return default(ESteamNetworkingFakeIPType);
	}

	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf)
	{
		buf = null;
	}

	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr)
	{
		pIdentity = default(SteamNetworkingIdentity);
		return false;
	}
}
