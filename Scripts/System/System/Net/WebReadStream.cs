using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal abstract class WebReadStream : Stream
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public WebReadStream _003C_003E4__this;

		public CancellationToken cancellationToken;

		public byte[] buffer;

		public int offset;

		public int size;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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

	private bool disposed;

	public WebOperation Operation { get; }

	protected Stream InnerStream { get; }

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

	public override bool CanSeek => false;

	public override bool CanRead => false;

	public override bool CanWrite => false;

	public WebReadStream(WebOperation operation, Stream innerStream)
	{
	}

	public override void SetLength(long value)
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Flush()
	{
	}

	protected Exception GetException(Exception e)
	{
		return null;
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
	{
		return null;
	}

	public override int EndRead(IAsyncResult r)
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003CReadAsync_003Ed__28))]
	public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
	{
		return null;
	}

	protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

	internal virtual Task FinishReading(CancellationToken cancellationToken)
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
