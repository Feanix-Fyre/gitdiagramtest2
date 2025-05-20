using System.IO;
using System.Runtime.Serialization;

namespace System.Net;

/// <summary>Provides an HTTP-specific implementation of the <see cref="T:System.Net.WebResponse" /> class.</summary>
[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable
{
	private Uri uri;

	private WebHeaderCollection webHeaders;

	private CookieCollection cookieCollection;

	private string method;

	private Version version;

	private HttpStatusCode statusCode;

	private string statusDescription;

	private long contentLength;

	private string contentType;

	private CookieContainer cookie_container;

	private bool disposed;

	private Stream stream;

	/// <summary>Gets the headers that are associated with this response from the server.</summary>
	/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the header information returned with the response.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed.</exception>
	public override WebHeaderCollection Headers => null;

	/// <summary>Gets the URI of the Internet resource that responded to the request.</summary>
	/// <returns>The URI of the Internet resource that responded to the request.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed.</exception>
	public override Uri ResponseUri => null;

	/// <summary>Gets the status of the response.</summary>
	/// <returns>One of the <see cref="T:System.Net.HttpStatusCode" /> values.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed.</exception>
	public virtual HttpStatusCode StatusCode => default(HttpStatusCode);

	/// <summary>Gets the status description returned with the response.</summary>
	/// <returns>A string that describes the status of the response.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed.</exception>
	public virtual string StatusDescription => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebResponse" /> class.</summary>
	public HttpWebResponse()
	{
	}

	internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
	{
	}

	internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebResponse" /> class from the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.HttpWebRequest" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.HttpWebRequest" />.</param>
	[Obsolete("Serialization is obsoleted for this type", false)]
	protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Gets the stream that is used to read the body of the response from the server.</summary>
	/// <returns>A <see cref="T:System.IO.Stream" /> containing the body of the response.</returns>
	/// <exception cref="T:System.Net.ProtocolViolationException">There is no response stream.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed.</exception>
	public override Stream GetResponseStream()
	{
		return null;
	}

	/// <summary>Serializes this instance into the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</summary>
	/// <param name="serializationInfo">The object into which this <see cref="T:System.Net.HttpWebResponse" /> will be serialized.</param>
	/// <param name="streamingContext">The destination of the serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Closes the response stream.</summary>
	/// <exception cref="T:System.ObjectDisposedException">.NET Core only: This <see cref="T:System.Net.HttpWebResponse" /> object has been disposed.</exception>
	public override void Close()
	{
	}

	private new void Dispose()
	{
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.HttpWebResponse" />, and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private void CheckDisposed()
	{
	}

	private void FillCookies()
	{
	}
}
