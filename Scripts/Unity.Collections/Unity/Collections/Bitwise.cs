using System.Runtime.InteropServices;

namespace Unity.Collections;

[StructLayout((LayoutKind)0, Size = 1)]
[BurstCompatible]
internal struct Bitwise
{
	internal static int AlignDown(int value, int alignPow2)
	{
		return 0;
	}

	internal static int AlignUp(int value, int alignPow2)
	{
		return 0;
	}

	internal static int FromBool(bool value)
	{
		return 0;
	}

	internal static uint ExtractBits(uint input, int pos, uint mask)
	{
		return 0u;
	}

	internal static uint ReplaceBits(uint input, int pos, uint mask, uint value)
	{
		return 0u;
	}

	internal static uint SetBits(uint input, int pos, uint mask, bool value)
	{
		return 0u;
	}

	internal static ulong ExtractBits(ulong input, int pos, ulong mask)
	{
		return 0uL;
	}

	internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value)
	{
		return 0uL;
	}

	internal static ulong SetBits(ulong input, int pos, ulong mask, bool value)
	{
		return 0uL;
	}

	internal static int lzcnt(byte value)
	{
		return 0;
	}

	internal static int tzcnt(byte value)
	{
		return 0;
	}

	internal static int lzcnt(ushort value)
	{
		return 0;
	}

	internal static int tzcnt(ushort value)
	{
		return 0;
	}

	private unsafe static int FindUlong(ulong* ptr, int beginBit, int endBit, int numBits)
	{
		return 0;
	}

	private unsafe static int FindUint(ulong* ptr, int beginBit, int endBit, int numBits)
	{
		return 0;
	}

	private unsafe static int FindUshort(ulong* ptr, int beginBit, int endBit, int numBits)
	{
		return 0;
	}

	private unsafe static int FindByte(ulong* ptr, int beginBit, int endBit, int numBits)
	{
		return 0;
	}

	private unsafe static int FindUpto14bits(ulong* ptr, int beginBit, int endBit, int numBits)
	{
		return 0;
	}

	private unsafe static int FindUpto6bits(ulong* ptr, int beginBit, int endBit, int numBits)
	{
		return 0;
	}

	internal unsafe static int FindWithBeginEnd(ulong* ptr, int beginBit, int endBit, int numBits)
	{
		return 0;
	}

	internal unsafe static int Find(ulong* ptr, int pos, int count, int numBits)
	{
		return 0;
	}
}
