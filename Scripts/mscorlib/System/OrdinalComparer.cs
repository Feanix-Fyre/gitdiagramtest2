namespace System;

[Serializable]
public class OrdinalComparer : StringComparer
{
	private readonly bool _ignoreCase;

	internal OrdinalComparer(bool ignoreCase)
	{
	}

	public override int Compare(string x, string y)
	{
		return 0;
	}

	public override bool Equals(string x, string y)
	{
		return false;
	}

	public override int GetHashCode(string obj)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
