using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

/// <summary>Provides a generic view of a sequence of bytes. This is an abstract class.</summary>
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable
{
	private struct ReadWriteParameters
	{
		internal byte[] Buffer;

		internal int Offset;

		internal int Count;
	}

	private sealed class ReadWriteTask : Task<int>, ITaskCompletionAction
	{
		internal readonly bool _isRead;

		internal readonly bool _apm;

		internal Stream _stream;

		internal byte[] _buffer;

		internal readonly int _offset;

		internal readonly int _count;

		private AsyncCallback _callback;

		private ExecutionContext _context;

		private static ContextCallback s_invokeAsyncCallback;

		bool ITaskCompletionAction.InvokeMayRunArbitraryCode => false;

		internal void ClearBeginState()
		{
		}

		public ReadWriteTask(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback)
		{
		}

		private static void InvokeAsyncCallback(object completedTask)
		{
		}

		void ITaskCompletionAction.Invoke(Task completingTask)
		{
		}
	}

	private sealed class NullStream : Stream
	{
		private static readonly Task<int> s_zeroTask;

		public override bool CanRead => false;

		public override bool CanWrite => false;

		public override bool CanSeek => false;

		public override long Length => 0L;

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

		internal NullStream()
		{
		}

		public override void CopyTo(Stream destination, int bufferSize)
		{
		}

		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override int Read(Span<byte> buffer)
		{
			return 0;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask<int>);
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Write(ReadOnlySpan<byte> buffer)
		{
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ValueTask);
		}

		public override void WriteByte(byte value)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long length)
		{
		}
	}

	private sealed class SynchronousAsyncResult : IAsyncResult
	{
		private readonly object _stateObject;

		private readonly bool _isWrite;

		private ManualResetEvent _waitHandle;

		private ExceptionDispatchInfo _exceptionInfo;

		private bool _endXxxCalled;

		private int _bytesRead;

		public bool IsCompleted => false;

		public WaitHandle AsyncWaitHandle => null;

		public object AsyncState => null;

		public bool CompletedSynchronously => false;

		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
		{
		}

		internal SynchronousAsyncResult(object asyncStateObject)
		{
		}

		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite)
		{
		}

		internal void ThrowIfError()
		{
		}

		internal static int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		internal static void EndWrite(IAsyncResult asyncResult)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCopyToAsyncInternal_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int bufferSize;

		public Stream _003C_003E4__this;

		public CancellationToken cancellationToken;

		public Stream destination;

		private byte[] _003Cbuffer_003E5__2;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__1;

		private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CFinishWriteAsync_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Task writeTask;

		public byte[] localBuffer;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	/// <summary>A <see langword="Stream" /> with no backing store.</summary>
	public static readonly Stream Null;

	[NonSerialized]
	private ReadWriteTask _activeReadWriteTask;

	[NonSerialized]
	private SemaphoreSlim _asyncActiveSemaphore;

	/// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports reading.</summary>
	/// <returns>
	///   <see langword="true" /> if the stream supports reading; otherwise, <see langword="false" />.</returns>
	public abstract bool CanRead { get; }

	/// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports seeking.</summary>
	/// <returns>
	///   <see langword="true" /> if the stream supports seeking; otherwise, <see langword="false" />.</returns>
	public abstract bool CanSeek { get; }

	/// <summary>Gets a value that determines whether the current stream can time out.</summary>
	/// <returns>A value that determines whether the current stream can time out.</returns>
	public virtual bool CanTimeout => false;

	/// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports writing.</summary>
	/// <returns>
	///   <see langword="true" /> if the stream supports writing; otherwise, <see langword="false" />.</returns>
	public abstract bool CanWrite { get; }

	/// <summary>When overridden in a derived class, gets the length in bytes of the stream.</summary>
	/// <returns>A long value representing the length of the stream in bytes.</returns>
	/// <exception cref="T:System.NotSupportedException">A class derived from <see langword="Stream" /> does not support seeking.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public abstract long Length { get; }

	/// <summary>When overridden in a derived class, gets or sets the position within the current stream.</summary>
	/// <returns>The current position within the stream.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support seeking.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public abstract long Position { get; set; }

	/// <summary>Gets or sets a value, in miliseconds, that determines how long the stream will attempt to read before timing out.</summary>
	/// <returns>A value, in miliseconds, that determines how long the stream will attempt to read before timing out.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.IO.Stream.ReadTimeout" /> method always throws an <see cref="T:System.InvalidOperationException" />.</exception>
	public virtual int ReadTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value, in miliseconds, that determines how long the stream will attempt to write before timing out.</summary>
	/// <returns>A value, in miliseconds, that determines how long the stream will attempt to write before timing out.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.IO.Stream.WriteTimeout" /> method always throws an <see cref="T:System.InvalidOperationException" />.</exception>
	public virtual int WriteTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
	{
		return null;
	}

	/// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream.</summary>
	/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
	/// <returns>A task that represents the asynchronous copy operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destination" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
	public Task CopyToAsync(Stream destination)
	{
		return null;
	}

	/// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream, using a specified buffer size.</summary>
	/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
	/// <param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero. The default size is 81920.</param>
	/// <returns>A task that represents the asynchronous copy operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destination" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="buffersize" /> is negative or zero.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
	public Task CopyToAsync(Stream destination, int bufferSize)
	{
		return null;
	}

	/// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream, using a specified buffer size and cancellation token.</summary>
	/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
	/// <param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero. The default size is 81920.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous copy operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destination" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="buffersize" /> is negative or zero.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCopyToAsyncInternal_003Ed__28))]
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Reads the bytes from the current stream and writes them to another stream.</summary>
	/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destination" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The current stream does not support reading.  
	///  -or-  
	///  <paramref name="destination" /> does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	public void CopyTo(Stream destination)
	{
	}

	/// <summary>Reads the bytes from the current stream and writes them to another stream, using a specified buffer size.</summary>
	/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
	/// <param name="bufferSize">The size of the buffer. This value must be greater than zero. The default size is 81920.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destination" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is negative or zero.</exception>
	/// <exception cref="T:System.NotSupportedException">The current stream does not support reading.  
	///  -or-  
	///  <paramref name="destination" /> does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	public virtual void CopyTo(Stream destination, int bufferSize)
	{
	}

	private int GetCopyBufferSize()
	{
		return 0;
	}

	/// <summary>Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream. Instead of calling this method, ensure that the stream is properly disposed.</summary>
	public virtual void Close()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.IO.Stream" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Stream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>When overridden in a derived class, clears all buffers for this stream and causes any buffered data to be written to the underlying device.</summary>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public abstract void Flush();

	/// <summary>Asynchronously clears all buffers for this stream, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous flush operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	public virtual Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Begins an asynchronous read operation. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead.)</summary>
	/// <param name="buffer">The buffer to read the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data read from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <param name="callback">An optional asynchronous callback, to be called when the read is complete.</param>
	/// <param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous read, which could still be pending.</returns>
	/// <exception cref="T:System.IO.IOException">Attempted an asynchronous read past the end of the stream, or a disk error occurs.</exception>
	/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current <see langword="Stream" /> implementation does not support the read operation.</exception>
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
	{
		return null;
	}

	/// <summary>Waits for the pending asynchronous read to complete. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead.)</summary>
	/// <param name="asyncResult">The reference to the pending asynchronous request to finish.</param>
	/// <returns>The number of bytes read from the stream, between zero (0) and the number of bytes you requested. Streams return zero (0) only at the end of the stream, otherwise, they should block until at least one byte is available.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">A handle to the pending read operation is not available.  
	///  -or-  
	///  The pending operation does not support reading.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
	/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
	public virtual int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	/// <summary>Asynchronously reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
	/// <param name="buffer">The buffer to write the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation.</exception>
	public Task<int> ReadAsync(byte[] buffer, int offset, int count)
	{
		return null;
	}

	/// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
	/// <param name="buffer">The buffer to write the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation.</exception>
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask<int>);
	}

	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
	{
		return null;
	}

	/// <summary>Begins an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead.)</summary>
	/// <param name="buffer">The buffer to write data from.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> from which to begin writing.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <param name="callback">An optional asynchronous callback, to be called when the write is complete.</param>
	/// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
	/// <returns>An <see langword="IAsyncResult" /> that represents the asynchronous write, which could still be pending.</returns>
	/// <exception cref="T:System.IO.IOException">Attempted an asynchronous write past the end of the stream, or a disk error occurs.</exception>
	/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current <see langword="Stream" /> implementation does not support the write operation.</exception>
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
	{
		return null;
	}

	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask)
	{
	}

	private void RunReadWriteTask(ReadWriteTask readWriteTask)
	{
	}

	private void FinishTrackingAsyncOperation()
	{
	}

	/// <summary>Ends an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead.)</summary>
	/// <param name="asyncResult">A reference to the outstanding asynchronous I/O request.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">A handle to the pending write operation is not available.  
	///  -or-  
	///  The pending operation does not support writing.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
	/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
	public virtual void EndWrite(IAsyncResult asyncResult)
	{
	}

	/// <summary>Asynchronously writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
	/// <param name="buffer">The buffer to write data from.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation.</exception>
	public Task WriteAsync(byte[] buffer, int offset, int count)
	{
		return null;
	}

	/// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.</summary>
	/// <param name="buffer">The buffer to write data from.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation.</exception>
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask);
	}

	[AsyncStateMachine(typeof(_003CFinishWriteAsync_003Ed__57))]
	private Task FinishWriteAsync(Task writeTask, byte[] localBuffer)
	{
		return null;
	}

	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, sets the position within the current stream.</summary>
	/// <param name="offset">A byte offset relative to the <paramref name="origin" /> parameter.</param>
	/// <param name="origin">A value of type <see cref="T:System.IO.SeekOrigin" /> indicating the reference point used to obtain the new position.</param>
	/// <returns>The new position within the current stream.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support seeking, such as if the stream is constructed from a pipe or console output.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public abstract long Seek(long offset, SeekOrigin origin);

	/// <summary>When overridden in a derived class, sets the length of the current stream.</summary>
	/// <param name="value">The desired length of the current stream in bytes.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support both writing and seeking, such as if the stream is constructed from a pipe or console output.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public abstract void SetLength(long value);

	/// <summary>When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
	/// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the bytes read from the current source.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream.</param>
	/// <param name="count">The maximum number of bytes to be read from the current stream.</param>
	/// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public abstract int Read(byte[] buffer, int offset, int count);

	public virtual int Read(Span<byte> buffer)
	{
		return 0;
	}

	/// <summary>Reads a byte from the stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream.</summary>
	/// <returns>The unsigned byte cast to an <see langword="Int32" />, or -1 if at the end of the stream.</returns>
	/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public virtual int ReadByte()
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
	/// <param name="buffer">An array of bytes. This method copies <paramref name="count" /> bytes from <paramref name="buffer" /> to the current stream.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream.</param>
	/// <param name="count">The number of bytes to be written to the current stream.</param>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is greater than the buffer length.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occured, such as the specified file cannot be found.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="M:System.IO.Stream.Write(System.Byte[],System.Int32,System.Int32)" /> was called after the stream was closed.</exception>
	public abstract void Write(byte[] buffer, int offset, int count);

	public virtual void Write(ReadOnlySpan<byte> buffer)
	{
	}

	/// <summary>Writes a byte to the current position in the stream and advances the position within the stream by one byte.</summary>
	/// <param name="value">The byte to write to the stream.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support writing, or the stream is already closed.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public virtual void WriteByte(byte value)
	{
	}

	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal static int BlockingEndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal static void BlockingEndWrite(IAsyncResult asyncResult)
	{
	}

	private bool HasOverriddenBeginEndRead()
	{
		return false;
	}

	private bool HasOverriddenBeginEndWrite()
	{
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.Stream" /> class.</summary>
	protected Stream()
	{
	}
}
