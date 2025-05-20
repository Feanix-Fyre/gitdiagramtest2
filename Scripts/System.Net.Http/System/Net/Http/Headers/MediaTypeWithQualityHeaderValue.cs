using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents a media type with an additional quality factor used in a Content-Type header.</summary>
public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" /> class.</summary>
	/// <param name="mediaType">A <see cref="T:System.Net.Http.Headers.MediaTypeWithQualityHeaderValue" /> represented as string to initialize the new instance.</param>
	public MediaTypeWithQualityHeaderValue(string mediaType)
		: base((string)null)
	{
	}

	private MediaTypeWithQualityHeaderValue()
		: base((string)null)
	{
	}

	private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out Token t)
	{
		parsedValue = null;
		t = default(Token);
		return false;
	}

	internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result)
	{
		result = null;
		return false;
	}
}
