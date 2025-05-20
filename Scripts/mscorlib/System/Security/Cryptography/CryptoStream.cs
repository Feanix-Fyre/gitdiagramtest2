using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Security.Cryptography;

/// <summary>Defines a stream that links data streams to cryptographic transformations.</summary>
public class CryptoStream : Stream, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadAsyncInternal_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public CryptoStream _003C_003E4__this;

		public byte[] buffer;

		public int offset;

		public int count;

		public CancellationToken cancellationToken;

		private SemaphoreSlim _003Csemaphore_003E5__2;

		private ForceAsyncAwaiter _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

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
	private struct _003CReadAsyncCore_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public int count;

		public int offset;

		public CryptoStream _003C_003E4__this;

		public byte[] buffer;

		public bool useAsync;

		public CancellationToken cancellationToken;

		private int _003CbytesToDeliver_003E5__2;

		private int _003CcurrentOutputIndex_003E5__3;

		private int _003CnumWholeBlocksInBytes_003E5__4;

		private byte[] _003CtempInputBuffer_003E5__5;

		private byte[] _003CtempOutputBuffer_003E5__6;

		private ValueTaskAwaiter<int> _003C_003Eu__1;

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
	private struct _003CWriteAsyncInternal_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CryptoStream _003C_003E4__this;

		public byte[] buffer;

		public int offset;

		public int count;

		public CancellationToken cancellationToken;

		private SemaphoreSlim _003Csemaphore_003E5__2;

		private ForceAsyncAwaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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
	private struct _003CWriteAsyncCore_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int count;

		public int offset;

		public CryptoStream _003C_003E4__this;

		public byte[] buffer;

		public bool useAsync;

		public CancellationToken cancellationToken;

		private int _003CbytesToWrite_003E5__2;

		private int _003CcurrentInputIndex_003E5__3;

		private int _003CnumOutputBytes_003E5__4;

		private ValueTaskAwaiter _003C_003Eu__1;

		private int _003CnumWholeBlocksInBytes_003E5__5;

		private byte[] _003CtempOutputBuffer_003E5__6;

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

	private readonly Stream _stream;

	private readonly ICryptoTransform _transform;

	private readonly CryptoStreamMode _transformMode;

	private byte[] _inputBuffer;

	private int _inputBufferIndex;

	private int _inputBlockSize;

	private byte[] _outputBuffer;

	private int _outputBufferIndex;

	private int _outputBlockSize;

	private bool _canRead;

	private bool _canWrite;

	private bool _finalBlockTransformed;

	private SemaphoreSlim _lazyAsyncActiveSemaphore;

	private readonly bool _leaveOpen;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Security.Cryptography.CryptoStream" /> is readable.</summary>
	/// <returns>
	///   <see langword="true" /> if the current stream is readable; otherwise, <see langword="false" />.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a value indicating whether you can seek within the current <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
	/// <returns>Always <see langword="false" />.</returns>
	public override bool CanSeek => false;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Security.Cryptography.CryptoStream" /> is writable.</summary>
	/// <returns>
	///   <see langword="true" /> if the current stream is writable; otherwise, <see langword="false" />.</returns>
	public override bool CanWrite => false;

	/// <summary>Gets the length in bytes of the stream.</summary>
	/// <returns>This property is not supported.</returns>
	/// <exception cref="T:System.NotSupportedException">This property is not supported.</exception>
	public override long Length => 0L;

	/// <summary>Gets or sets the position within the current stream.</summary>
	/// <returns>This property is not supported.</returns>
	/// <exception cref="T:System.NotSupportedException">This property is not supported.</exception>
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

	/// <summary>Gets a value indicating whether the final buffer block has been written to the underlying stream.</summary>
	/// <returns>
	///   <see langword="true" /> if the final block has been flushed; otherwise, <see langword="false" />.</returns>
	public bool HasFlushedFinalBlock => false;

	private SemaphoreSlim AsyncActiveSemaphore => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptoStream" /> class with a target data stream, the transformation to use, and the mode of the stream.</summary>
	/// <param name="stream">The stream on which to perform the cryptographic transformation.</param>
	/// <param name="transform">The cryptographic transformation that is to be performed on the stream.</param>
	/// <param name="mode">One of the <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> values.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> is invalid.</exception>
	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptoStream" /> class.</summary>
	/// <param name="stream">The stream on which to perform the cryptographic transformation.</param>
	/// <param name="transform">The cryptographic transformation that is to be performed on the stream.</param>
	/// <param name="mode">The mode of the stream.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to not close the underlying stream when the <see cref="T:System.Security.Cryptography.CryptoStream" /> object is disposed; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="mode" /> is invalid.</exception>
	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
	{
	}

	/// <summary>Updates the underlying data source or repository with the current state of the buffer, then clears the buffer.</summary>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key is corrupt which can cause invalid padding to the stream.</exception>
	/// <exception cref="T:System.NotSupportedException">The current stream is not writable.  
	///  -or-  
	///  The final block has already been transformed.</exception>
	public void FlushFinalBlock()
	{
	}

	/// <summary>Clears all buffers for the current stream and causes any buffered data to be written to the underlying device.</summary>
	public override void Flush()
	{
	}

	/// <summary>Clears all buffers for the current stream asynchronously, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous flush operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Sets the position within the current stream.</summary>
	/// <param name="offset">A byte offset relative to the <paramref name="origin" /> parameter.</param>
	/// <param name="origin">A <see cref="T:System.IO.SeekOrigin" /> object indicating the reference point used to obtain the new position.</param>
	/// <returns>This method is not supported.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	/// <summary>Sets the length of the current stream.</summary>
	/// <param name="value">The desired length of the current stream in bytes.</param>
	/// <exception cref="T:System.NotSupportedException">This property exists only to support inheritance from <see cref="T:System.IO.Stream" />, and cannot be used.</exception>
	public override void SetLength(long value)
	{
	}

	/// <summary>Reads a sequence of bytes from the current stream asynchronously, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
	/// <param name="buffer">The buffer to write the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the task object's <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation.</exception>
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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

	[AsyncStateMachine(typeof(_003CReadAsyncInternal_003Ed__37))]
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override int ReadByte()
	{
		return 0;
	}

	public override void WriteByte(byte value)
	{
	}

	/// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
	/// <param name="buffer">An array of bytes. A maximum of <paramref name="count" /> bytes are read from the current stream and stored in <paramref name="buffer" />.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream.</param>
	/// <param name="count">The maximum number of bytes to be read from the current stream.</param>
	/// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> associated with current <see cref="T:System.Security.Cryptography.CryptoStream" /> object does not match the underlying stream.  For example, this exception is thrown when using <see cref="F:System.Security.Cryptography.CryptoStreamMode.Read" /> with an underlying stream that is write only.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero.  
	///  -or-  
	///  The <paramref name="count" /> parameter is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">Thesum of the <paramref name="count" /> and <paramref name="offset" /> parameters is longer than the length of the buffer.</exception>
	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	private void CheckReadArguments(byte[] buffer, int offset, int count)
	{
	}

	[AsyncStateMachine(typeof(_003CReadAsyncCore_003Ed__42))]
	private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
	{
		return null;
	}

	/// <summary>Writes a sequence of bytes to the current stream asynchronously, advances the current position within the stream by the number of bytes written, and monitors cancellation requests.</summary>
	/// <param name="buffer">The buffer to write data from.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin writing bytes to the stream.</param>
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
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	[AsyncStateMachine(typeof(_003CWriteAsyncInternal_003Ed__46))]
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Writes a sequence of bytes to the current <see cref="T:System.Security.Cryptography.CryptoStream" /> and advances the current position within the stream by the number of bytes written.</summary>
	/// <param name="buffer">An array of bytes. This method copies <paramref name="count" /> bytes from <paramref name="buffer" /> to the current stream.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream.</param>
	/// <param name="count">The number of bytes to be written to the current stream.</param>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> associated with current <see cref="T:System.Security.Cryptography.CryptoStream" /> object does not match the underlying stream.  For example, this exception is thrown when using <see cref="F:System.Security.Cryptography.CryptoStreamMode.Write" /> with an underlying stream that is read only.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero.  
	///  -or-  
	///  The <paramref name="count" /> parameter is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of the <paramref name="count" /> and <paramref name="offset" /> parameters is longer than the length of the buffer.</exception>
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	private void CheckWriteArguments(byte[] buffer, int offset, int count)
	{
	}

	[AsyncStateMachine(typeof(_003CWriteAsyncCore_003Ed__49))]
	private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
	{
		return null;
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
	public void Clear()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.CryptoStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private void InitializeBuffer()
	{
	}
}
