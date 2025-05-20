using System.Diagnostics;

namespace Unity.Collections;

[DebuggerTypeProxy(typeof(BitField64DebugView))]
[BurstCompatible]
public struct BitField64
{
	public ulong Value;

	public BitField64(ulong initialValue = 0uL)
	{
		Value = 0uL;
	}

	public void Clear()
	{
	}

	public void SetBits(int pos, bool value)
	{
	}

	public void SetBits(int pos, bool value, int numBits = 1)
	{
	}

	public ulong GetBits(int pos, int numBits = 1)
	{
		return 0uL;
	}

	public bool IsSet(int pos)
	{
		return false;
	}

	public bool TestNone(int pos, int numBits = 1)
	{
		return false;
	}

	public bool TestAny(int pos, int numBits = 1)
	{
		return false;
	}

	public bool TestAll(int pos, int numBits = 1)
	{
		return false;
	}

	public int CountBits()
	{
		return 0;
	}

	public int CountLeadingZeros()
	{
		return 0;
	}

	public int CountTrailingZeros()
	{
		return 0;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckArgs(int pos, int numBits)
	{
	}
}
