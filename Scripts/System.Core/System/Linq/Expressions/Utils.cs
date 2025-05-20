namespace System.Linq.Expressions;

internal static class Utils
{
	public static readonly object BoxedFalse;

	public static readonly object BoxedTrue;

	public static readonly object BoxedIntM1;

	public static readonly object BoxedInt0;

	public static readonly object BoxedInt1;

	public static readonly object BoxedInt2;

	public static readonly object BoxedInt3;

	public static readonly object BoxedDefaultSByte;

	public static readonly object BoxedDefaultChar;

	public static readonly object BoxedDefaultInt16;

	public static readonly object BoxedDefaultInt64;

	public static readonly object BoxedDefaultByte;

	public static readonly object BoxedDefaultUInt16;

	public static readonly object BoxedDefaultUInt32;

	public static readonly object BoxedDefaultUInt64;

	public static readonly object BoxedDefaultSingle;

	public static readonly object BoxedDefaultDouble;

	public static readonly object BoxedDefaultDecimal;

	public static readonly object BoxedDefaultDateTime;

	private static readonly ConstantExpression s_true;

	private static readonly ConstantExpression s_false;

	private static readonly ConstantExpression s_m1;

	private static readonly ConstantExpression s_0;

	private static readonly ConstantExpression s_1;

	private static readonly ConstantExpression s_2;

	private static readonly ConstantExpression s_3;

	public static readonly DefaultExpression Empty;

	public static readonly ConstantExpression Null;

	public static ConstantExpression Constant(bool value)
	{
		return null;
	}

	public static ConstantExpression Constant(int value)
	{
		return null;
	}
}
