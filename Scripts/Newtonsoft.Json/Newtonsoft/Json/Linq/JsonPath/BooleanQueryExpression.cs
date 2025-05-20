using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class BooleanQueryExpression : QueryExpression
{
	public readonly object Left;

	public readonly object? Right;

	public BooleanQueryExpression(QueryOperator @operator, object left, object? right)
		: base(default(QueryOperator))
	{
	}

	private IEnumerable<JToken> GetResult(JToken root, JToken t, object? o)
	{
		return null;
	}

	public override bool IsMatch(JToken root, JToken t, JsonSelectSettings? settings)
	{
		return false;
	}

	private bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings? settings)
	{
		return false;
	}

	private static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings? settings)
	{
		return false;
	}

	internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue)
	{
		return false;
	}

	internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue)
	{
		return false;
	}
}
