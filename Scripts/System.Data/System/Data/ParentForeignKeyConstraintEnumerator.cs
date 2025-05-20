namespace System.Data;

internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
{
	private readonly DataTable _table;

	public ParentForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable)
		: base(null)
	{
	}

	protected override bool IsValidCandidate(Constraint constraint)
	{
		return false;
	}
}
