namespace System.Xml.Schema;

internal class LocatedActiveAxis : ActiveAxis
{
	private int column;

	internal bool isMatched;

	internal KeySequence Ks;

	internal int Column => 0;

	internal LocatedActiveAxis(Asttree astfield, KeySequence ks, int column)
		: base(null)
	{
	}

	internal void Reactivate(KeySequence ks)
	{
	}
}
