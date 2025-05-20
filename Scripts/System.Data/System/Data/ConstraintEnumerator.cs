using System.Collections;

namespace System.Data;

internal class ConstraintEnumerator
{
	private IEnumerator _tables;

	private IEnumerator _constraints;

	private Constraint _currentObject;

	protected Constraint CurrentObject => null;

	public ConstraintEnumerator(DataSet dataSet)
	{
	}

	public bool GetNext()
	{
		return false;
	}

	public Constraint GetConstraint()
	{
		return null;
	}

	protected virtual bool IsValidCandidate(Constraint constraint)
	{
		return false;
	}
}
