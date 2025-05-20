namespace System.Xml;

internal struct BinXmlSqlMoney
{
	private long data;

	public BinXmlSqlMoney(int v)
	{
		data = 0L;
	}

	public BinXmlSqlMoney(long v)
	{
		data = 0L;
	}

	public decimal ToDecimal()
	{
		return default(decimal);
	}

	public override string ToString()
	{
		return null;
	}
}
