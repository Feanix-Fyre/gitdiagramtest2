using System.Collections;

namespace System.Xml.Schema;

internal class ActiveAxis
{
	private int _currentDepth;

	private bool _isActive;

	private Asttree _axisTree;

	private ArrayList _axisStack;

	public int CurrentDepth => 0;

	internal void Reactivate()
	{
	}

	internal ActiveAxis(Asttree axisTree)
	{
	}

	public bool MoveToStartElement(string localname, string URN)
	{
		return false;
	}

	public virtual bool EndElement(string localname, string URN)
	{
		return false;
	}

	public bool MoveToAttribute(string localname, string URN)
	{
		return false;
	}
}
