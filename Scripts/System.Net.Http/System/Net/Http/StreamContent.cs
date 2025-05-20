using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http;

/// <summary>Provides HTTP content based on a stream.</summary>
public class StreamContent : HttpContent
{
	private readonly Stream content;

	private readonly int bufferSize;

	private readonly CancellationToken cancellationToken;

	private readonly long startPosition;

	private bool contentCopied;

	/// <summary>Creates a new instance of the <see cref="T:System.Net.Http.StreamContent" /> class.</summary>
	/// <param name="content">The content used to initialize the <see cref="T:System.Net.Http.StreamContent" />.</param>
	public StreamContent(Stream content)
	{
	}

	/// <summary>Creates a new instance of the <see cref="T:System.Net.Http.StreamContent" /> class.</summary>
	/// <param name="content">The content used to initialize the <see cref="T:System.Net.Http.StreamContent" />.</param>
	/// <param name="bufferSize">The size, in bytes, of the buffer for the <see cref="T:System.Net.Http.StreamContent" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="bufferSize" /> was less than or equal to zero.</exception>
	public StreamContent(Stream content, int bufferSize)
	{
	}

	internal StreamContent(Stream content, CancellationToken cancellationToken)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Http.StreamContent" /> and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Serialize the HTTP content to a stream as an asynchronous operation.</summary>
	/// <param name="stream">The target stream.</param>
	/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be <see langword="null" />.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
	{
		return null;
	}

	/// <summary>Determines whether the stream content has a valid length in bytes.</summary>
	/// <param name="length">The length in bytes of the stream content.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="length" /> is a valid length; otherwise, <see langword="false" />.</returns>
	protected internal override bool TryComputeLength(out long length)
	{
		length = default(long);
		return false;
	}
}
