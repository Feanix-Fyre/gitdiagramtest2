using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class WebOperation
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetRequestStream_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public WebOperation _003C_003E4__this;

		private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CRun_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WebOperation _003C_003E4__this;

		private WebRequestStream _003CrequestStream_003E5__2;

		private WebResponseStream _003Cstream_003E5__3;

		private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter _003C_003Eu__1;

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

	private CancellationTokenSource cts;

	private WebCompletionSource<WebRequestStream> requestTask;

	private WebCompletionSource<WebRequestStream> requestWrittenTask;

	private WebCompletionSource<WebResponseStream> responseTask;

	private WebCompletionSource<(bool, WebOperation)> finishedTask;

	private WebRequestStream writeStream;

	private WebResponseStream responseStream;

	private ExceptionDispatchInfo disposedInfo;

	private ExceptionDispatchInfo closedInfo;

	private WebOperation priorityRequest;

	private int requestSent;

	private int finished;

	public HttpWebRequest Request { get; }

	public WebConnection Connection { get; private set; }

	public ServicePoint ServicePoint { get; private set; }

	public BufferOffsetSize WriteBuffer { get; }

	public bool IsNtlmChallenge { get; }

	public bool Aborted => false;

	public bool Closed => false;

	public WebRequestStream WriteStream => null;

	internal WebCompletionSource<(bool, WebOperation)> Finished => null;

	public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
	{
	}

	public void Abort()
	{
	}

	public void Close()
	{
	}

	private void SetCanceled()
	{
	}

	private void SetError(Exception error)
	{
	}

	private (ExceptionDispatchInfo, bool) SetDisposed(ref ExceptionDispatchInfo field)
	{
		return default((ExceptionDispatchInfo, bool));
	}

	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken)
	{
		return null;
	}

	internal void ThrowIfDisposed()
	{
	}

	internal void ThrowIfDisposed(CancellationToken cancellationToken)
	{
	}

	internal void ThrowIfClosedOrDisposed()
	{
	}

	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
	{
	}

	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field)
	{
		return null;
	}

	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
	{
	}

	public void SetPriorityRequest(WebOperation operation)
	{
	}

	[AsyncStateMachine(typeof(_003CGetRequestStream_003Ed__50))]
	public Task<Stream> GetRequestStream()
	{
		return null;
	}

	internal Task<WebRequestStream> GetRequestStreamInternal()
	{
		return null;
	}

	public Task<WebResponseStream> GetResponseStream()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CRun_003Ed__58))]
	internal void Run()
	{
	}

	internal void CompleteRequestWritten(WebRequestStream stream, Exception error = null)
	{
	}

	internal void Finish(bool ok, Exception error = null)
	{
	}
}
