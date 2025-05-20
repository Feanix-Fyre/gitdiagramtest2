using System;
using System.Runtime.InteropServices;

namespace Steamworks;

[Serializable]
[StructLayout((LayoutKind)0, Pack = 1, Size = 136)]
public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
{
	public ESteamNetworkingIdentityType m_eType;

	private int m_cbSize;

	private uint m_reserved0;

	private uint m_reserved1;

	private uint m_reserved2;

	private uint m_reserved3;

	private uint m_reserved4;

	private uint m_reserved5;

	private uint m_reserved6;

	private uint m_reserved7;

	private uint m_reserved8;

	private uint m_reserved9;

	private uint m_reserved10;

	private uint m_reserved11;

	private uint m_reserved12;

	private uint m_reserved13;

	private uint m_reserved14;

	private uint m_reserved15;

	private uint m_reserved16;

	private uint m_reserved17;

	private uint m_reserved18;

	private uint m_reserved19;

	private uint m_reserved20;

	private uint m_reserved21;

	private uint m_reserved22;

	private uint m_reserved23;

	private uint m_reserved24;

	private uint m_reserved25;

	private uint m_reserved26;

	private uint m_reserved27;

	private uint m_reserved28;

	private uint m_reserved29;

	private uint m_reserved30;

	private uint m_reserved31;

	public const int k_cchMaxString = 128;

	public const int k_cchMaxGenericString = 32;

	public const int k_cchMaxXboxPairwiseID = 33;

	public const int k_cbMaxGenericBytes = 32;

	public void Clear()
	{
	}

	public bool IsInvalid()
	{
		return false;
	}

	public void SetSteamID(CSteamID steamID)
	{
	}

	public CSteamID GetSteamID()
	{
		return default(CSteamID);
	}

	public void SetSteamID64(ulong steamID)
	{
	}

	public ulong GetSteamID64()
	{
		return 0uL;
	}

	public bool SetXboxPairwiseID(string pszString)
	{
		return false;
	}

	public string GetXboxPairwiseID()
	{
		return null;
	}

	public void SetPSNID(ulong id)
	{
	}

	public ulong GetPSNID()
	{
		return 0uL;
	}

	public void SetStadiaID(ulong id)
	{
	}

	public ulong GetStadiaID()
	{
		return 0uL;
	}

	public void SetIPAddr(SteamNetworkingIPAddr addr)
	{
	}

	public SteamNetworkingIPAddr GetIPAddr()
	{
		return default(SteamNetworkingIPAddr);
	}

	public void SetIPv4Addr(uint nIPv4, ushort nPort)
	{
	}

	public uint GetIPv4()
	{
		return 0u;
	}

	public ESteamNetworkingFakeIPType GetFakeIPType()
	{
		return default(ESteamNetworkingFakeIPType);
	}

	public bool IsFakeIP()
	{
		return false;
	}

	public void SetLocalHost()
	{
	}

	public bool IsLocalHost()
	{
		return false;
	}

	public bool SetGenericString(string pszString)
	{
		return false;
	}

	public string GetGenericString()
	{
		return null;
	}

	public bool SetGenericBytes(byte[] data, uint cbLen)
	{
		return false;
	}

	public byte[] GetGenericBytes(out int cbLen)
	{
		cbLen = default(int);
		return null;
	}

	public bool Equals(SteamNetworkingIdentity x)
	{
		return false;
	}

	public void ToString(out string buf)
	{
		buf = null;
	}

	public bool ParseString(string pszStr)
	{
		return false;
	}
}
