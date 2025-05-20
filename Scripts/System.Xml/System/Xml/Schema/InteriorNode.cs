namespace System.Xml.Schema;

internal abstract class InteriorNode : SyntaxTreeNode
{
	private SyntaxTreeNode leftChild;

	private SyntaxTreeNode rightChild;

	public SyntaxTreeNode LeftChild
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SyntaxTreeNode RightChild
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
	{
	}

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
	{
	}
}
