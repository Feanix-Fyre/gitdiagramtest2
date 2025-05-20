using System.Collections;

namespace System.Xml.Schema;

internal class AxisStack
{
	private ArrayList _stack;

	private ForwardAxis _subtree;

	private ActiveAxis _parent;

	internal ForwardAxis Subtree => null;

	internal int Length => 0;

	public AxisStack(ForwardAxis faxis, ActiveAxis parent)
	{
	}

	internal void Push(int depth)
	{
	}

	internal void Pop()
	{
	}

	internal static bool Equal(string thisname, string thisURN, string name, string URN)
	{
		return false;
	}

	internal void MoveToParent(string name, string URN, int depth)
	{
	}

	internal bool MoveToChild(string name, string URN, int depth)
	{
		return false;
	}

	internal bool MoveToAttribute(string name, string URN, int depth)
	{
		return false;
	}
}
