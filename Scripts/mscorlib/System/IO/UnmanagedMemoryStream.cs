using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

/// <summary>Provides access to unmanaged blocks of memory from managed code.</summary>
public class UnmanagedMemoryStream : Stream
{
	private SafeBuffer _buffer;

	private unsafe byte* _mem;

	private long _length;

	private long _capacity;

	private long _position;

	private long _offset;

	private FileAccess _access;

	internal bool _isOpen;

	private Task<int> _lastReadTask;

	/// <summary>Gets a value indicating whether a stream supports reading.</summary>
	/// <returns>
	///   <see langword="false" /> if the object was created by a constructor with an <paramref name="access" /> parameter that did not include reading the stream and if the stream is closed; otherwise, <see langword="true" />.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a value indicating whether a stream supports seeking.</summary>
	/// <returns>
	///   <see langword="false" /> if the stream is closed; otherwise, <see langword="true" />.</returns>
	public override bool CanSeek => false;

	/// <summary>Gets a value indicating whether a stream supports writing.</summary>
	/// <returns>
	///   <see langword="false" /> if the object was created by a constructor with an <paramref name="access" /> parameter value that supports writing or was created by a constructor that had no parameters, or if the stream is closed; otherwise, <see langword="true" />.</returns>
	public override bool CanWrite => false;

	/// <summary>Gets the length of the data in a stream.</summary>
	/// <returns>The length of the data in the stream.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public override long Length => 0L;

	/// <summary>Gets the stream length (size) or the total amount of memory assigned to a stream (capacity).</summary>
	/// <returns>The size or capacity of the stream.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public long Capacity => 0L;

	/// <summary>Gets or sets the current position in a stream.</summary>
	/// <returns>The current position in the stream.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The position is set to a value that is less than zero, or the position is larger than <see cref="F:System.Int32.MaxValue" /> or results in overflow when added to the current pointer.</exception>
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

	/// <summary>Gets or sets a byte pointer to a stream based on the current position in the stream.</summary>
	/// <returns>A byte pointer.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The current position is larger than the capacity of the stream.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The position is being set is not a valid position in the current stream.</exception>
	/// <exception cref="T:System.IO.IOException">The pointer is being set to a lower value than the starting position of the stream.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream was initialized for use with a <see cref="T:System.Runtime.InteropServices.SafeBuffer" />. The <see cref="P:System.IO.UnmanagedMemoryStream.PositionPointer" /> property is valid only for streams that are initialized with a <see cref="T:System.Byte" /> pointer.</exception>
	[CLSCompliant(false)]
	public unsafe byte* PositionPointer => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class.</summary>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the required permission.</exception>
	protected UnmanagedMemoryStream()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class using the specified location and memory length.</summary>
	/// <param name="pointer">A pointer to an unmanaged memory location.</param>
	/// <param name="length">The length of the memory to use.</param>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="pointer" /> value is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="length" /> value is less than zero.  
	/// -or-
	///  The <paramref name="length" /> is large enough to cause an overflow.</exception>
	[CLSCompliant(false)]
	public unsafe UnmanagedMemoryStream(byte* pointer, long length)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class using the specified location, memory length, total amount of memory, and file access values.</summary>
	/// <param name="pointer">A pointer to an unmanaged memory location.</param>
	/// <param name="length">The length of the memory to use.</param>
	/// <param name="capacity">The total amount of memory assigned to the stream.</param>
	/// <param name="access">One of the <see cref="T:System.IO.FileAccess" /> values.</param>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="pointer" /> value is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="length" /> value is less than zero.  
	/// -or-
	///  The <paramref name="capacity" /> value is less than zero.  
	/// -or-
	///  The <paramref name="length" /> value is greater than the <paramref name="capacity" /> value.</exception>
	[CLSCompliant(false)]
	public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.UnmanagedMemoryStream" /> class by using a pointer to an unmanaged memory location.</summary>
	/// <param name="pointer">A pointer to an unmanaged memory location.</param>
	/// <param name="length">The length of the memory to use.</param>
	/// <param name="capacity">The total amount of memory assigned to the stream.</param>
	/// <param name="access">One of the <see cref="T:System.IO.FileAccess" /> values.</param>
	/// <exception cref="T:System.Security.SecurityException">The user does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="pointer" /> value is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="length" /> value is less than zero.  
	/// -or-
	///  The <paramref name="capacity" /> value is less than zero.  
	/// -or-
	///  The <paramref name="length" /> value is large enough to cause an overflow.</exception>
	[CLSCompliant(false)]
	protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.UnmanagedMemoryStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private void EnsureNotClosed()
	{
	}

