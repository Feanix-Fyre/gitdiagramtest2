namespace System.Data;

internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator
{
	public ForeignKeyConstraintEnumerator(DataSet dataSet)
		: base(null)
	{
	}

	protected override bool IsValidCandidate(Constraint constraint)
	{
		return false;
	}

	public ForeignKeyConstraint GetForeignKeyConstraint()
	{
		return null;
	}
}
