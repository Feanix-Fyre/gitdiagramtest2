namespace System.Linq.Expressions.Interpreter;

internal sealed class ExceptionHandler
{
	private readonly Type _exceptionType;

	public readonly int LabelIndex;

	public readonly int HandlerStartIndex;

	public readonly int HandlerEndIndex;

	public readonly ExceptionFilter Filter;

	internal ExceptionHandler(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter)
	{
	}

	public bool Matches(Type exceptionType)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