	private void EnsureReadable()
	{
	}

	private void EnsureWriteable()
	{
	}

	/// <summary>Overrides the <see cref="M:System.IO.Stream.Flush" /> method so that no action is performed.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public override void Flush()
	{
	}

	/// <summary>Overrides the <see cref="M:System.IO.Stream.FlushAsync(System.Threading.CancellationToken)" /> method so that the operation is cancelled if specified, but no other action is performed.  
	///  Available starting in .NET Framework 4.6</summary>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous flush operation.</returns>
	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Reads the specified number of bytes into the specified array.</summary>
	/// <param name="buffer">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the bytes read from the current source. This parameter is passed uninitialized.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream.</param>
	/// <param name="count">The maximum number of bytes to read from the current stream.</param>
	/// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The underlying memory does not support reading.  
	/// -or-
	///  The <see cref="P:System.IO.UnmanagedMemoryStream.CanRead" /> property is set to <see langword="false" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero.  
	/// -or-
	///  The <paramref name="count" /> parameter is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">The length of the buffer array minus the <paramref name="offset" /> parameter is less than the <paramref name="count" /> parameter.</exception>
	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int Read(Span<byte> buffer)
	{
		return 0;
	}

	internal int ReadCore(Span<byte> buffer)
	{
		return 0;
	}

	/// <summary>Asynchronously reads the specified number of bytes into the specified array.  
	///  Available starting in .NET Framework 4.6</summary>
	/// <param name="buffer">The buffer to write the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns>
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask<int>);
	}

	/// <summary>Reads a byte from a stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream.</summary>
	/// <returns>The unsigned byte cast to an <see cref="T:System.Int32" /> object, or -1 if at the end of the stream.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The underlying memory does not support reading.  
	/// -or-
	///  The current position is at the end of the stream.</exception>
	public override int ReadByte()
	{
		return 0;
	}

	/// <summary>Sets the current position of the current stream to the given value.</summary>
	/// <param name="offset">The point relative to origin to begin seeking from.</param>
	/// <param name="loc">Specifies the beginning, the end, or the current position as a reference point for origin, using a value of type <see cref="T:System.IO.SeekOrigin" />.</param>
	/// <returns>The new position in the stream.</returns>
	/// <exception cref="T:System.IO.IOException">An attempt was made to seek before the beginning of the stream.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> value is larger than the maximum size of the stream.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="loc" /> is invalid.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public override long Seek(long offset, SeekOrigin loc)
	{
		return 0L;
	}

	/// <summary>Sets the length of a stream to a specified value.</summary>
	/// <param name="value">The length of the stream.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error has occurred.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The underlying memory does not support writing.  
	/// -or-
	///  An attempt is made to write to the stream and the <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> property is <see langword="false" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The specified <paramref name="value" /> exceeds the capacity of the stream.  
	/// -or-
	///  The specified <paramref name="value" /> is negative.</exception>
	public override void SetLength(long value)
	{
	}

	/// <summary>Writes a block of bytes to the current stream using data from a buffer.</summary>
	/// <param name="buffer">The byte array from which to copy bytes to the current stream.</param>
	/// <param name="offset">The offset in the buffer at which to begin copying bytes to the current stream.</param>
	/// <param name="count">The number of bytes to write to the current stream.</param>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The underlying memory does not support writing.  
	/// -or-
	///  An attempt is made to write to the stream and the <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> property is <see langword="false" />.  
	/// -or-
	///  The <paramref name="count" /> value is greater than the capacity of the stream.  
	/// -or-
	///  The position is at the end of the stream capacity.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">One of the specified parameters is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="offset" /> parameter minus the length of the <paramref name="buffer" /> parameter is less than the <paramref name="count" /> parameter.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />.</exception>
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Write(ReadOnlySpan<byte> buffer)
	{
	}

	internal void WriteCore(ReadOnlySpan<byte> buffer)
	{
	}

	/// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.  
	///  Available starting in .NET Framework 4.6</summary>
	/// <param name="buffer">The buffer to write data from.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask);
	}

	/// <summary>Writes a byte to the current position in the file stream.</summary>
	/// <param name="value">A byte value written to the stream.</param>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The underlying memory does not support writing.  
	/// -or-
	///  An attempt is made to write to the stream and the <see cref="P:System.IO.UnmanagedMemoryStream.CanWrite" /> property is <see langword="false" />.  
	/// -or-
	///  The current position is at the end of the capacity of the stream.</exception>
	/// <exception cref="T:System.IO.IOException">The supplied <paramref name="value" /> causes the stream exceed its maximum capacity.</exception>
	public override void WriteByte(byte value)
	{
	}
}
