using System.Net.Http.Headers;

namespace System.Net.Http;

/// <summary>Represents a HTTP response message including the status code and data.</summary>
public class HttpResponseMessage : IDisposable
{
	private HttpResponseHeaders headers;

	private string reasonPhrase;

	private HttpStatusCode statusCode;

	private Version version;

	private bool disposed;

	/// <summary>Gets or sets the content of a HTTP response message.</summary>
	/// <returns>The content of the HTTP response message.</returns>
	public HttpContent Content { get; set; }

	/// <summary>Gets the collection of HTTP response headers.</summary>
	/// <returns>The collection of HTTP response headers.</returns>
	public HttpResponseHeaders Headers => null;

	/// <summary>Gets a value that indicates if the HTTP response was successful.</summary>
	/// <returns>
	///   <see langword="true" /> if <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" /> was in the range 200-299; otherwise, <see langword="false" />.</returns>
	public bool IsSuccessStatusCode => false;

	/// <summary>Gets or sets the reason phrase which typically is sent by servers together with the status code.</summary>
	/// <returns>The reason phrase sent by the server.</returns>
	public string ReasonPhrase
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the request message which led to this response message.</summary>
	/// <returns>The request message which led to this response message.</returns>
	public HttpRequestMessage RequestMessage { get; set; }

	/// <summary>Gets or sets the status code of the HTTP response.</summary>
	/// <returns>The status code of the HTTP response.</returns>
	public HttpStatusCode StatusCode
	{
		get
		{
			return default(HttpStatusCode);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the HTTP message version.</summary>
	/// <returns>The HTTP message version. The default is 1.1.</returns>
	public Version Version => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpResponseMessage" /> class with a specific <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" />.</summary>
	/// <param name="statusCode">The status code of the HTTP response.</param>
	public HttpResponseMessage(HttpStatusCode statusCode)
	{
	}

	/// <summary>Releases the unmanaged resources and disposes of unmanaged resources used by the <see cref="T:System.Net.Http.HttpResponseMessage" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Http.HttpResponseMessage" /> and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Returns a string that represents the current object.</summary>
	/// <returns>A string representation of the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
