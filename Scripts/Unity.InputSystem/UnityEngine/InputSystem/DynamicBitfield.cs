using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

internal struct DynamicBitfield
{
	public InlinedArray<ulong> array;

	public int length;

	public void SetLength(int newLength)
	{
	}

	public void SetBit(int bitIndex)
	{
	}

	public bool TestBit(int bitIndex)
	{
		return false;
	}

	public void ClearBit(int bitIndex)
	{
	}

	private static int BitCountToULongCount(int bitCount)
	{
		return 0;
	}
}
