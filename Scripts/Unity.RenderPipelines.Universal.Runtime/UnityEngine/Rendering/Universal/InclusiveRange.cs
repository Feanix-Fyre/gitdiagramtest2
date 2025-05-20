namespace UnityEngine.Rendering.Universal;

internal struct InclusiveRange
{
	public short start;

	public short end;

	public bool isEmpty => false;

	public static InclusiveRange empty => default(InclusiveRange);

	public InclusiveRange(short startEnd)
	{
		start = 0;
		end = 0;
	}

	public InclusiveRange(short start, short end)
	{
		this.start = 0;
		this.end = 0;
	}

	public void Expand(short index)
	{
	}

	public void Clamp(short min, short max)
	{
	}

	public bool Contains(short index)
	{
		return false;
	}

	public static InclusiveRange Merge(InclusiveRange a, InclusiveRange b)
	{
		return default(InclusiveRange);
	}

	public override string ToString()
	{
		return null;
	}
}
