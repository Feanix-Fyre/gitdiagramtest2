using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents a numeric value between - 10^38 +1 and 10^38 - 1, with fixed precision and scale.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable
{
	internal byte _bStatus;

	internal byte _bLen;

	internal byte _bPrec;

	internal byte _bScale;

	internal uint _data1;

	internal uint _data2;

	internal uint _data3;

	internal uint _data4;

	private static readonly byte s_NUMERIC_MAX_PRECISION;

	/// <summary>A constant representing the largest possible value for the <see cref="P:System.Data.SqlTypes.SqlDecimal.Precision" /> property.</summary>
	public static readonly byte MaxPrecision;

	/// <summary>A constant representing the maximum value for the <see cref="P:System.Data.SqlTypes.SqlDecimal.Scale" /> property.</summary>
	public static readonly byte MaxScale;

	private static readonly byte s_bNullMask;

	private static readonly byte s_bIsNull;

	private static readonly byte s_bNotNull;

	private static readonly byte s_bReverseNullMask;

	private static readonly byte s_bSignMask;

	private static readonly byte s_bPositive;

	private static readonly byte s_bNegative;

	private static readonly byte s_bReverseSignMask;

	private static readonly uint s_uiZero;

	private static readonly int s_cNumeMax;

	private static readonly long s_lInt32Base;

	private static readonly ulong s_ulInt32Base;

	private static readonly ulong s_ulInt32BaseForMod;

	internal static readonly ulong s_llMax;

	private static readonly uint s_ulBase10;

	private static readonly double s_DUINT_BASE;

	private static readonly double s_DUINT_BASE2;

	private static readonly double s_DUINT_BASE3;

	private static readonly double s_DMAX_NUME;

	private static readonly uint s_DBL_DIG;

	private static readonly byte s_cNumeDivScaleMin;

	private static readonly uint[] s_rgulShiftBase;

	private static readonly uint[] s_decimalHelpersLo;

	private static readonly uint[] s_decimalHelpersMid;

	private static readonly uint[] s_decimalHelpersHi;

	private static readonly uint[] s_decimalHelpersHiHi;

	private static readonly byte[] s_rgCLenFromPrec;

	private static readonly uint s_ulT1;

	private static readonly uint s_ulT2;

	private static readonly uint s_ulT3;

	private static readonly uint s_ulT4;

	private static readonly uint s_ulT5;

	private static readonly uint s_ulT6;

	private static readonly uint s_ulT7;

	private static readonly uint s_ulT8;

	private static readonly uint s_ulT9;

	private static readonly ulong s_dwlT10;

	private static readonly ulong s_dwlT11;

	private static readonly ulong s_dwlT12;

	private static readonly ulong s_dwlT13;

	private static readonly ulong s_dwlT14;

	private static readonly ulong s_dwlT15;

	private static readonly ulong s_dwlT16;

	private static readonly ulong s_dwlT17;

	private static readonly ulong s_dwlT18;

	private static readonly ulong s_dwlT19;

	/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> class.</summary>
	public static readonly SqlDecimal Null;

	/// <summary>A constant representing the minimum value for a <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</summary>
	public static readonly SqlDecimal MinValue;

	/// <summary>A constant representing the maximum value of a <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</summary>
	public static readonly SqlDecimal MaxValue;

	/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure is null.</summary>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure is null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure. This property is read-only.</summary>
	/// <returns>A number in the range -79,228,162,514,264,337,593,543,950,335 through 79,228,162,514,162,514,264,337,593,543,950,335.</returns>
	public decimal Value => default(decimal);

	/// <summary>Indicates whether the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure is greater than zero.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> is assigned to null. Otherwise, <see langword="false" />.</returns>
	public bool IsPositive => false;

	/// <summary>Gets the number of decimal places to which <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> is resolved.</summary>
	/// <returns>The number of decimal places to which the <see langword="Value" /> property is resolved.</returns>
	public byte Scale => 0;

	/// <summary>Gets the binary representation of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure as an array of integers.</summary>
	/// <returns>An array of integers that contains the binary representation of this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</returns>
	public int[] Data => null;

	private byte CalculatePrecision()
	{
		return 0;
	}

	private bool VerifyPrecision(byte precision)
	{
		return false;
	}

	private SqlDecimal(bool fNull)
	{
		_bStatus = 0;
		_bLen = 0;
		_bPrec = 0;
		_bScale = 0;
		_data1 = 0u;
		_data2 = 0u;
		_data3 = 0u;
		_data4 = 0u;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied <see cref="T:System.Decimal" /> value.</summary>
	/// <param name="value">The <see cref="T:System.Decimal" /> value to be stored as a <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	public SqlDecimal(decimal value)
	{
		_bStatus = 0;
		_bLen = 0;
		_bPrec = 0;
		_bScale = 0;
		_data1 = 0u;
		_data2 = 0u;
		_data3 = 0u;
		_data4 = 0u;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied integer value.</summary>
	/// <param name="value">The supplied integer value which will the used as the value of the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	public SqlDecimal(int value)
	{
		_bStatus = 0;
		_bLen = 0;
		_bPrec = 0;
		_bScale = 0;
		_data1 = 0u;
		_data2 = 0u;
		_data3 = 0u;
		_data4 = 0u;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure using the supplied long integer value.</summary>
	/// <param name="value">The supplied long integer value which will the used as the value of the new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	public SqlDecimal(long value)
	{
		_bStatus = 0;
		_bLen = 0;
		_bPrec = 0;
		_bScale = 0;
		_data1 = 0u;
		_data2 = 0u;
		_data3 = 0u;
		_data4 = 0u;
	}

	private SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive)
	{
		_bStatus = 0;
		_bLen = 0;
		_bPrec = 0;
		_bScale = 0;
		_data1 = 0u;
		_data2 = 0u;
		_data3 = 0u;
		_data4 = 0u;
	}

	private void SetPositive()
	{
	}

	private void SetSignBit(bool fPositive)
	{
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.String" />.</summary>
	/// <returns>A new <see cref="T:System.String" /> object that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure's <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> representation of a number to its <see cref="T:System.Data.SqlTypes.SqlDecimal" /> equivalent.</summary>
	/// <param name="s">The <see langword="String" /> to be parsed.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> equivalent to the value that is contained in the specified <see cref="T:System.String" />.</returns>
	public static SqlDecimal Parse(string s)
	{
		return default(SqlDecimal);
	}

	/// <summary>Returns the a double equal to the contents of the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of this instance.</summary>
	/// <returns>The decimal representation of the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property.</returns>
	public double ToDouble()
	{
		return 0.0;
	}

	private decimal ToDecimal()
	{
		return default(decimal);
	}

	/// <summary>Converts the <see cref="T:System.Decimal" /> value to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
	/// <param name="x">The <see cref="T:System.Decimal" /> value to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the value of the <see langword="Decimal" /> parameter.</returns>
	public static implicit operator SqlDecimal(decimal x)
	{
		return default(SqlDecimal);
	}

	/// <summary>Converts the supplied <see cref="T:System.Int64" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
	/// <param name="x">The <see cref="T:System.Int64" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the value of the <see cref="T:System.Int64" /> parameter.</returns>
	public static implicit operator SqlDecimal(long x)
	{
		return default(SqlDecimal);
	}

	/// <summary>The unary minus operator negates the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be negated.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose value contains the results of the negation.</returns>
	public static SqlDecimal operator -(SqlDecimal x)
	{
		return default(SqlDecimal);
	}

	/// <summary>Calculates the sum of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operators.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the sum.</returns>
	public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlDecimal);
	}

	/// <summary>Calculates the results of subtracting the second <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand from the first.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose Value property contains the results of the subtraction.</returns>
	public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlDecimal);
	}

	/// <summary>The multiplication operator computes the product of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameters.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the product of the multiplication.</returns>
	public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlDecimal);
	}

	/// <summary>The division operator calculates the results of dividing the first <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operand by the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property contains the results of the division.</returns>
	public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlDecimal);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
	public static implicit operator SqlDecimal(SqlByte x)
	{
		return default(SqlDecimal);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" /></summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
	public static implicit operator SqlDecimal(SqlInt16 x)
	{
		return default(SqlDecimal);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
	public static implicit operator SqlDecimal(SqlInt32 x)
	{
		return default(SqlDecimal);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to SqlDecimal.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
	public static implicit operator SqlDecimal(SqlInt64 x)
	{
		return default(SqlDecimal);
	}

	/// <summary>Converts the <see cref="T:System.Data.SqlTypes.SqlMoney" /> operand to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
	public static implicit operator SqlDecimal(SqlMoney x)
	{
		return default(SqlDecimal);
	}

	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur)
	{
	}

	private bool FZero()
	{
		return false;
	}

	private bool FGt10_38()
	{
		return false;
	}

	private bool FGt10_38(uint[] rglData)
	{
		return false;
	}

	private static byte BGetPrecUI4(uint value)
	{
		return 0;
	}

	private static byte BGetPrecUI8(ulong dwlVal)
	{
		return 0;
	}

	private void AddULong(uint ulAdd)
	{
	}

	private void MultByULong(uint uiMultiplier)
	{
	}

	private uint DivByULong(uint iDivisor)
	{
		return 0u;
	}

	internal void AdjustScale(int digits, bool fRound)
	{
	}

	private int LAbsCmp(SqlDecimal snumOp)
	{
		return 0;
	}

	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD)
	{
		ciulD = default(int);
	}

	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN)
	{
		ciulD = default(int);
	}

	private static void MpNormalize(uint[] rgulU, ref int ciulU)
	{
	}

	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX)
	{
	}

	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR)
	{
		iulR = default(uint);
	}

	internal static ulong DWL(uint lo, uint hi)
	{
		return 0uL;
	}

	private static uint HI(ulong x)
	{
		return 0u;
	}

	private static uint LO(ulong x)
	{
		return 0u;
	}

	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR)
	{
		ciulQ = default(int);
		ciulR = default(int);
	}

	private EComparison CompareNm(SqlDecimal snumOp)
	{
		return default(EComparison);
	}

	private static void CheckValidPrecScale(byte bPrec, byte bScale)
	{
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> operands to determine whether they are equal.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator <(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator >(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structures to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
	public SqlDouble ToSqlDouble()
	{
		return default(SqlDouble);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
	public SqlInt64 ToSqlInt64()
	{
		return default(SqlInt64);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure with the same value as this instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</returns>
	public SqlMoney ToSqlMoney()
	{
		return default(SqlMoney);
	}

	private static char ChFromDigit(uint uiDigit)
	{
		return '\0';
	}

	private void StoreFromWorkingArray(uint[] rguiData)
	{
	}

	private void SetToZero()
	{
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than the object.  
	///
	///   Zero  
	///
	///   This instance is the same as the object.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than the object  
	///
	///  -or-  
	///
	///  The object is a null reference (<see langword="Nothing" /> in Visual Basic)</returns>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDecimal" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> object and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than the object.  
	///
	///   Zero  
	///
	///   This instance is the same as the object.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than the object  
	///
	///  -or-  
	///
	///  The object is a null reference (<see langword="Nothing" /> in Visual Basic)</returns>
	public int CompareTo(SqlDecimal value)
	{
		return 0;
	}

	/// <summary>Compares the supplied <see cref="T:System.Object" /> parameter to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> instance.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlDecimal" /> and the two are equal. Otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <returns>An <see langword="XmlSchema" />.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="reader">
	///   <see langword="XmlReader" />
	/// </param>
	void IXmlSerializable.ReadXml(XmlReader reader)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="writer">
	///   <see langword="XmlWriter" />
	/// </param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}

	/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
	{
		return null;
	}
}
