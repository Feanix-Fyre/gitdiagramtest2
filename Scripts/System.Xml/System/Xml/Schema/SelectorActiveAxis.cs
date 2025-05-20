using System.Collections;

namespace System.Xml.Schema;

internal class SelectorActiveAxis : ActiveAxis
{
	private ConstraintStruct cs;

	private ArrayList KSs;

	private int KSpointer;

	public int lastDepth => 0;

	public SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs)
		: base(null)
	{
	}

	public override bool EndElement(string localname, string URN)
	{
		return false;
	}

	public int PushKS(int errline, int errcol)
	{
		return 0;
	}

	public KeySequence PopKS()
	{
		return null;
	}
}
