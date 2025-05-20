using System.Diagnostics;

namespace Unity.Collections;

[DebuggerTypeProxy(typeof(BitField32DebugView))]
[BurstCompatible]
public struct BitField32
{
	public uint Value;

	public BitField32(uint initialValue = 0u)
	{
		Value = 0u;
	}

	public void Clear()
	{
	}

	public void SetBits(int pos, bool value)
	{
	}

	public void SetBits(int pos, bool value, int numBits)
	{
	}

	public uint GetBits(int pos, int numBits = 1)
	{
		return 0u;
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
