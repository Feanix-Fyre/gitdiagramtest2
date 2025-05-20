namespace System.Xml;

internal struct BinXmlSqlDecimal
{
	internal byte m_bLen;

	internal byte m_bPrec;

	internal byte m_bScale;

	internal byte m_bSign;

	internal uint m_data1;

	internal uint m_data2;

	internal uint m_data3;

	internal uint m_data4;

	private static readonly byte NUMERIC_MAX_PRECISION;

	private static readonly byte MaxPrecision;

	private static readonly byte MaxScale;

	private static readonly int x_cNumeMax;

	private static readonly long x_lInt32Base;

	private static readonly ulong x_ulInt32Base;

	private static readonly ulong x_ulInt32BaseForMod;

	internal static readonly ulong x_llMax;

	private static readonly double DUINT_BASE;

	private static readonly double DUINT_BASE2;

	private static readonly double DUINT_BASE3;

	private static readonly uint[] x_rgulShiftBase;

	private static readonly byte[] rgCLenFromPrec;

	public bool IsPositive => false;

	public BinXmlSqlDecimal(byte[] data, int offset, bool trim)
	{
		m_bLen = 0;
		m_bPrec = 0;
		m_bScale = 0;
		m_bSign = 0;
		m_data1 = 0u;
		m_data2 = 0u;
		m_data3 = 0u;
		m_data4 = 0u;
	}

	private static uint UIntFromByteArray(byte[] data, int offset)
	{
		return 0u;
	}

	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR)
	{
		iulR = default(uint);
	}

	private static void MpNormalize(uint[] rgulU, ref int ciulU)
	{
	}

	private static char ChFromDigit(uint uiDigit)
	{
		return '\0';
	}

	public decimal ToDecimal()
	{
		return default(decimal);
	}

	private void TrimTrailingZeros()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
