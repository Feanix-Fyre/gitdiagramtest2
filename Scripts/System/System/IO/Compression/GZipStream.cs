using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression;

/// <summary>Provides methods and properties used to compress and decompress streams.</summary>
public class GZipStream : Stream
{
	private DeflateStream _deflateStream;

	/// <summary>Gets a value indicating whether the stream supports reading while decompressing a file.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Decompress," /> and the underlying stream supports reading and is not closed; otherwise, <see langword="false" />.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a value indicating whether the stream supports writing.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Compress" />, and the underlying stream supports writing and is not closed; otherwise, <see langword="false" />.</returns>
	public override bool CanWrite => false;

	/// <summary>Gets a value indicating whether the stream supports seeking.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	public override bool CanSeek => false;

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

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.GZipStream" /> class by using the specified stream and compression mode.</summary>
	/// <param name="stream">The stream the compressed or decompressed data is written to.</param>
	/// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="mode" /> is not a valid <see cref="T:System.IO.Compression.CompressionMode" /> enumeration value.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Compress" /> and <see cref="P:System.IO.Stream.CanWrite" /> is <see langword="false" />.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Decompress" /> and <see cref="P:System.IO.Stream.CanRead" /> is <see langword="false" />.</exception>
	public GZipStream(Stream stream, CompressionMode mode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.GZipStream" /> class by using the specified stream and compression mode, and optionally leaves the stream open.</summary>
	/// <param name="stream">The stream the compressed or decompressed data is written to.</param>
	/// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to leave the stream open after disposing the <see cref="T:System.IO.Compression.GZipStream" /> object; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="mode" /> is not a valid <see cref="T:System.IO.Compression.CompressionMode" /> value.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Compress" /> and <see cref="P:System.IO.Stream.CanWrite" /> is <see langword="false" />.  
	/// -or-  
	/// <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Decompress" /> and <see cref="P:System.IO.Stream.CanRead" /> is <see langword="false" />.</exception>
	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
	{
	}

	/// <summary>The current implementation of this method has no functionality.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public override void Flush()
	{
	}

	/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="offset">The location in the stream.</param>
	/// <param name="origin">One of the <see cref="T:System.IO.SeekOrigin" /> values.</param>
	/// <returns>A long value.</returns>
	/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="value">The length of the stream.</param>
	/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
	public override void SetLength(long value)
	{
	}

	public override int ReadByte()
	{
		return 0;
	}

	/// <summary>Begins an asynchronous read operation. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="array">The byte array to read the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> at which to begin reading data from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <param name="asyncCallback">An optional asynchronous callback, to be called when the read operation is complete.</param>
	/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
	/// <returns>An object that represents the asynchronous read operation, which could still be pending.</returns>
	/// <exception cref="T:System.IO.IOException">The method tried to  read asynchronously past the end of the stream, or a disk error occurred.</exception>
	/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.GZipStream" /> implementation does not support the read operation.</exception>
	/// <exception cref="T:System.InvalidOperationException">A read operation cannot be performed because the stream is closed.</exception>
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		return null;
	}

	/// <summary>Waits for the pending asynchronous read to complete. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="asyncResult">The reference to the pending asynchronous request to finish.</param>
	/// <returns>The number of bytes read from the stream, between 0 (zero) and the number of bytes you requested. <see cref="T:System.IO.Compression.GZipStream" /> returns 0 only at the end of the stream; otherwise, it blocks until at least one byte is available.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.GZipStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
	/// <exception cref="T:System.InvalidOperationException">The end operation cannot be performed because the stream is closed.</exception>
	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	/// <summary>Reads a number of decompressed bytes into the specified byte array.</summary>
	/// <param name="array">The array used to store decompressed bytes.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
	/// <param name="count">The maximum number of decompressed bytes to read.</param>
	/// <returns>The number of bytes that were decompressed into the byte array. If the end of the stream has been reached, zero or the number of bytes read is returned.</returns>
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

	public override int Read(Span<byte> buffer)
	{
		return 0;
	}

	/// <summary>Begins an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="array">The buffer containing data to write to the current stream.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> at which to begin writing.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <param name="asyncCallback">An optional asynchronous callback to be called when the write operation is complete.</param>
	/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
	/// <returns>An  object that represents the asynchronous write operation, which could still be pending.</returns>
	/// <exception cref="T:System.InvalidOperationException">The underlying stream is <see langword="null" />.  
	///  -or-  
	///  The underlying stream is closed.</exception>
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		return null;
	}

	/// <summary>Handles the end of an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead.)</summary>
	/// <param name="asyncResult">The object that represents the asynchronous call.</param>
	/// <exception cref="T:System.InvalidOperationException">The underlying stream is <see langword="null" />.  
	///  -or-  
	///  The underlying stream is closed.</exception>
	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	/// <summary>Writes compressed bytes to the underlying stream from the specified byte array.</summary>
	/// <param name="array">The buffer that contains the data to compress.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> from which the bytes will be read.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <exception cref="T:System.ObjectDisposedException">The write operation cannot be performed because the stream is closed.</exception>
	public override void Write(byte[] array, int offset, int count)
	{
	}

	public override void Write(ReadOnlySpan<byte> buffer)
	{
	}

	public override void CopyTo(Stream destination, int bufferSize)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Compression.GZipStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask<int>);
	}

	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask);
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		return null;
	}

	private void CheckDeflateStream()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowStreamClosedException()
	{
	}
}
