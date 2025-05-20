using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Net.Sockets;

/// <summary>Represents an asynchronous socket operation.</summary>
public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	private bool disposed;

	internal int in_progress;

	private EndPoint remote_ep;

	private Socket current_socket;

	internal SocketAsyncResult socket_async_result;

	[CompilerGenerated]
	private SocketAsyncOperation _003CLastOperation_003Ek__BackingField;

	[CompilerGenerated]
	private SocketFlags _003CSocketFlags_003Ek__BackingField;

	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed;

	private Memory<byte> _buffer;

	private int _offset;

	private int _count;

	private bool _bufferIsExplicitArray;

	private IList<ArraySegment<byte>> _bufferList;

	private List<ArraySegment<byte>> _bufferListInternal;

	/// <summary>Gets or sets the socket to use or the socket created for accepting a connection with an asynchronous socket method.</summary>
	/// <returns>The <see cref="T:System.Net.Sockets.Socket" /> to use or the socket created for accepting a connection with an asynchronous socket method.</returns>
	public Socket AcceptSocket { get; set; }

	/// <summary>Gets the number of bytes transferred in the socket operation.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the number of bytes transferred in the socket operation.</returns>
	public int BytesTransferred { get; private set; }

	/// <summary>Gets the type of socket operation most recently performed with this context object.</summary>
	/// <returns>A <see cref="T:System.Net.Sockets.SocketAsyncOperation" /> instance that indicates the type of socket operation most recently performed with this context object.</returns>
	private SocketAsyncOperation LastOperation
	{
		[CompilerGenerated]
		set
		{
			_003CLastOperation_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets the remote IP endpoint for an asynchronous operation.</summary>
	/// <returns>An <see cref="T:System.Net.EndPoint" /> that represents the remote IP endpoint for an asynchronous operation.</returns>
	public EndPoint RemoteEndPoint
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the result of the asynchronous socket operation.</summary>
	/// <returns>A <see cref="T:System.Net.Sockets.SocketError" /> that represents the result of the asynchronous socket operation.</returns>
	public SocketError SocketError { get; set; }

	/// <summary>Gets the results of an asynchronous socket operation or sets the behavior of an asynchronous operation.</summary>
	/// <returns>A <see cref="T:System.Net.Sockets.SocketFlags" /> that represents the results of an asynchronous socket operation.</returns>
	public SocketFlags SocketFlags
	{
		[CompilerGenerated]
		set
		{
			_003CSocketFlags_003Ek__BackingField = value;
		}
	}

	/// <summary>Gets or sets a user or application object associated with this asynchronous socket operation.</summary>
	/// <returns>An object that represents the user or application object associated with this asynchronous socket operation.</returns>
	public object UserToken { get; set; }

	internal Socket CurrentSocket => null;

	public Memory<byte> MemoryBuffer => default(Memory<byte>);

	/// <summary>Gets the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</returns>
	public int Offset => 0;

	/// <summary>Gets the maximum amount of data, in bytes, to send or receive in an asynchronous operation.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the maximum amount of data, in bytes, to send or receive.</returns>
	public int Count => 0;

	/// <summary>Gets or sets an array of data buffers to use with an asynchronous socket method.</summary>
	/// <returns>An <see cref="T:System.Collections.IList" /> that represents an array of data buffers to use with an asynchronous socket method.</returns>
	/// <exception cref="T:System.ArgumentException">There are ambiguous buffers specified on a set operation. This exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property has been set to a non-null value and an attempt was made to set the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property to a non-null value.</exception>
	public IList<ArraySegment<byte>> BufferList => null;

	internal SocketAsyncEventArgs(bool flowExecutionContext)
	{
	}

	/// <summary>Frees resources used by the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> class.</summary>
	~SocketAsyncEventArgs()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> instance and optionally disposes of the managed resources.</summary>
	public void Dispose()
	{
	}

	internal void SetBytesTransferred(int value)
	{
	}

	internal void SetCurrentSocket(Socket socket)
	{
	}

	internal void SetLastOperation(SocketAsyncOperation op)
	{
	}

	internal void Complete_internal()
	{
	}

	/// <summary>Represents a method that is called when an asynchronous operation completes.</summary>
	/// <param name="e">The event that is signaled.</param>
	protected virtual void OnCompleted(SocketAsyncEventArgs e)
	{
	}

	public void SetBuffer(Memory<byte> buffer)
	{
	}
}
