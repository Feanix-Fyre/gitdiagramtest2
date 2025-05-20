namespace System.Xml.Schema;

internal class LeafNode : SyntaxTreeNode
{
	private int pos;

	public int Pos
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override bool IsNullable => false;

	public LeafNode(int pos)
	{
	}

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
	{
	}

	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
	{
	}
}
