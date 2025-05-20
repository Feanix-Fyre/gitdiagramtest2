using System.IO;
using System.Runtime.Serialization;

namespace System.Net;

/// <summary>Provides a response from a Uniform Resource Identifier (URI). This is an <see langword="abstract" /> class.</summary>
[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{
	private bool m_IsFromCache;

	/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether this response was obtained from the cache.</summary>
	/// <returns>
	///   <see langword="true" /> if the response was taken from the cache; otherwise, <see langword="false" />.</returns>
	public virtual bool IsFromCache => false;

	/// <summary>When overridden in a derived class, gets the URI of the Internet resource that actually responded to the request.</summary>
	/// <returns>An instance of the <see cref="T:System.Uri" /> class that contains the URI of the Internet resource that actually responded to the request.</returns>
	/// <exception cref="T:System.NotSupportedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual Uri ResponseUri => null;

	/// <summary>When overridden in a derived class, gets a collection of header name-value pairs associated with this request.</summary>
	/// <returns>An instance of the <see cref="T:System.Net.WebHeaderCollection" /> class that contains header values associated with this response.</returns>
	/// <exception cref="T:System.NotSupportedException">Any attempt is made to get or set the property, when the property is not overridden in a descendant class.</exception>
	public virtual WebHeaderCollection Headers => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebResponse" /> class.</summary>
	protected WebResponse()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebResponse" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
	/// <param name="serializationInfo">An instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class that contains the information required to serialize the new <see cref="T:System.Net.WebRequest" /> instance.</param>
	/// <param name="streamingContext">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class that indicates the source of the serialized stream that is associated with the new <see cref="T:System.Net.WebRequest" /> instance.</param>
	/// <exception cref="T:System.NotSupportedException">Any attempt is made to access the constructor, when the constructor is not overridden in a descendant class.</exception>
	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data that is needed to serialize <see cref="T:System.Net.WebResponse" />.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that will hold the serialized data for the <see cref="T:System.Net.WebResponse" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination of the serialized stream that is associated with the new <see cref="T:System.Net.WebResponse" />.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data that is needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>When overridden by a descendant class, closes the response stream.</summary>
	/// <exception cref="T:System.NotSupportedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual void Close()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.WebResponse" /> object.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.WebResponse" /> object, and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>When overridden in a descendant class, returns the data stream from the Internet resource.</summary>
	/// <returns>An instance of the <see cref="T:System.IO.Stream" /> class for reading data from the Internet resource.</returns>
	/// <exception cref="T:System.NotSupportedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
	public virtual Stream GetResponseStream()
	{
		return null;
	}
}
