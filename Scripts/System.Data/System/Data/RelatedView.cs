namespace System.Data;

internal sealed class RelatedView : DataView, IFilter
{
	private readonly DataKey? _parentKey;

	private readonly DataKey _childKey;

	private readonly DataRowView _parentRowView;

	private readonly object[] _filterValues;

	public RelatedView(DataColumn[] columns, object[] values)
		: base(null, locked: false)
	{
	}

	public RelatedView(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns)
		: base(null, locked: false)
	{
	}

	private object[] GetParentValues()
	{
		return null;
	}

	public bool Invoke(DataRow row, DataRowVersion version)
	{
		return false;
	}

	internal override IFilter GetFilter()
	{
		return null;
	}

	public override DataRowView AddNew()
	{
		return null;
	}

	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
	{
	}
}
