using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets;

/// <summary>Provides the underlying stream of data for network access.</summary>
public class NetworkStream : Stream
{
	private readonly Socket _streamSocket;

	private readonly bool _ownsSocket;

	private bool _readable;

	private bool _writeable;

	private int _closeTimeout;

	private bool _cleanedUp;

	private int _currentReadTimeout;

	private int _currentWriteTimeout;

	/// <summary>Gets a value that indicates whether the <see cref="T:System.Net.Sockets.NetworkStream" /> supports reading.</summary>
	/// <returns>
	///   <see langword="true" /> if data can be read from the stream; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a value that indicates whether the stream supports seeking. This property is not currently supported.This property always returns <see langword="false" />.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases to indicate that <see cref="T:System.Net.Sockets.NetworkStream" /> cannot seek a specific location in the stream.</returns>
	public override bool CanSeek => false;

	/// <summary>Gets a value that indicates whether the <see cref="T:System.Net.Sockets.NetworkStream" /> supports writing.</summary>
	/// <returns>
	///   <see langword="true" /> if data can be written to the <see cref="T:System.Net.Sockets.NetworkStream" />; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	public override bool CanWrite => false;

	/// <summary>Indicates whether timeout properties are usable for <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	public override bool CanTimeout => false;

	/// <summary>Gets or sets the amount of time that a read operation blocks waiting for data.</summary>
	/// <returns>A <see cref="T:System.Int32" /> that specifies the amount of time, in milliseconds, that will elapse before a read operation fails. The default value, <see cref="F:System.Threading.Timeout.Infinite" />, specifies that the read operation does not time out.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	public override int ReadTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the amount of time that a write operation blocks waiting for data.</summary>
	/// <returns>A <see cref="T:System.Int32" /> that specifies the amount of time, in milliseconds, that will elapse before a write operation fails. The default value, <see cref="F:System.Threading.Timeout.Infinite" />, specifies that the write operation does not time out.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	public override int WriteTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the length of the data available on the stream. This property is not currently supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>The length of the data available on the stream.</returns>
	/// <exception cref="T:System.NotSupportedException">Any use of this property.</exception>
	public override long Length => 0L;

	/// <summary>Gets or sets the current position in the stream. This property is not currently supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>The current position in the stream.</returns>
	/// <exception cref="T:System.NotSupportedException">Any use of this property.</exception>
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

	internal Socket InternalSocket => null;

	/// <summary>Creates a new instance of the <see cref="T:System.Net.Sockets.NetworkStream" /> class for the specified <see cref="T:System.Net.Sockets.Socket" />.</summary>
	/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket" /> that the <see cref="T:System.Net.Sockets.NetworkStream" /> will use to send and receive data.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">The <paramref name="socket" /> parameter is not connected.  
	///  -or-  
	///  The <see cref="P:System.Net.Sockets.Socket.SocketType" /> property of the <paramref name="socket" /> parameter is not <see cref="F:System.Net.Sockets.SocketType.Stream" />.  
	///  -or-  
	///  The <paramref name="socket" /> parameter is in a nonblocking state.</exception>
	public NetworkStream(Socket socket)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.NetworkStream" /> class for the specified <see cref="T:System.Net.Sockets.Socket" /> with the specified <see cref="T:System.Net.Sockets.Socket" /> ownership.</summary>
	/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket" /> that the <see cref="T:System.Net.Sockets.NetworkStream" /> will use to send and receive data.</param>
	/// <param name="ownsSocket">Set to <see langword="true" /> to indicate that the <see cref="T:System.Net.Sockets.NetworkStream" /> will take ownership of the <see cref="T:System.Net.Sockets.Socket" />; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">The <paramref name="socket" /> parameter is not connected.  
	///  -or-  
	///  the value of the <see cref="P:System.Net.Sockets.Socket.SocketType" /> property of the <paramref name="socket" /> parameter is not <see cref="F:System.Net.Sockets.SocketType.Stream" />.  
	///  -or-  
	///  the <paramref name="socket" /> parameter is in a nonblocking state.</exception>
	public NetworkStream(Socket socket, bool ownsSocket)
	{
	}

	/// <summary>Creates a new instance of the <see cref="T:System.Net.Sockets.NetworkStream" /> class for the specified <see cref="T:System.Net.Sockets.Socket" /> with the specified access rights and the specified <see cref="T:System.Net.Sockets.Socket" /> ownership.</summary>
	/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket" /> that the <see cref="T:System.Net.Sockets.NetworkStream" /> will use to send and receive data.</param>
	/// <param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values that specifies the type of access given to the <see cref="T:System.Net.Sockets.NetworkStream" /> over the provided <see cref="T:System.Net.Sockets.Socket" />.</param>
	/// <param name="ownsSocket">Set to <see langword="true" /> to indicate that the <see cref="T:System.Net.Sockets.NetworkStream" /> will take ownership of the <see cref="T:System.Net.Sockets.Socket" />; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">The <paramref name="socket" /> parameter is not connected.  
	///  -or-  
	///  The <see cref="P:System.Net.Sockets.Socket.SocketType" /> property of the <paramref name="socket" /> parameter is not <see cref="F:System.Net.Sockets.SocketType.Stream" />.  
	///  -or-  
	///  The <paramref name="socket" /> parameter is in a nonblocking state.</exception>
	public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
	{
	}

