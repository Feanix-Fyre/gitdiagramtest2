using System.Net.Http.Headers;

namespace System.Net.Http;

/// <summary>Represents a HTTP request message.</summary>
public class HttpRequestMessage : IDisposable
{
	private HttpRequestHeaders headers;

	private HttpMethod method;

	private Version version;

	private Uri uri;

	private bool is_used;

	private bool disposed;

	/// <summary>Gets or sets the contents of the HTTP message.</summary>
	/// <returns>The content of a message</returns>
	public HttpContent Content { get; set; }

	/// <summary>Gets the collection of HTTP request headers.</summary>
	/// <returns>The collection of HTTP request headers.</returns>
	public HttpRequestHeaders Headers => null;

	/// <summary>Gets or sets the HTTP method used by the HTTP request message.</summary>
	/// <returns>The HTTP method used by the request message. The default is the GET method.</returns>
	public HttpMethod Method
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Uri" /> used for the HTTP request.</summary>
	/// <returns>The <see cref="T:System.Uri" /> used for the HTTP request.</returns>
	public Uri RequestUri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the HTTP message version.</summary>
	/// <returns>The HTTP message version. The default is 1.1.</returns>
	public Version Version => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpRequestMessage" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
	/// <param name="method">The HTTP method.</param>
	/// <param name="requestUri">A string that represents the request  <see cref="T:System.Uri" />.</param>
	public HttpRequestMessage(HttpMethod method, string requestUri)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpRequestMessage" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
	/// <param name="method">The HTTP method.</param>
	/// <param name="requestUri">The <see cref="T:System.Uri" /> to request.</param>
	public HttpRequestMessage(HttpMethod method, Uri requestUri)
	{
	}

	private static bool IsAllowedAbsoluteUri(Uri uri)
	{
		return false;
	}

	/// <summary>Releases the unmanaged resources and disposes of the managed resources used by the <see cref="T:System.Net.Http.HttpRequestMessage" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Http.HttpRequestMessage" /> and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	internal bool SetIsUsed()
	{
		return false;
	}

	/// <summary>Returns a string that represents the current object.</summary>
	/// <returns>A string representation of the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
