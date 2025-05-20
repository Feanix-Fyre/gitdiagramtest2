namespace System.Data;

internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
{
	private readonly DataTable _table;

	public ChildForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable)
		: base(null)
	{
	}

	protected override bool IsValidCandidate(Constraint constraint)
	{
		return false;
	}
}