	/// <summary>Sets the current position of the stream to the given value. This method is not currently supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="offset">This parameter is not used.</param>
	/// <param name="origin">This parameter is not used.</param>
	/// <returns>The position in the stream.</returns>
	/// <exception cref="T:System.NotSupportedException">Any use of this property.</exception>
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	/// <summary>Reads data from the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the location in memory to store data read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <param name="offset">The location in <paramref name="buffer" /> to begin storing the data to.</param>
	/// <param name="size">The number of bytes to read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <returns>The number of bytes read from the <see cref="T:System.Net.Sockets.NetworkStream" />, or 0 if the socket is closed.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.  
	///  -or-  
	///  The <paramref name="offset" /> parameter is greater than the length of <paramref name="buffer" />.  
	///  -or-  
	///  The <paramref name="size" /> parameter is less than 0.  
	///  -or-  
	///  The <paramref name="size" /> parameter is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.  
	///  -or-  
	///  An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.  
	///  -or-  
	///  There is a failure reading from the network.</exception>
	public override int Read(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	public override int Read(Span<byte> destination)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	/// <summary>Writes data to the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to write to the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <param name="offset">The location in <paramref name="buffer" /> from which to start writing data.</param>
	/// <param name="size">The number of bytes to write to the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.  
	///  -or-  
	///  The <paramref name="offset" /> parameter is greater than the length of <paramref name="buffer" />.  
	///  -or-  
	///  The <paramref name="size" /> parameter is less than 0.  
	///  -or-  
	///  The <paramref name="size" /> parameter is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.IO.IOException">There was a failure while writing to the network.  
	///  -or-  
	///  An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.  
	///  -or-  
	///  There was a failure reading from the network.</exception>
	public override void Write(byte[] buffer, int offset, int size)
	{
	}

	public override void Write(ReadOnlySpan<byte> source)
	{
	}

	public override void WriteByte(byte value)
	{
	}

	/// <summary>Closes the <see cref="T:System.Net.Sockets.NetworkStream" /> after waiting the specified time to allow data to be sent.</summary>
	/// <param name="timeout">A 32-bit signed integer that specifies the number of milliseconds to wait to send any remaining data before closing.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="timeout" /> parameter is less than -1.</exception>
	public void Close(int timeout)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.NetworkStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
	~NetworkStream()
	{
	}

	/// <summary>Begins an asynchronous read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the location in memory to store data read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <param name="offset">The location in <paramref name="buffer" /> to begin storing the data.</param>
	/// <param name="size">The number of bytes to read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate that is executed when <see cref="M:System.Net.Sockets.NetworkStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> completes.</param>
	/// <param name="state">An object that contains any additional user-defined data.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous call.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.  
	///  -or-  
	///  The <paramref name="offset" /> parameter is greater than the length of the <paramref name="buffer" /> paramater.  
	///  -or-  
	///  The <paramref name="size" /> is less than 0.  
	///  -or-  
	///  The <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.  
	///  -or-  
	///  There was a failure while reading from the network.  
	///  -or-  
	///  An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.</exception>
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Handles the end of an asynchronous read.</summary>
	/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that represents an asynchronous call.</param>
	/// <returns>The number of bytes read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="asyncResult" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.  
	///  -or-  
	///  An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.</exception>
	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	/// <summary>Begins an asynchronous write to a stream.</summary>
	/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to write to the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <param name="offset">The location in <paramref name="buffer" /> to begin sending the data.</param>
	/// <param name="size">The number of bytes to write to the <see cref="T:System.Net.Sockets.NetworkStream" />.</param>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate that is executed when <see cref="M:System.Net.Sockets.NetworkStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> completes.</param>
	/// <param name="state">An object that contains any additional user-defined data.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous call.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.  
	///  -or-  
	///  The <paramref name="offset" /> parameter is greater than the length of <paramref name="buffer" />.  
	///  -or-  
	///  The <paramref name="size" /> parameter is less than 0.  
	///  -or-  
	///  The <paramref name="size" /> parameter is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
	/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.  
	///  -or-  
	///  There was a failure while writing to the network.  
	///  -or-  
	///  An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.</exception>
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Handles the end of an asynchronous write.</summary>
	/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> that represents the asynchronous call.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.  
	///  -or-  
	///  An error occurred while writing to the network.  
	///  -or-  
	///  An error occurred when accessing the socket.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.</exception>
	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
	{
		return default(ValueTask<int>);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
	{
		return default(ValueTask);
	}

	/// <summary>Flushes data from the stream. This method is reserved for future use.</summary>
	public override void Flush()
	{
	}

	/// <summary>Flushes data from the stream as an asynchronous operation.</summary>
	/// <param name="cancellationToken">A cancellation token used to propagate notification that this  operation should be canceled.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Sets the length of the stream. This method always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="value">This parameter is not used.</param>
	/// <exception cref="T:System.NotSupportedException">Any use of this property.</exception>
	public override void SetLength(long value)
	{
	}

	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
	{
	}
}
