using System.Collections;

namespace System.Xml.Schema;

internal class NamespaceListNode : SyntaxTreeNode
{
	protected NamespaceList namespaceList;

	protected object particle;

	public override bool IsNullable => false;

	public NamespaceListNode(NamespaceList namespaceList, object particle)
	{
	}

	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols)
	{
		return null;
	}

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
	{
	}

	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
	{
	}
}
