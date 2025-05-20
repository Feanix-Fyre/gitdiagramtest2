namespace System.Data;

internal readonly struct IndexField
{
	public readonly DataColumn Column;

	public readonly bool IsDescending;

	internal IndexField(DataColumn column, bool isDescending)
	{
		Column = null;
		IsDescending = false;
	}

	public static bool operator ==(IndexField if1, IndexField if2)
	{
		return false;
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
