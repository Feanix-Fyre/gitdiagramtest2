namespace System.Net.Http.Headers;

/// <summary>Represents the collection of Content Headers as defined in RFC 2616.</summary>
public sealed class HttpContentHeaders : HttpHeaders
{
	private readonly HttpContent content;

	/// <summary>Gets or sets the value of the <see langword="Content-Length" /> content header on an HTTP response.</summary>
	/// <returns>The value of the <see langword="Content-Length" /> content header on an HTTP response.</returns>
	public long? ContentLength => null;

	/// <summary>Gets or sets the value of the <see langword="Content-Type" /> content header on an HTTP response.</summary>
	/// <returns>The value of the <see langword="Content-Type" /> content header on an HTTP response.</returns>
	public MediaTypeHeaderValue ContentType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal HttpContentHeaders(HttpContent content)
	{
	}
}
