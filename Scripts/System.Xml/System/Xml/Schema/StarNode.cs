namespace System.Xml.Schema;

internal sealed class StarNode : InteriorNode
{
	public override bool IsNullable => false;

	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
	{
	}
}
