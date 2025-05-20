namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariable
{
	public readonly int Index;

	private int _flags;

	public bool IsBoxed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool InClosure => false;

	internal LocalVariable(int index, bool closure)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
