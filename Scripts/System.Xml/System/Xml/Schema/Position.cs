namespace System.Xml.Schema;

internal struct Position
{
	public int symbol;

	public object particle;

	public Position(int symbol, object particle)
	{
		this.symbol = 0;
		this.particle = null;
	}
}
