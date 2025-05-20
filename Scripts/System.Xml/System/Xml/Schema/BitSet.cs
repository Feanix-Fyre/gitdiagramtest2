namespace System.Xml.Schema;

internal sealed class BitSet
{
	private int count;

	private uint[] bits;

	public int Count => 0;

	public bool this[int index] => false;

	public bool IsEmpty => false;

	private BitSet()
	{
	}

	public BitSet(int count)
	{
	}

	public void Clear()
	{
	}

	public void Set(int index)
	{
	}

	public bool Get(int index)
	{
		return false;
	}

	public int NextSet(int startFrom)
	{
		return 0;
	}

	public void And(BitSet other)
	{
	}

	public void Or(BitSet other)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public BitSet Clone()
	{
		return null;
	}

	public bool Intersects(BitSet other)
	{
		return false;
	}

	private int Subscript(int bitIndex)
	{
		return 0;
	}

	private void EnsureLength(int nRequiredLength)
	{
	}
}
