using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class WebResponseStream : WebConnectionStream
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public byte[] buffer;

		public int offset;

		public int count;

		public WebResponseStream _003C_003E4__this;

		private WebCompletionSource _003Ccompletion_003E5__2;

		private int _003Cnbytes_003E5__3;

		private Exception _003CthrowMe_003E5__4;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CReadAllAsyncInner_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public WebResponseStream _003C_003E4__this;

		private long _003CmaximumSize_003E5__2;

		private MemoryStream _003Cms_003E5__3;

		private byte[] _003Cbuffer_003E5__4;

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
	private struct _003CReadAllAsync_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebResponseStream _003C_003E4__this;

		public CancellationToken cancellationToken;

		public bool resending;

		private WebCompletionSource _003Ccompletion_003E5__2;

		private CancellationTokenSource _003CtimeoutCts_003E5__3;

		private Task _003CtimeoutTask_003E5__4;

		private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CInitReadAsync_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebResponseStream _003C_003E4__this;

		public CancellationToken cancellationToken;

		private BufferOffsetSize _003Cbuffer_003E5__2;

		private ReadState _003Cstate_003E5__3;

		private int _003Cposition_003E5__4;

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

	private WebReadStream innerStream;

	private bool nextReadCalled;

	private bool bufferedEntireContent;

	private WebCompletionSource pendingRead;

	private object locker;

	private int nestedRead;

	private bool read_eof;

	public WebRequestStream RequestStream { get; }

	public WebHeaderCollection Headers { get; private set; }

	public HttpStatusCode StatusCode { get; private set; }

	public string StatusDescription { get; private set; }

	public Version Version { get; private set; }

	public bool KeepAlive { get; private set; }

	public override bool CanRead => false;

	public override bool CanWrite => false;

	private bool ChunkedRead { get; set; }

	private bool ExpectContent => false;

	public WebResponseStream(WebRequestStream request)
		: base(null, null)
	{
	}

	[AsyncStateMachine(typeof(_003CReadAsync_003Ed__40))]
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
	{
		return null;
	}

	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result)
	{
		result = default(int);
		return false;
	}

	private void Initialize(BufferOffsetSize buffer)
	{
	}

	[AsyncStateMachine(typeof(_003CReadAllAsyncInner_003Ed__47))]
	private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadAllAsync_003Ed__48))]
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	protected override void Close_internal(ref bool disposed)
	{
	}

	private WebException GetReadException(WebExceptionStatus status, Exception error, string where)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInitReadAsync_003Ed__52))]
	internal Task InitReadAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state)
	{
		return false;
	}
}
