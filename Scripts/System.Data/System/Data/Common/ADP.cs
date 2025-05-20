namespace System.Data.Common;

internal static class ADP
{
	private static readonly Type s_stackOverflowType;

	private static readonly Type s_outOfMemoryType;

	private static readonly Type s_threadAbortType;

	private static readonly Type s_nullReferenceType;

	private static readonly Type s_accessViolationType;

	private static readonly Type s_securityType;

	internal static readonly string StrEmpty;

	internal static readonly string[] AzureSqlServerEndpoints;

	internal static readonly IntPtr PtrZero;

	internal static readonly int PtrSize;

	private static void TraceException(string trace, Exception e)
	{
	}

	internal static void TraceExceptionAsReturnValue(Exception e)
	{
	}

	internal static void TraceExceptionWithoutRethrow(Exception e)
	{
	}

	internal static ArgumentException Argument(string error)
	{
		return null;
	}

	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName)
	{
		return null;
	}

	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName)
	{
		return null;
	}

	internal static InvalidOperationException InvalidOperation(string error)
	{
		return null;
	}

	internal static NotSupportedException NotSupported(string error)
	{
		return null;
	}

	internal static bool IsCatchableExceptionType(Exception e)
	{
		return false;
	}

	internal static bool IsCatchableOrSecurityExceptionType(Exception e)
	{
		return false;
	}

	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value)
	{
		return null;
	}

	internal static Exception InvalidSeekOrigin(string parameterName)
	{
		return null;
	}

	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value)
	{
		return null;
	}

	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value)
	{
		return null;
	}

	internal static ArgumentOutOfRangeException InvalidRule(Rule value)
	{
		return null;
	}

	internal static Exception WrongType(Type got, Type expected)
	{
		return null;
	}
}
