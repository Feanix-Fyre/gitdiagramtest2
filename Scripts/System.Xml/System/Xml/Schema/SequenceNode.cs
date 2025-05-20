namespace System.Xml.Schema;

internal sealed class SequenceNode : InteriorNode
{
	private struct SequenceConstructPosContext
	{
		public SequenceNode this_;

		public BitSet firstpos;

		public BitSet lastpos;

		public BitSet lastposLeft;

		public BitSet firstposRight;

		public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
		{
			this_ = null;
			this.firstpos = null;
			this.lastpos = null;
			lastposLeft = null;
			firstposRight = null;
		}
	}

	public override bool IsNullable => false;

	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
	{
	}

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
	{
	}
}
