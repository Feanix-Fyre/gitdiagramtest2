using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression;

/// <summary>Provides methods and properties for compressing and decompressing streams by using the Deflate algorithm.</summary>
public class DeflateStream : Stream
{
	private delegate int ReadMethod(byte[] array, int offset, int count);

	private delegate void WriteMethod(byte[] array, int offset, int count);

	private Stream base_stream;

	private CompressionMode mode;

	private bool leaveOpen;

	private bool disposed;

	private DeflateStreamNative native;

	/// <summary>Gets a value indicating whether the stream supports reading while decompressing a file.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Decompress" />, and the underlying stream is opened and supports reading; otherwise, <see langword="false" />.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a value indicating whether the stream supports seeking.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	public override bool CanSeek => false;

	/// <summary>Gets a value indicating whether the stream supports writing.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Compress" />, and the underlying stream supports writing and is not closed; otherwise, <see langword="false" />.</returns>
	public override bool CanWrite => false;

	/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>A long value.</returns>
	/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
	public override long Length => 0L;

	/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>A long value.</returns>
	/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.DeflateStream" /> class by using the specified stream and compression mode.</summary>
	/// <param name="stream">The stream to compress or decompress.</param>
	/// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="mode" /> is not a valid <see cref="T:System.IO.Compression.CompressionMode" /> value.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Compress" /> and <see cref="P:System.IO.Stream.CanWrite" /> is <see langword="false" />.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Decompress" /> and <see cref="P:System.IO.Stream.CanRead" /> is <see langword="false" />.</exception>
	public DeflateStream(Stream stream, CompressionMode mode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.DeflateStream" /> class by using the specified stream and compression mode, and optionally leaves the stream open.</summary>
	/// <param name="stream">The stream to compress or decompress.</param>
	/// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to leave the stream open after disposing the <see cref="T:System.IO.Compression.DeflateStream" /> object; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="mode" /> is not a valid <see cref="T:System.IO.Compression.CompressionMode" /> value.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Compress" /> and <see cref="P:System.IO.Stream.CanWrite" /> is <see langword="false" />.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Decompress" /> and <see cref="P:System.IO.Stream.CanRead" /> is <see langword="false" />.</exception>
	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
	{
	}

	internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits)
	{
	}

	internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.DeflateStream" /> class by using the specified stream and compression level, and optionally leaves the stream open.</summary>
	/// <param name="stream">The stream to compress.</param>
	/// <param name="compressionLevel">One of the enumeration values that indicates whether to emphasize speed or compression efficiency when compressing the stream.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to leave the stream object open after disposing the <see cref="T:System.IO.Compression.DeflateStream" /> object; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The stream does not support write operations such as compression. (The <see cref="P:System.IO.Stream.CanWrite" /> property on the stream object is <see langword="false" />.)</exception>
	public DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
	{
	}

	internal DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, bool gzip)
	{
	}

	~DeflateStream()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Compression.DeflateStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private int ReadInternal(byte[] array, int offset, int count)
	{
		return 0;
	}

	internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
	{
		return default(ValueTask<int>);
	}

	internal int ReadCore(Span<byte> destination)
	{
		return 0;
	}

	/// <summary>Reads a number of decompressed bytes into the specified byte array.</summary>
	/// <param name="array">The array to store decompressed bytes.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
	/// <param name="count">The maximum number of decompressed bytes to read.</param>
	/// <returns>The number of bytes that were read into the byte array.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.IO.Compression.CompressionMode" /> value was <see langword="Compress" /> when the object was created.  
	/// -or-
	///  The underlying stream does not support reading.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="array" /> length minus the index starting point is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.IO.InvalidDataException">The data is in an invalid format.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public override int Read(byte[] array, int offset, int count)
	{
		return 0;
	}

	private void WriteInternal(byte[] array, int offset, int count)
	{
	}

	internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
	{
		return default(ValueTask);
	}

	internal void WriteCore(ReadOnlySpan<byte> source)
	{
	}

	/// <summary>Writes compressed bytes to the underlying stream from the specified byte array.</summary>
	/// <param name="array">The buffer that contains the data to compress.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> from which the bytes will be read.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	public override void Write(byte[] array, int offset, int count)
	{
	}

	/// <summary>The current implementation of this method has no functionality.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public override void Flush()
	{
	}

	/// <summary>Begins an asynchronous read operation. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="array">The byte array to read the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> at which to begin reading data from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <param name="asyncCallback">An optional asynchronous callback, to be called when the read operation is complete.</param>
	/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
	/// <returns>An  object that represents the asynchronous read operation, which could still be pending.</returns>
	/// <exception cref="T:System.IO.IOException">The method tried to read asynchronously past the end of the stream, or a disk error occurred.</exception>
	/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.DeflateStream" /> implementation does not support the read operation.</exception>
	/// <exception cref="T:System.InvalidOperationException">This call cannot be completed.</exception>
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		return null;
	}

	/// <summary>Begins an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="array">The buffer to write data from.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> to begin writing from.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <param name="asyncCallback">An optional asynchronous callback, to be called when the write operation is complete.</param>
	/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
	/// <returns>An object that represents the asynchronous write operation, which could still be pending.</returns>
	/// <exception cref="T:System.IO.IOException">The method tried to write asynchronously past the end of the stream, or a disk error occurred.</exception>
	/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.DeflateStream" /> implementation does not support the write operation.</exception>
	/// <exception cref="T:System.InvalidOperationException">The write operation cannot be performed because the stream is closed.</exception>
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		return null;
	}

	/// <summary>Waits for the pending asynchronous read to complete. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="asyncResult">The reference to the pending asynchronous request to finish.</param>
	/// <returns>The number of bytes read from the stream, between 0 (zero) and the number of bytes you requested. <see cref="T:System.IO.Compression.DeflateStream" /> returns 0 only at the end of the stream; otherwise, it blocks until at least one byte is available.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.DeflateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
	/// <exception cref="T:System.SystemException">An exception was thrown during a call to <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The end call is invalid because asynchronous read operations for this stream are not yet complete.
	/// -or-
	/// The stream is <see langword="null" />.</exception>
	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	/// <summary>Ends an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="asyncResult">A reference to the outstanding asynchronous I/O request.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.DeflateStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
	/// <exception cref="T:System.Exception">An exception was thrown during a call to <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is <see langword="null" />.
	/// -or-
	/// The end write call is invalid.</exception>
	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	/// <summary>This operation is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="offset">The location in the stream.</param>
	/// <param name="origin">One of the <see cref="T:System.IO.SeekOrigin" /> values.</param>
	/// <returns>A long value.</returns>
	/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	/// <summary>This operation is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="value">The length of the stream.</param>
	/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
	public override void SetLength(long value)
	{
	}
}
