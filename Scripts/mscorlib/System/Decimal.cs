using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents a decimal floating-point number.</summary>
[Serializable]
[StructLayout((LayoutKind)2)]
public readonly struct Decimal : IFormattable, IComparable, IConvertible, IComparable<decimal>, IEquatable<decimal>, IDeserializationCallback, ISpanFormattable
{
	[StructLayout((LayoutKind)2)]
	private struct DecCalc
	{
		internal enum RoundingMode
		{
			ToEven = 0,
			AwayFromZero = 1,
			Truncate = 2,
			Floor = 3,
			Ceiling = 4
		}

		private struct PowerOvfl
		{
			public readonly uint Hi;

			public readonly ulong MidLo;

			public PowerOvfl(uint hi, uint mid, uint lo)
			{
				Hi = 0u;
				MidLo = 0uL;
			}
		}

		[StructLayout((LayoutKind)2)]
		private struct Buf12
		{
			[FieldOffset(0)]
			public uint U0;

			[FieldOffset(4)]
			public uint U1;

			[FieldOffset(8)]
			public uint U2;

			[FieldOffset(0)]
			private ulong ulo64LE;

			[FieldOffset(4)]
			private ulong uhigh64LE;

			public ulong Low64
			{
				get
				{
					return 0uL;
				}
				set
				{
				}
			}

			public ulong High64
			{
				get
				{
					return 0uL;
				}
				set
				{
				}
			}
		}

		[StructLayout((LayoutKind)2)]
		private struct Buf16
		{
			[FieldOffset(0)]
			public uint U0;

			[FieldOffset(4)]
			public uint U1;

			[FieldOffset(8)]
			public uint U2;

			[FieldOffset(12)]
			public uint U3;

			[FieldOffset(0)]
			private ulong ulo64LE;

			[FieldOffset(8)]
			private ulong uhigh64LE;

			public ulong Low64
			{
				get
				{
					return 0uL;
				}
				set
				{
				}
			}

			public ulong High64
			{
				get
				{
					return 0uL;
				}
				set
				{
				}
			}
		}

		[StructLayout((LayoutKind)2)]
		private struct Buf24
		{
			[FieldOffset(0)]
			public uint U0;

			[FieldOffset(4)]
			public uint U1;

			[FieldOffset(8)]
			public uint U2;

			[FieldOffset(12)]
			public uint U3;

			[FieldOffset(16)]
			public uint U4;

			[FieldOffset(20)]
			public uint U5;

			[FieldOffset(0)]
			private ulong ulo64LE;

			[FieldOffset(8)]
			private ulong umid64LE;

			[FieldOffset(16)]
			private ulong uhigh64LE;

			public ulong Low64
			{
				get
				{
					return 0uL;
				}
				set
				{
				}
			}

			public ulong Mid64
			{
				set
				{
				}
			}

			public ulong High64
			{
				set
				{
				}
			}
		}

		[FieldOffset(0)]
		private uint uflags;

		[FieldOffset(4)]
		private uint uhi;

		[FieldOffset(8)]
		private uint ulo;

		[FieldOffset(12)]
		private uint umid;

		[FieldOffset(8)]
		private ulong ulomidLE;

		private static readonly uint[] s_powers10;

		private static readonly ulong[] s_ulongPowers10;

		private static readonly double[] s_doublePowers10;

		private static readonly PowerOvfl[] PowerOvflValues;

		private uint High
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		private uint Low
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		private uint Mid
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		private bool IsNegative => false;

		private ulong Low64
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		private static uint GetExponent(float f)
		{
			return 0u;
		}

		private static uint GetExponent(double d)
		{
			return 0u;
		}

		private static ulong UInt32x32To64(uint a, uint b)
		{
			return 0uL;
		}

		private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result)
		{
		}

		private static uint Div96By32(ref Buf12 bufNum, uint den)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Unscale(ref uint low, ref ulong high64, ref int scale)
		{
		}

		private static uint Div96By64(ref Buf12 bufNum, ulong den)
		{
			return 0u;
		}

		private static uint Div128By96(ref Buf16 bufNum, ref Buf12 bufDen)
		{
			return 0u;
		}

		private static uint IncreaseScale(ref Buf12 bufNum, uint power)
		{
			return 0u;
		}

		private static void IncreaseScale64(ref Buf12 bufNum, uint power)
		{
		}

		private unsafe static int ScaleResult(Buf24* bufRes, uint hiRes, int scale)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
		{
			quotient = default(uint);
			remainder = default(uint);
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LeadingZeroCount(uint value)
		{
			return 0;
		}

		private static int OverflowUnscale(ref Buf12 bufQuo, int scale, bool sticky)
		{
			return 0;
		}

		private static int SearchScale(ref Buf12 bufQuo, int scale)
		{
			return 0;
		}

		private static bool Add32To96(ref Buf12 bufNum, uint value)
		{
			return false;
		}

		internal static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign)
		{
		}

		internal static int VarDecCmp(in decimal d1, in decimal d2)
		{
			return 0;
		}

		private static int VarDecCmpSub(in decimal d1, in decimal d2)
		{
			return 0;
		}

		internal static void VarDecMul(ref DecCalc d1, ref DecCalc d2)
		{
		}

		internal static void VarDecFromR4(float input, out DecCalc result)
		{
			result = default(DecCalc);
		}

		internal static void VarDecFromR8(double input, out DecCalc result)
		{
			result = default(DecCalc);
		}

		internal static float VarR4FromDec(in decimal value)
		{
			return 0f;
		}

		internal static double VarR8FromDec(in decimal value)
		{
			return 0.0;
		}

		internal static int GetHashCode(in decimal d)
		{
			return 0;
		}

		internal static void VarDecDiv(ref DecCalc d1, ref DecCalc d2)
		{
		}

		internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode)
		{
		}

		internal static uint DecDivMod1E9(ref DecCalc value)
		{
			return 0u;
		}
	}

	private const int SignMask = int.MinValue;

	private const int ScaleMask = 16711680;

	private const int ScaleShift = 16;

	/// <summary>Represents the number zero (0).</summary>
	public const decimal Zero = 0m;

	/// <summary>Represents the number one (1).</summary>
	public const decimal One = 1m;

	/// <summary>Represents the number negative one (-1).</summary>
	public const decimal MinusOne = -1m;

	/// <summary>Represents the largest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary>
	public const decimal MaxValue = 79228162514264337593543950335m;

	/// <summary>Represents the smallest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary>
	public const decimal MinValue = -79228162514264337593543950335m;

	[FieldOffset(0)]
	private readonly int flags;

	[FieldOffset(4)]
	private readonly int hi;

	[FieldOffset(8)]
	private readonly int lo;

	[FieldOffset(12)]
	private readonly int mid;

	[FieldOffset(8)]
	[NonSerialized]
	private readonly ulong ulomidLE;

	internal uint High => 0u;

	internal uint Low => 0u;

	internal uint Mid => 0u;

	internal bool IsNegative => false;

	internal int Scale => 0;

	private ulong Low64 => 0uL;

	private static ref DecCalc AsMutable(ref decimal d)
	{
		throw null;
	}

	internal static uint DecDivMod1E9(ref decimal value)
	{
		return 0u;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit signed integer.</summary>
	/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />.</param>
	public Decimal(int value)
	{
		flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit unsigned integer.</summary>
	/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />.</param>
	[CLSCompliant(false)]
	public Decimal(uint value)
	{
		flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit signed integer.</summary>
	/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />.</param>
	public Decimal(long value)
	{
		flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit unsigned integer.</summary>
	/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />.</param>
	[CLSCompliant(false)]
	public Decimal(ulong value)
	{
		flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified single-precision floating-point number.</summary>
	/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />.</param>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.  
	/// -or-  
	/// <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />.</exception>
	public Decimal(float value)
	{
		flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified double-precision floating-point number.</summary>
	/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />.</param>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.  
	/// -or-  
	/// <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />.</exception>
	public Decimal(double value)
	{
		flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	private static bool IsValid(int flags)
	{
		return false;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to a decimal value represented in binary and contained in a specified array.</summary>
	/// <param name="bits">An array of 32-bit signed integers containing a representation of a decimal value.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bits" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The length of the <paramref name="bits" /> is not 4.  
	///  -or-  
	///  The representation of the decimal value in <paramref name="bits" /> is not valid.</exception>
	public Decimal(int[] bits)
	{
		flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> from parameters specifying the instance's constituent parts.</summary>
	/// <param name="lo">The low 32 bits of a 96-bit integer.</param>
	/// <param name="mid">The middle 32 bits of a 96-bit integer.</param>
	/// <param name="hi">The high 32 bits of a 96-bit integer.</param>
	/// <param name="isNegative">
	///   <see langword="true" /> to indicate a negative number; <see langword="false" /> to indicate a positive number.</param>
	/// <param name="scale">A power of 10 ranging from 0 to 28.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="scale" /> is greater than 28.</exception>
	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
	{
		flags = 0;
		this.hi = 0;
		this.lo = 0;
		this.mid = 0;
		ulomidLE = 0uL;
	}

	/// <summary>Runs when the deserialization of an object has been completed.</summary>
	/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Decimal" /> object contains invalid or corrupted data.</exception>
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	private Decimal(in decimal d, int flags)
	{
		this.flags = 0;
		hi = 0;
		lo = 0;
		mid = 0;
		ulomidLE = 0uL;
	}

	internal static decimal Abs(ref decimal d)
	{
		return default(decimal);
	}

	/// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The first value to add.</param>
	/// <param name="d2">The second value to add.</param>
	/// <returns>The sum of <paramref name="d1" /> and <paramref name="d2" />.</returns>
	/// <exception cref="T:System.OverflowException">The sum of <paramref name="d1" /> and <paramref name="d2" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal Add(decimal d1, decimal d2)
	{
		return default(decimal);
	}

	/// <summary>Compares two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The first value to compare.</param>
	/// <param name="d2">The second value to compare.</param>
	/// <returns>A signed number indicating the relative values of <paramref name="d1" /> and <paramref name="d2" />.  
	///   Return value  
	///
	///   Meaning  
	///
	///   Less than zero  
	///
	///  <paramref name="d1" /> is less than <paramref name="d2" />.  
	///
	///   Zero  
	///
	///  <paramref name="d1" /> and <paramref name="d2" /> are equal.  
	///
	///   Greater than zero  
	///
	///  <paramref name="d1" /> is greater than <paramref name="d2" />.</returns>
	public static int Compare(decimal d1, decimal d2)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified object and returns a comparison of their relative values.</summary>
	/// <param name="value">The object to compare with this instance, or <see langword="null" />.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
	///   Return value  
	///
	///   Meaning  
	///
	///   Less than zero  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than <paramref name="value" />.  
	///
	///  -or-  
	///
	///  <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.Decimal" />.</exception>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified <see cref="T:System.Decimal" /> object and returns a comparison of their relative values.</summary>
	/// <param name="value">The object to compare with this instance.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
	///   Return value  
	///
	///   Meaning  
	///
	///   Less than zero  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than <paramref name="value" />.</returns>
	public int CompareTo(decimal value)
	{
		return 0;
	}

	/// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The dividend.</param>
	/// <param name="d2">The divisor.</param>
	/// <returns>The result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns>
	/// <exception cref="T:System.DivideByZeroException">
	///   <paramref name="d2" /> is zero.</exception>
	/// <exception cref="T:System.OverflowException">The return value (that is, the quotient) is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal Divide(decimal d1, decimal d2)
	{
		return default(decimal);
	}

	/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Object" /> represent the same type and value.</summary>
	/// <param name="value">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is a <see cref="T:System.Decimal" /> and equal to this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Decimal" /> object represent the same value.</summary>
	/// <param name="value">An object to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
	public bool Equals(decimal value)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
	/// <returns>A string that represents the value of this instance.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
	/// <param name="format">A numeric format string.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.</exception>
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
	{
		charsWritten = default(int);
		return false;
	}

	/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified culture-specific format information.</summary>
	/// <param name="s">The string representation of the number to convert.</param>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific parsing information about <paramref name="s" />.</param>
	/// <returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is not of the correct format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal Parse(string s, IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified style and culture-specific format.</summary>
	/// <param name="s">The string representation of the number to convert.</param>
	/// <param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles" /> values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number" />.</param>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that supplies culture-specific information about the format of <paramref name="s" />.</param>
	/// <returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="style" /> and <paramref name="provider" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is not in the correct format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified style and culture-specific format. A return value indicates whether the conversion succeeded or failed.</summary>
	/// <param name="s">The string representation of the number to convert.</param>
	/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number" />.</param>
	/// <param name="provider">An object that supplies culture-specific parsing information about <paramref name="s" />.</param>
	/// <param name="result">When this method returns, contains the <see cref="T:System.Decimal" /> number that is equivalent to the numeric value contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not a number in a format compliant with <paramref name="style" />, or represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. This parameter is passed uininitialized; any value originally supplied in <paramref name="result" /> is overwritten.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result)
	{
		result = default(decimal);
		return false;
	}

	/// <summary>Converts the value of a specified instance of <see cref="T:System.Decimal" /> to its equivalent binary representation.</summary>
	/// <param name="d">The value to convert.</param>
	/// <returns>A 32-bit signed integer array with four elements that contain the binary representation of <paramref name="d" />.</returns>
	public static int[] GetBits(decimal d)
	{
		return null;
	}

	internal static ref decimal Max(ref decimal d1, ref decimal d2)
	{
		throw null;
	}

	internal static ref decimal Min(ref decimal d1, ref decimal d2)
	{
		throw null;
	}

	/// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The multiplicand.</param>
	/// <param name="d2">The multiplier.</param>
	/// <returns>The result of multiplying <paramref name="d1" /> and <paramref name="d2" />.</returns>
	/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal Multiply(decimal d1, decimal d2)
	{
		return default(decimal);
	}

	/// <summary>Returns the result of multiplying the specified <see cref="T:System.Decimal" /> value by negative one.</summary>
	/// <param name="d">The value to negate.</param>
	/// <returns>A decimal number with the value of <paramref name="d" />, but the opposite sign.  
	///  -or-  
	///  Zero, if <paramref name="d" /> is zero.</returns>
	public static decimal Negate(decimal d)
	{
		return default(decimal);
	}

	/// <summary>Rounds a <see cref="T:System.Decimal" /> value to a specified number of decimal places.</summary>
	/// <param name="d">A decimal number to round.</param>
	/// <param name="decimals">A value from 0 to 28 that specifies the number of decimal places to round to.</param>
	/// <returns>The decimal number equivalent to <paramref name="d" /> rounded to <paramref name="decimals" /> number of decimal places.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="decimals" /> is not a value from 0 to 28.</exception>
	public static decimal Round(decimal d, int decimals)
	{
		return default(decimal);
	}

	private static decimal Round(ref decimal d, int decimals, MidpointRounding mode)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>An 8-bit unsigned integer equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 8-bit signed integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>An 8-bit signed integer equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 16-bit signed integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>A 16-bit signed integer equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	public static short ToInt16(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent double-precision floating-point number.</summary>
	/// <param name="d">The decimal number to convert.</param>
	/// <returns>A double-precision floating-point number equivalent to <paramref name="d" />.</returns>
	public static double ToDouble(decimal d)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 32-bit signed integer.</summary>
	/// <param name="d">The decimal number to convert.</param>
	/// <returns>A 32-bit signed integer equivalent to the value of <paramref name="d" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="d" /> is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static int ToInt32(decimal d)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 64-bit signed integer.</summary>
	/// <param name="d">The decimal number to convert.</param>
	/// <returns>A 64-bit signed integer equivalent to the value of <paramref name="d" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="d" /> is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static long ToInt64(decimal d)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>A 16-bit unsigned integer equivalent to the value of <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" /> or less than <see cref="F:System.UInt16.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 32-bit unsigned integer.</summary>
	/// <param name="d">The decimal number to convert.</param>
	/// <returns>A 32-bit unsigned integer equivalent to the value of <paramref name="d" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="d" /> is negative or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(decimal d)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 64-bit unsigned integer.</summary>
	/// <param name="d">The decimal number to convert.</param>
	/// <returns>A 64-bit unsigned integer equivalent to the value of <paramref name="d" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="d" /> is negative or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(decimal d)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent single-precision floating-point number.</summary>
	/// <param name="d">The decimal number to convert.</param>
	/// <returns>A single-precision floating-point number equivalent to the value of <paramref name="d" />.</returns>
	public static float ToSingle(decimal d)
	{
		return 0f;
	}

	/// <summary>Returns the integral digits of the specified <see cref="T:System.Decimal" />; any fractional digits are discarded.</summary>
	/// <param name="d">The decimal number to truncate.</param>
	/// <returns>The result of <paramref name="d" /> rounded toward zero, to the nearest whole number.</returns>
	public static decimal Truncate(decimal d)
	{
		return default(decimal);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void Truncate(ref decimal d)
	{
	}

	/// <summary>Defines an implicit conversion of an 8-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>The converted 8-bit unsigned integer.</returns>
	public static implicit operator decimal(byte value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of an 8-bit signed integer to a <see cref="T:System.Decimal" />.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>The converted 8-bit signed integer.</returns>
	[CLSCompliant(false)]
	public static implicit operator decimal(sbyte value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of a 16-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>The converted 16-bit signed integer.</returns>
	public static implicit operator decimal(short value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of a 16-bit unsigned integer to a <see cref="T:System.Decimal" />.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>The converted 16-bit unsigned integer.</returns>
	[CLSCompliant(false)]
	public static implicit operator decimal(ushort value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of a Unicode character to a <see cref="T:System.Decimal" />.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>The converted Unicode character.</returns>
	public static implicit operator decimal(char value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of a 32-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>The converted 32-bit signed integer.</returns>
	public static implicit operator decimal(int value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of a 32-bit unsigned integer to a <see cref="T:System.Decimal" />.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>The converted 32-bit unsigned integer.</returns>
	[CLSCompliant(false)]
	public static implicit operator decimal(uint value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of a 64-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>The converted 64-bit signed integer.</returns>
	public static implicit operator decimal(long value)
	{
		return default(decimal);
	}

	/// <summary>Defines an implicit conversion of a 64-bit unsigned integer to a <see cref="T:System.Decimal" />.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>The converted 64-bit unsigned integer.</returns>
	[CLSCompliant(false)]
	public static implicit operator decimal(ulong value)
	{
		return default(decimal);
	}

	/// <summary>Defines an explicit conversion of a single-precision floating-point number to a <see cref="T:System.Decimal" />.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>The converted single-precision floating point number.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.  
	/// -or-  
	/// <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />.</exception>
	public static explicit operator decimal(float value)
	{
		return default(decimal);
	}

	/// <summary>Defines an explicit conversion of a double-precision floating-point number to a <see cref="T:System.Decimal" />.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>The converted double-precision floating point number.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.  
	/// -or-  
	/// <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />.</exception>
	public static explicit operator decimal(double value)
	{
		return default(decimal);
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a 32-bit signed integer.</summary>
	/// <param name="value">The value to convert.</param>
	/// <returns>A 32-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static explicit operator int(decimal value)
	{
		return 0;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a 64-bit signed integer.</summary>
	/// <param name="value">The value to convert.</param>
	/// <returns>A 64-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static explicit operator long(decimal value)
	{
		return 0L;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a 64-bit unsigned integer.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="value">The value to convert.</param>
	/// <returns>A 64-bit unsigned integer that represents the converted <see cref="T:System.Decimal" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is negative or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static explicit operator ulong(decimal value)
	{
		return 0uL;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a single-precision floating-point number.</summary>
	/// <param name="value">The value to convert.</param>
	/// <returns>A single-precision floating-point number that represents the converted <see cref="T:System.Decimal" />.</returns>
	public static explicit operator float(decimal value)
	{
		return 0f;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a double-precision floating-point number.</summary>
	/// <param name="value">The value to convert.</param>
	/// <returns>A double-precision floating-point number that represents the converted <see cref="T:System.Decimal" />.</returns>
	public static explicit operator double(decimal value)
	{
		return 0.0;
	}

	/// <summary>Negates the value of the specified <see cref="T:System.Decimal" /> operand.</summary>
	/// <param name="d">The value to negate.</param>
	/// <returns>The result of <paramref name="d" /> multiplied by negative one (-1).</returns>
	public static decimal operator -(decimal d)
	{
		return default(decimal);
	}

	/// <summary>Increments the <see cref="T:System.Decimal" /> operand by 1.</summary>
	/// <param name="d">The value to increment.</param>
	/// <returns>The value of <paramref name="d" /> incremented by 1.</returns>
	/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal operator ++(decimal d)
	{
		return default(decimal);
	}

	/// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The first value to add.</param>
	/// <param name="d2">The second value to add.</param>
	/// <returns>The result of adding <paramref name="d1" /> and <paramref name="d2" />.</returns>
	/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal operator +(decimal d1, decimal d2)
	{
		return default(decimal);
	}

	/// <summary>Subtracts two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The minuend.</param>
	/// <param name="d2">The subtrahend.</param>
	/// <returns>The result of subtracting <paramref name="d2" /> from <paramref name="d1" />.</returns>
	/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal operator -(decimal d1, decimal d2)
	{
		return default(decimal);
	}

	/// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The first value to multiply.</param>
	/// <param name="d2">The second value to multiply.</param>
	/// <returns>The result of multiplying <paramref name="d1" /> by <paramref name="d2" />.</returns>
	/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal operator *(decimal d1, decimal d2)
	{
		return default(decimal);
	}

	/// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary>
	/// <param name="d1">The dividend.</param>
	/// <param name="d2">The divisor.</param>
	/// <returns>The result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns>
	/// <exception cref="T:System.DivideByZeroException">
	///   <paramref name="d2" /> is zero.</exception>
	/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal operator /(decimal d1, decimal d2)
	{
		return default(decimal);
	}

	/// <summary>Returns a value that indicates whether two <see cref="T:System.Decimal" /> values are equal.</summary>
	/// <param name="d1">The first value to compare.</param>
	/// <param name="d2">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(decimal d1, decimal d2)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether two <see cref="T:System.Decimal" /> objects have different values.</summary>
	/// <param name="d1">The first value to compare.</param>
	/// <param name="d2">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> are not equal; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(decimal d1, decimal d2)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than another specified <see cref="T:System.Decimal" />.</summary>
	/// <param name="d1">The first value to compare.</param>
	/// <param name="d2">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> is less than <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <(decimal d1, decimal d2)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than or equal to another specified <see cref="T:System.Decimal" />.</summary>
	/// <param name="d1">The first value to compare.</param>
	/// <param name="d2">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> is less than or equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <=(decimal d1, decimal d2)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than another specified <see cref="T:System.Decimal" />.</summary>
	/// <param name="d1">The first value to compare.</param>
	/// <param name="d2">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> is greater than <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator >(decimal d1, decimal d2)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than or equal to another specified <see cref="T:System.Decimal" />.</summary>
	/// <param name="d1">The first value to compare.</param>
	/// <param name="d2">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> is greater than or equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator >=(decimal d1, decimal d2)
	{
		return false;
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Decimal" />.</summary>
	/// <returns>The enumerated constant <see cref="F:System.TypeCode.Decimal" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the current instance is not zero; otherwise, <see langword="false" />.</returns>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>None. This conversion is not supported.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.SByte" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Byte" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Int16" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt16" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">The parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Int32" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt32" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Int64" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt64" />.</returns>
	/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Single" />.</returns>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Double" />.</returns>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, unchanged.</returns>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>None. This conversion is not supported.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
	/// <param name="type">The type to which to convert the value of this <see cref="T:System.Decimal" /> instance.</param>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies culture-specific information about the format of the returned value.</param>
	/// <returns>The value of the current instance, converted to a <paramref name="type" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The requested type conversion is not supported.</exception>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}
