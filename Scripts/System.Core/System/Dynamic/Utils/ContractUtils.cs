using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Dynamic.Utils;

internal static class ContractUtils
{
	[ExcludeFromCodeCoverage]
	public static Exception Unreachable => null;

	public static void Requires(bool precondition, string paramName)
	{
	}

	public static void RequiresNotNull(object value, string paramName)
	{
	}

	public static void RequiresNotNull(object value, string paramName, int index)
	{
	}

	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName)
	{
	}

	private static string GetParamName(string paramName, int index)
	{
		return null;
	}

	public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName)
	{
	}
}
