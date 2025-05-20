using System.Runtime.Serialization;

namespace System.Net;

/// <summary>The exception that is thrown when an error occurs while accessing the network through a pluggable protocol.</summary>
[Serializable]
public class WebException : InvalidOperationException, ISerializable
{
	private WebExceptionStatus m_Status;

	private WebResponse m_Response;

	[NonSerialized]
	private WebExceptionInternalStatus m_InternalStatus;

	/// <summary>Gets the status of the response.</summary>
	/// <returns>One of the <see cref="T:System.Net.WebExceptionStatus" /> values.</returns>
	public WebExceptionStatus Status => default(WebExceptionStatus);

	/// <summary>Gets the response that the remote host returned.</summary>
	/// <returns>If a response is available from the Internet resource, a <see cref="T:System.Net.WebResponse" /> instance that contains the error response from an Internet resource; otherwise, <see langword="null" />.</returns>
	public WebResponse Response => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class.</summary>
	public WebException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message.</summary>
	/// <param name="message">The text of the error message.</param>
	public WebException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message and nested exception.</summary>
	/// <param name="message">The text of the error message.</param>
	/// <param name="innerException">A nested exception.</param>
	public WebException(string message, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message and status.</summary>
	/// <param name="message">The text of the error message.</param>
	/// <param name="status">One of the <see cref="T:System.Net.WebExceptionStatus" /> values.</param>
	public WebException(string message, WebExceptionStatus status)
	{
	}

	internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class with the specified error message, nested exception, status, and response.</summary>
	/// <param name="message">The text of the error message.</param>
	/// <param name="innerException">A nested exception.</param>
	/// <param name="status">One of the <see cref="T:System.Net.WebExceptionStatus" /> values.</param>
	/// <param name="response">A <see cref="T:System.Net.WebResponse" /> instance that contains the response from the remote host.</param>
	public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
	{
	}

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
	{
	}

	internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
	{
	}

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebException" /> class from the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information required to serialize the new <see cref="T:System.Net.WebException" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.WebException" />.</param>
	protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Serializes this instance into the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</summary>
	/// <param name="serializationInfo">The object into which this <see cref="T:System.Net.WebException" /> will be serialized.</param>
	/// <param name="streamingContext">The destination of the serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.WebException" />.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used.</param>
	/// <param name="streamingContext">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> to be used.</param>
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
