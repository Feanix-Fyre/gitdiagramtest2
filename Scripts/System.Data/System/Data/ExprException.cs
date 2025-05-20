namespace System.Data;

internal sealed class ExprException
{
	private static OverflowException _Overflow(string error)
	{
		return null;
	}

	private static InvalidExpressionException _Expr(string error)
	{
		return null;
	}

	private static SyntaxErrorException _Syntax(string error)
	{
		return null;
	}

	private static EvaluateException _Eval(string error)
	{
		return null;
	}

	private static EvaluateException _Eval(string error, Exception innerException)
	{
		return null;
	}

	public static Exception InvokeArgument()
	{
		return null;
	}

	public static Exception NYI(string moreinfo)
	{
		return null;
	}

	public static Exception MissingOperand(OperatorInfo before)
	{
		return null;
	}

	public static Exception MissingOperator(string token)
	{
		return null;
	}

	public static Exception TypeMismatch(string expr)
	{
		return null;
	}

	public static Exception FunctionArgumentOutOfRange(string arg, string func)
	{
		return null;
	}

	public static Exception ExpressionTooComplex()
	{
		return null;
	}

	public static Exception UnboundName(string name)
	{
		return null;
	}

	public static Exception InvalidString(string str)
	{
		return null;
	}

	public static Exception UndefinedFunction(string name)
	{
		return null;
	}

	public static Exception SyntaxError()
	{
		return null;
	}

	public static Exception FunctionArgumentCount(string name)
	{
		return null;
	}

	public static Exception MissingRightParen()
	{
		return null;
	}

	public static Exception UnknownToken(string token, int position)
	{
		return null;
	}

	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position)
	{
		return null;
	}

	public static Exception DatatypeConvertion(Type type1, Type type2)
	{
		return null;
	}

	public static Exception DatavalueConvertion(object value, Type type, Exception innerException)
	{
		return null;
	}

	public static Exception InvalidName(string name)
	{
		return null;
	}

	public static Exception InvalidDate(string date)
	{
		return null;
	}

	public static Exception NonConstantArgument()
	{
		return null;
	}

	public static Exception InvalidPattern(string pat)
	{
		return null;
	}

	public static Exception InWithoutParentheses()
	{
		return null;
	}

	public static Exception InWithoutList()
	{
		return null;
	}

	public static Exception InvalidIsSyntax()
	{
		return null;
	}

	public static Exception Overflow(Type type)
	{
		return null;
	}

	public static Exception ArgumentType(string function, int arg, Type type)
	{
		return null;
	}

	public static Exception ArgumentTypeInteger(string function, int arg)
	{
		return null;
	}

	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2)
	{
		return null;
	}

	public static Exception AmbiguousBinop(int op, Type type1, Type type2)
	{
		return null;
	}

	public static Exception UnsupportedOperator(int op)
	{
		return null;
	}

	public static Exception InvalidNameBracketing(string name)
	{
		return null;
	}

	public static Exception MissingOperandBefore(string op)
	{
		return null;
	}

	public static Exception TooManyRightParentheses()
	{
		return null;
	}

	public static Exception UnresolvedRelation(string name, string expr)
	{
		return null;
	}

	internal static EvaluateException BindFailure(string relationName)
	{
		return null;
	}

	public static Exception AggregateArgument()
	{
		return null;
	}

	public static Exception AggregateUnbound(string expr)
	{
		return null;
	}

	public static Exception EvalNoContext()
	{
		return null;
	}

	public static Exception ExpressionUnbound(string expr)
	{
		return null;
	}

	public static Exception ComputeNotAggregate(string expr)
	{
		return null;
	}

	public static Exception FilterConvertion(string expr)
	{
		return null;
	}

	public static Exception LookupArgument()
	{
		return null;
	}

	public static Exception InvalidType(string typeName)
	{
		return null;
	}

	public static Exception InvalidHoursArgument()
	{
		return null;
	}

	public static Exception InvalidMinutesArgument()
	{
		return null;
	}

	public static Exception InvalidTimeZoneRange()
	{
		return null;
	}

	public static Exception MismatchKindandTimeSpan()
	{
		return null;
	}

	public static Exception UnsupportedDataType(Type type)
	{
		return null;
	}
}
