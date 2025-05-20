namespace System.Linq.Expressions.Interpreter;

internal readonly struct RuntimeLabel
{
	public readonly int Index;

	public readonly int StackDepth;

	public readonly int ContinuationStackDepth;

	public RuntimeLabel(int index, int continuationStackDepth, int stackDepth)
	{
		Index = 0;
		StackDepth = 0;
		ContinuationStackDepth = 0;
	}

	public override string ToString()
	{
		return null;
	}
}
