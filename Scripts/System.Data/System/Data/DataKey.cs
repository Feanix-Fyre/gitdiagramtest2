namespace System.Data;

internal readonly struct DataKey
{
	private readonly DataColumn[] _columns;

	internal DataColumn[] ColumnsReference => null;

	internal bool HasValue => false;

	internal DataTable Table => null;

	internal DataKey(DataColumn[] columns, bool copyColumns)
	{
		_columns = null;
	}

	internal void CheckState()
	{
	}

	internal bool ColumnsEqual(DataKey key)
	{
		return false;
	}

	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2)
	{
		return false;
	}

	internal bool ContainsColumn(DataColumn column)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	internal bool Equals(DataKey value)
	{
		return false;
	}

	internal string[] GetColumnNames()
	{
		return null;
	}

	internal IndexField[] GetIndexDesc()
	{
		return null;
	}

	internal object[] GetKeyValues(int record)
	{
		return null;
	}

	internal Index GetSortIndex()
	{
		return null;
	}

	internal Index GetSortIndex(DataViewRowState recordStates)
	{
		return null;
	}

	internal bool RecordsEqual(int record1, int record2)
	{
		return false;
	}

	internal DataColumn[] ToArray()
	{
		return null;
	}
}
