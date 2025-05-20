namespace UnityEngine.InputSystem.Utilities;

internal static class MemoryHelpers
{
	public struct BitRegion
	{
		public uint bitOffset;

		public uint sizeInBits;

		public bool isEmpty => false;

		public BitRegion(uint bitOffset, uint sizeInBits)
		{
			this.bitOffset = 0u;
			this.sizeInBits = 0u;
		}

		public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits)
		{
			this.bitOffset = 0u;
			this.sizeInBits = 0u;
		}

		public BitRegion Overlap(BitRegion other)
		{
			return default(BitRegion);
		}
	}

	public unsafe static bool Compare(void* ptr1, void* ptr2, BitRegion region)
	{
		return false;
	}

	public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits)
	{
		return 0u;
	}

	public unsafe static void WriteSingleBit(void* ptr, uint bitOffset, bool value)
	{
	}

	public unsafe static bool ReadSingleBit(void* ptr, uint bitOffset)
	{
		return false;
	}

	public unsafe static void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount)
	{
	}

	public unsafe static bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask = null)
	{
		return false;
	}

	public unsafe static void MemSet(void* destination, int numBytes, byte value)
	{
	}

	public unsafe static void MemCpyMasked(void* destination, void* source, int numBytes, void* mask)
	{
	}

	public unsafe static uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount)
	{
		return 0u;
	}

	public unsafe static void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value)
	{
	}

	public unsafe static int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount)
	{
		return 0;
	}

	public unsafe static void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value)
	{
	}

	public unsafe static int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount)
	{
		return 0;
	}

	public unsafe static void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value)
	{
	}

	public unsafe static float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount)
	{
		return 0f;
	}

	public unsafe static void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value)
	{
	}

	public unsafe static void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value)
	{
	}

	public static void Swap<TValue>(ref TValue a, ref TValue b)
	{
	}

	public static uint AlignNatural(uint offset, uint sizeInBytes)
	{
		return 0u;
	}
}
