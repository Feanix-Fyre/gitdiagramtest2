namespace System.Xml.Schema;

internal class KeySequence
{
	private TypedObject[] ks;

	private int dim;

	private int hashcode;

	private int posline;

	private int poscol;

	public int PosLine => 0;

	public int PosCol => 0;

	public object this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal KeySequence(int dim, int line, int col)
	{
	}

	internal bool IsQualified()
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
