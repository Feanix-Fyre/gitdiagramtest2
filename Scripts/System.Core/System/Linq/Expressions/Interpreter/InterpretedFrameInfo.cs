namespace System.Linq.Expressions.Interpreter;

internal readonly struct InterpretedFrameInfo
{
	private readonly string _methodName;

	private readonly DebugInfo _debugInfo;

	public InterpretedFrameInfo(string methodName, DebugInfo info)
	{
		_methodName = null;
		_debugInfo = null;
	}

	public override string ToString()
	{
		return null;
	}
}
