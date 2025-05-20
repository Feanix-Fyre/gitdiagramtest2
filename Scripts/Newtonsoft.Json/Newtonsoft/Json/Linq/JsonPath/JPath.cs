using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class JPath
{
	private static readonly char[] FloatCharacters;

	private readonly string _expression;

	private int _currentIndex;

	public List<PathFilter> Filters { get; }

	public JPath(string expression)
	{
	}

	private void ParseMain()
	{
	}

	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query)
	{
		return false;
	}

	private static PathFilter CreatePathFilter(string? member, bool scan)
	{
		return null;
	}

	private PathFilter ParseIndexer(char indexerOpenChar, bool scan)
	{
		return null;
	}

	private PathFilter ParseArrayIndexer(char indexerCloseChar)
	{
		return null;
	}

	private void EatWhitespace()
	{
	}

	private PathFilter ParseQuery(char indexerCloseChar, bool scan)
	{
		return null;
	}

	private bool TryParseExpression(out List<PathFilter>? expressionPath)
	{
		expressionPath = null;
		return false;
	}

	private JsonException CreateUnexpectedCharacterException()
	{
		return null;
	}

	private object ParseSide()
	{
		return null;
	}

	private QueryExpression ParseExpression()
	{
		return null;
	}

	private bool TryParseValue(out object? value)
	{
		value = null;
		return false;
	}

	private string ReadQuotedString()
	{
		return null;
	}

	private string ReadRegexString()
	{
		return null;
	}

	private bool Match(string s)
	{
		return false;
	}

	private QueryOperator ParseOperator()
	{
		return default(QueryOperator);
	}

	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan)
	{
		return null;
	}

	private void EnsureLength(string message)
	{
	}

	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings? settings)
	{
		return null;
	}

	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings? settings)
	{
		return null;
	}
}
