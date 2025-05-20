using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http;

/// <summary>Provides HTTP content based on a byte array.</summary>
public class ByteArrayContent : HttpContent
{
	private readonly byte[] content;

	private readonly int offset;

	private readonly int count;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.ByteArrayContent" /> class.</summary>
	/// <param name="content">The content used to initialize the <see cref="T:System.Net.Http.ByteArrayContent" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> parameter is <see langword="null" />.</exception>
	public ByteArrayContent(byte[] content)
	{
	}

	/// <summary>Serialize and write the byte array provided in the constructor to an HTTP content stream as an asynchronous operation.</summary>
	/// <param name="stream">The target stream.</param>
	/// <param name="context">Information about the transport, like channel binding token. This parameter may be <see langword="null" />.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
	{
		return null;
	}

	/// <summary>Determines whether a byte array has a valid length in bytes.</summary>
	/// <param name="length">The length in bytes of the byte array.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="length" /> is a valid length; otherwise, <see langword="false" />.</returns>
	protected internal override bool TryComputeLength(out long length)
	{
		length = default(long);
		return false;
	}
}
