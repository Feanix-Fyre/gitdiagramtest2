using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression;

internal sealed class DeflateManagedStream : Stream
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadAsyncCore_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public Task<int> readTask;

		public DeflateManagedStream _003C_003E4__this;

		public CancellationToken cancellationToken;

		public byte[] array;

		public int offset;

		public int count;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CWriteAsyncCore_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DeflateManagedStream _003C_003E4__this;

		public byte[] array;

		public int offset;

		public int count;

		public CancellationToken cancellationToken;

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

	private Stream _stream;

	private CompressionMode _mode;

	private bool _leaveOpen;

	private InflaterManaged _inflater;

	private DeflaterManaged _deflater;

	private byte[] _buffer;

	private int _asyncOperations;

	private IFileFormatWriter _formatWriter;

	private bool _wroteHeader;

	private bool _wroteBytes;

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

	internal DeflateManagedStream(Stream stream, ZipArchiveEntry.CompressionMethodValues method)
	{
	}

	internal void InitializeInflater(Stream stream, bool leaveOpen, IFileFormatReader reader = null, ZipArchiveEntry.CompressionMethodValues method = ZipArchiveEntry.CompressionMethodValues.Deflate)
	{
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override int Read(byte[] array, int offset, int count)
	{
		return 0;
	}

	private void ValidateParameters(byte[] array, int offset, int count)
	{
	}

	private void EnsureNotDisposed()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowStreamClosedException()
	{
	}

	private void EnsureDecompressionMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowCannotReadFromDeflateManagedStreamException()
	{
	}

	private void EnsureCompressionMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowCannotWriteToDeflateManagedStreamException()
	{
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		return null;
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadAsyncCore_003Ed__40))]
	private Task<int> ReadAsyncCore(Task<int> readTask, byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override void Write(byte[] array, int offset, int count)
	{
	}

	private void WriteDeflaterOutput()
	{
	}

	private void DoMaintenance(byte[] array, int offset, int count)
	{
	}

	private void PurgeBuffers(bool disposing)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteAsyncCore_003Ed__47))]
	private Task WriteAsyncCore(byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
	}
}
