using System.Collections.Generic;

namespace System.Net.Http.Headers;

internal static class CollectionParser
{
	public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) where T : class
	{
		result = null;
		return false;
	}

	public static bool TryParse(string input, int minimalCount, out List<string> result)
	{
		result = null;
		return false;
	}

	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t)
	{
		parsedValue = null;
		t = default(Token);
		return false;
	}
}
