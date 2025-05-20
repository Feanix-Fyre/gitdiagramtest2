namespace System.Xml.Schema;

internal sealed class QmarkNode : InteriorNode
{
	public override bool IsNullable => false;

	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
	{
	}
}
