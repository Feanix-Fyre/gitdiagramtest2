using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents an Accept-Encoding header value.with optional quality factor.</summary>
public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
{
	private TransferCodingWithQualityHeaderValue()
		: base(null)
	{
	}

	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result)
	{
		result = null;
		return false;
	}

	private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out Token t)
	{
		parsedValue = null;
		t = default(Token);
		return false;
	}
}
