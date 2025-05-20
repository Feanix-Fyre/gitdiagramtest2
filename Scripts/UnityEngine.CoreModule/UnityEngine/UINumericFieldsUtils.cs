namespace UnityEngine;

internal static class UINumericFieldsUtils
{
	public static readonly string k_AllowedCharactersForFloat;

	public static readonly string k_AllowedCharactersForInt;

	public static readonly string k_DoubleFieldFormatString;

	public static readonly string k_FloatFieldFormatString;

	public static readonly string k_IntFieldFormatString;

	public static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr)
	{
		value = default(double);
		expr = null;
		return false;
	}

	public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value)
	{
		value = default(double);
		return false;
	}

	public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value)
	{
		value = default(float);
		return false;
	}

	public static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr)
	{
		value = default(long);
		expr = null;
		return false;
	}

	public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value)
	{
		value = default(long);
		return false;
	}

	public static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr)
	{
		value = default(ulong);
		expr = null;
		return false;
	}

	public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value)
	{
		value = default(ulong);
		return false;
	}

	public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value)
	{
		value = default(int);
		return false;
	}

	public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value)
	{
		value = default(uint);
		return false;
	}
}
