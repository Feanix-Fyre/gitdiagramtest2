namespace System.Xml.Schema;

internal class AxisElement
{
	internal DoubleLinkAxis curNode;

	internal int rootDepth;

	internal int curDepth;

	internal bool isMatch;

	internal DoubleLinkAxis CurNode => null;

	internal AxisElement(DoubleLinkAxis node, int depth)
	{
	}

	internal void SetDepth(int depth)
	{
	}

	internal void MoveToParent(int depth, ForwardAxis parent)
	{
	}

	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent)
	{
		return false;
	}
}
