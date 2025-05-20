namespace System.Net.Http.Headers;

/// <summary>Represents the collection of Request Headers as defined in RFC 2616.</summary>
public sealed class HttpRequestHeaders : HttpHeaders
{
	private bool? expectContinue;

	/// <summary>Gets the value of the <see langword="Accept" /> header for an HTTP request.</summary>
	/// <returns>The value of the <see langword="Accept" /> header for an HTTP request.</returns>
	public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept => null;

	/// <summary>Gets or sets the value of the <see langword="Authorization" /> header for an HTTP request.</summary>
	/// <returns>The value of the <see langword="Authorization" /> header for an HTTP request.</returns>
	public AuthenticationHeaderValue Authorization
	{
		set
		{
		}
	}

	/// <summary>Gets the value of the <see langword="Connection" /> header for an HTTP request.</summary>
	/// <returns>The value of the <see langword="Connection" /> header for an HTTP request.</returns>
	public HttpHeaderValueCollection<string> Connection => null;

	/// <summary>Gets or sets a value that indicates if the <see langword="Connection" /> header for an HTTP request contains Close.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see langword="Connection" /> header contains Close, otherwise <see langword="false" />.</returns>
	public bool? ConnectionClose => null;

	/// <summary>Gets or sets a value that indicates if the <see langword="Expect" /> header for an HTTP request contains Continue.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see langword="Expect" /> header contains Continue, otherwise <see langword="false" />.</returns>
	public bool? ExpectContinue => null;

	/// <summary>Gets or sets the value of the <see langword="Host" /> header for an HTTP request.</summary>
	/// <returns>The value of the <see langword="Host" /> header for an HTTP request.</returns>
	public string Host => null;

	/// <summary>Gets the value of the <see langword="Transfer-Encoding" /> header for an HTTP request.</summary>
	/// <returns>The value of the <see langword="Transfer-Encoding" /> header for an HTTP request.</returns>
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding => null;

	/// <summary>Gets or sets a value that indicates if the <see langword="Transfer-Encoding" /> header for an HTTP request contains chunked.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see langword="Transfer-Encoding" /> header contains chunked, otherwise <see langword="false" />.</returns>
	public bool? TransferEncodingChunked => null;

	internal HttpRequestHeaders()
	{
	}

	internal void AddHeaders(HttpRequestHeaders headers)
	{
	}
}
