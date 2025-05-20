namespace System.Linq.Expressions.Interpreter;

internal readonly struct LocalDefinition
{
	public int Index { get; }

	public ParameterExpression Parameter { get; }

	internal LocalDefinition(int localIndex, ParameterExpression parameter)
	{
		Index = 0;
		Parameter = null;
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
