namespace System.Linq.Expressions.Interpreter;

internal sealed class TryCatchFinallyHandler
{
	internal readonly int TryStartIndex;

	internal readonly int TryEndIndex;

	internal readonly int FinallyStartIndex;

	internal readonly int FinallyEndIndex;

	internal readonly int GotoEndTargetIndex;

	private readonly ExceptionHandler[] _handlers;

	internal bool IsFinallyBlockExist => false;

	internal ExceptionHandler[] Handlers => null;

	internal bool IsCatchBlockExist => false;

	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers)
	{
	}

	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers)
	{
	}

	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException)
	{
		handler = null;
		unwrappedException = null;
		return false;
	}

	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter)
	{
		return false;
	}
}
