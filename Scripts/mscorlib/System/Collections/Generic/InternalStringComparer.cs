namespace System.Collections.Generic;

[Serializable]
internal sealed class InternalStringComparer : EqualityComparer<string>
{
	public override int GetHashCode(string obj)
	{
		return 0;
	}

	public override bool Equals(string x, string y)
	{
		return false;
	}

	internal override int IndexOf(string[] array, string value, int startIndex, int count)
	{
		return 0;
	}
}
