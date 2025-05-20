using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Unity.Burst;

internal static class BurstString
{
	internal class PreserveAttribute : Attribute
	{
	}

	private enum NumberBufferKind
	{
		Integer = 0,
		Float = 1
	}

	private struct NumberBuffer
	{
		private unsafe readonly byte* _buffer;

		public NumberBufferKind Kind;

		public int DigitsCount;

		public int Scale;

		public readonly bool IsNegative;

		public unsafe NumberBuffer(NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative)
		{
			_buffer = null;
			Kind = default(NumberBufferKind);
			DigitsCount = 0;
			Scale = 0;
			IsNegative = false;
		}

		public unsafe byte* GetDigitsPointer()
		{
			return null;
		}
	}

	public enum NumberFormatKind : byte
	{
		General = 0,
		Decimal = 1,
		DecimalForceSigned = 2,
		Hexadecimal = 3
	}

	public struct FormatOptions
	{
		public NumberFormatKind Kind;

		public sbyte AlignAndSize;

		public byte Specifier;

		public bool Lowercase;

		public bool Uppercase => false;

		public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase)
		{
			Kind = default(NumberFormatKind);
			AlignAndSize = 0;
			Specifier = 0;
			Lowercase = false;
		}

		public int EncodeToRaw()
		{
			return 0;
		}

		public int GetBase()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}

	public struct tBigInt
	{
		private const int c_BigInt_MaxBlocks = 35;

		public int m_length;

		public unsafe fixed uint m_blocks[35];

		public int GetLength()
		{
			return 0;
		}

		public uint GetBlock(int idx)
		{
			return 0u;
		}

		public void SetZero()
		{
		}

		public bool IsZero()
		{
			return false;
		}

		public void SetU64(ulong val)
		{
		}

		public void SetU32(uint val)
		{
		}

		public uint GetU32()
		{
			return 0u;
		}
	}

	public enum CutoffMode
	{
		Unique = 0,
		TotalLength = 1,
		FractionLength = 2
	}

	public enum PrintFloatFormat
	{
		Positional = 0,
		Scientific = 1
	}

	[StructLayout((LayoutKind)2)]
	public struct tFloatUnion32
	{
		[FieldOffset(0)]
		public float m_floatingPoint;

		[FieldOffset(0)]
		public uint m_integer;

		public bool IsNegative()
		{
			return false;
		}

		public uint GetExponent()
		{
			return 0u;
		}

		public uint GetMantissa()
		{
			return 0u;
		}
	}

	[StructLayout((LayoutKind)2)]
	public struct tFloatUnion64
	{
		[FieldOffset(0)]
		public double m_floatingPoint;

		[FieldOffset(0)]
		public ulong m_integer;

		public bool IsNegative()
		{
			return false;
		}

		public uint GetExponent()
		{
			return 0u;
		}

		public ulong GetMantissa()
		{
			return 0uL;
		}
	}

	private static readonly char[] SplitByColon;

	private static readonly byte[] logTable;

	private static readonly uint[] g_PowerOf10_U32;

	private static readonly byte[] InfinityString;

	private static readonly byte[] NanString;

	private const int SinglePrecision = 9;

	private const int DoublePrecision = 17;

	internal const int SingleNumberBufferLength = 10;

	internal const int DoubleNumberBufferLength = 18;

	private const int SinglePrecisionCustomFormat = 7;

	private const int DoublePrecisionCustomFormat = 15;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Preserve]
	public unsafe static void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw)
	{
	}

	[Preserve]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options)
	{
	}

	private static int GetLengthIntegerToString(long value, int basis, int zeroPadding)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options)
	{
	}

	private unsafe static void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options)
	{
	}

	private unsafe static void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign)
	{
	}

	private static byte ValueToIntegerChar(int value, bool uppercase)
	{
		return 0;
	}

	private static void OptsSplit(string fullFormat, out string padding, out string format)
	{
		padding = null;
		format = null;
	}

	public static FormatOptions ParseFormatToFormatOptions(string fullFormat)
	{
		return default(FormatOptions);
	}

	private unsafe static bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length)
	{
		return false;
	}

	private unsafe static bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length)
	{
		return false;
	}

	private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar)
	{
	}

	private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded)
	{
	}

	private unsafe static bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded)
	{
		return false;
	}

	private static uint LogBase2(uint val)
	{
		return 0u;
	}

	private static int BigInt_Compare(in tBigInt lhs, in tBigInt rhs)
	{
		return 0;
	}

	private static void BigInt_Add(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_Add_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_Multiply_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, uint rhs)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_Multiply2(out tBigInt pResult, in tBigInt input)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_Multiply2(ref tBigInt pResult)
	{
	}

	private static void BigInt_Multiply10(ref tBigInt pResult)
	{
	}

	private static tBigInt g_PowerOf10_Big(int i)
	{
		return default(tBigInt);
	}

	private static void BigInt_Pow10(out tBigInt pResult, uint exponent)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_MultiplyPow10(out tBigInt pResult, in tBigInt input, uint exponent)
	{
		pResult = default(tBigInt);
	}

	private static void BigInt_Pow2(out tBigInt pResult, uint exponent)
	{
		pResult = default(tBigInt);
	}

	private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, in tBigInt divisor)
	{
		return 0u;
	}

	private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift)
	{
	}

	private unsafe static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent)
	{
		pOutExponent = default(int);
		return 0u;
	}

	private unsafe static int FormatPositional(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision)
	{
		return 0;
	}

	private unsafe static int FormatScientific(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision)
	{
		return 0;
	}

	private unsafe static void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions)
	{
	}
}
