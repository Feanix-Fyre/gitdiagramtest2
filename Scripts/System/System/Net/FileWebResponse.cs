using System.IO;
using System.Runtime.Serialization;

namespace System.Net;

/// <summary>Provides a file system implementation of the <see cref="T:System.Net.WebResponse" /> class.</summary>
[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	private bool m_closed;

	private long m_contentLength;

	private FileAccess m_fileAccess;

	private WebHeaderCollection m_headers;

	private Stream m_stream;

	private Uri m_uri;

	/// <summary>Gets a collection of header name/value pairs associated with the response.</summary>
	/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the header name/value pairs associated with the response.</returns>
	public override WebHeaderCollection Headers => null;

	/// <summary>Gets the URI of the file system resource that provided the response.</summary>
	/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the file system resource that provided the response.</returns>
	public override Uri ResponseUri => null;

	internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.FileWebResponse" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance that contains the information required to serialize the new <see cref="T:System.Net.FileWebResponse" /> instance.</param>
	/// <param name="streamingContext">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class that contains the source of the serialized stream associated with the new <see cref="T:System.Net.FileWebResponse" /> instance.</param>
	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance with the data needed to serialize the <see cref="T:System.Net.FileWebResponse" />.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> , which will hold the serialized data for the <see cref="T:System.Net.FileWebResponse" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> containing the destination of the serialized stream associated with the new <see cref="T:System.Net.FileWebResponse" />.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private void CheckDisposed()
	{
	}

	/// <summary>Closes the response stream.</summary>
	public override void Close()
	{
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
	}

	/// <summary>Returns the data stream from the file system resource.</summary>
	/// <returns>A <see cref="T:System.IO.Stream" /> for reading data from the file system resource.</returns>
	public override Stream GetResponseStream()
	{
		return null;
	}
}
