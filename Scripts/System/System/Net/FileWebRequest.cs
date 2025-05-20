using System.IO;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Net;

/// <summary>Provides a file system implementation of the <see cref="T:System.Net.WebRequest" /> class.</summary>
[Serializable]
public class FileWebRequest : WebRequest, ISerializable
{
	private static WaitCallback s_GetRequestStreamCallback;

	private static WaitCallback s_GetResponseCallback;

	private string m_connectionGroupName;

	private long m_contentLength;

	private ICredentials m_credentials;

	private FileAccess m_fileAccess;

	private WebHeaderCollection m_headers;

	private string m_method;

	private bool m_preauthenticate;

	private IWebProxy m_proxy;

	private ManualResetEvent m_readerEvent;

	private bool m_readPending;

	private WebResponse m_response;

	private Stream m_stream;

	private bool m_syncHint;

	private int m_timeout;

	private Uri m_uri;

	private bool m_writePending;

	private bool m_writing;

	private LazyAsyncResult m_WriteAResult;

	private LazyAsyncResult m_ReadAResult;

	private int m_Aborted;

	internal bool Aborted => false;

	/// <summary>Gets or sets the name of the connection group for the request. This property is reserved for future use.</summary>
	/// <returns>The name of the connection group for the request.</returns>
	public override string ConnectionGroupName
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the content length of the data being sent.</summary>
	/// <returns>The number of bytes of request data being sent.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <see cref="P:System.Net.FileWebRequest.ContentLength" /> is less than 0.</exception>
	public override long ContentLength
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the credentials that are associated with this request. This property is reserved for future use.</summary>
	/// <returns>An <see cref="T:System.Net.ICredentials" /> that contains the authentication credentials that are associated with this request. The default is <see langword="null" />.</returns>
	public override ICredentials Credentials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets a collection of the name/value pairs that are associated with the request. This property is reserved for future use.</summary>
	/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains header name/value pairs associated with this request.</returns>
	public override WebHeaderCollection Headers => null;

	/// <summary>Gets or sets the protocol method used for the request. This property is reserved for future use.</summary>
	/// <returns>The protocol method to use in this request.</returns>
	/// <exception cref="T:System.ArgumentException">The method is invalid.  
	/// -or-
	///  The method is not supported.  
	/// -or-
	///  Multiple methods were specified.</exception>
	public override string Method
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether to preauthenticate a request. This property is reserved for future use.</summary>
	/// <returns>
	///   <see langword="true" /> to preauthenticate; otherwise, <see langword="false" />.</returns>
	public override bool PreAuthenticate
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the network proxy to use for this request. This property is reserved for future use.</summary>
	/// <returns>An <see cref="T:System.Net.IWebProxy" /> that indicates the network proxy to use for this request.</returns>
	public override IWebProxy Proxy
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the length of time until the request times out.</summary>
	/// <returns>The time, in milliseconds, until the request times out, or the value <see cref="F:System.Threading.Timeout.Infinite" /> to indicate that the request does not time out.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	public override int Timeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the Uniform Resource Identifier (URI) of the request.</summary>
	/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the request.</returns>
	public override Uri RequestUri => null;

	/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
	/// <exception cref="T:System.NotSupportedException">Default credentials are not supported for file Uniform Resource Identifiers (URIs).</exception>
	public override bool UseDefaultCredentials => false;

	internal FileWebRequest(Uri uri)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.FileWebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information that is required to serialize the new <see cref="T:System.Net.FileWebRequest" /> object.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.FileWebRequest" /> object.</param>
	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the required data to serialize the <see cref="T:System.Net.FileWebRequest" />.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized data for the <see cref="T:System.Net.FileWebRequest" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream that is associated with the new <see cref="T:System.Net.FileWebRequest" />.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Begins an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object that contains state information for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
	/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.FileWebRequest.Method" /> property is <c>GET</c> and the application writes to the stream.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is being used by a previous call to <see cref="M:System.Net.FileWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.ApplicationException">No write stream is available.</exception>
	/// <exception cref="T:System.Net.WebException">The <see cref="T:System.Net.FileWebRequest" /> was aborted.</exception>
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Begins an asynchronous request for a file system resource.</summary>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">An object that contains state information for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
	/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.FileWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.Net.WebException">The <see cref="T:System.Net.FileWebRequest" /> was aborted.</exception>
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
	{
		return null;
	}

	private bool CanGetRequestStream()
	{
		return false;
	}

	/// <summary>Ends an asynchronous request for a <see cref="T:System.IO.Stream" /> instance that the application uses to write data.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references the pending request for a stream.</param>
	/// <returns>A <see cref="T:System.IO.Stream" /> object that the application uses to write data.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	public override Stream EndGetRequestStream(IAsyncResult asyncResult)
	{
		return null;
	}

	/// <summary>Ends an asynchronous request for a file system resource.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that references the pending request for a response.</param>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the file system resource.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	public override WebResponse EndGetResponse(IAsyncResult asyncResult)
	{
		return null;
	}

	/// <summary>Returns a response to a file system request.</summary>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the file system resource.</returns>
	/// <exception cref="T:System.Net.WebException">The request timed out.</exception>
	public override WebResponse GetResponse()
	{
		return null;
	}

	private static void GetRequestStreamCallback(object state)
	{
	}

	private static void GetResponseCallback(object state)
	{
	}

	internal void UnblockReader()
	{
	}

	/// <summary>Cancels a request to an Internet resource.</summary>
	public override void Abort()
	{
	}
}
