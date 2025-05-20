namespace System.Data;

internal sealed class DataError
{
	internal struct ColumnError
	{
		internal DataColumn _column;

		internal string _error;
	}

	private string _rowError;

	private int _count;

	private ColumnError[] _errorList;

	internal string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool HasErrors => false;

	internal DataError()
	{
	}

	internal DataError(string rowError)
	{
	}

	internal void SetColumnError(DataColumn column, string error)
	{
	}

	internal string GetColumnError(DataColumn column)
	{
		return null;
	}

	internal void Clear(DataColumn column)
	{
	}

	internal void Clear()
	{
	}

	internal DataColumn[] GetColumnsInError()
	{
		return null;
	}

	private void SetText(string errorText)
	{
	}

	internal int IndexOf(DataColumn column)
	{
		return 0;
	}
}
