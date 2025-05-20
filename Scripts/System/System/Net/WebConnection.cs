using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;

namespace System.Net;

internal class WebConnection : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CConnect_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebConnection _003C_003E4__this;

		public WebOperation operation;

		public CancellationToken cancellationToken;

		private Exception _003CconnectException_003E5__2;

		private IPAddress[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCreateStream_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public WebConnection _003C_003E4__this;

		public WebOperation operation;

		public bool reused;

		public CancellationToken cancellationToken;

		private NetworkStream _003Cstream_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CInitConnection_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<WebRequestStream> _003C_003Et__builder;

		public WebOperation operation;

		public CancellationToken cancellationToken;

		public WebConnection _003C_003E4__this;

		private bool _003Creused_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

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

	private NetworkCredential ntlm_credentials;

	private bool ntlm_authenticated;

	private bool unsafe_sharing;

	private Stream networkStream;

	private Socket socket;

	private MonoTlsStream monoTlsStream;

	private WebConnectionTunnel tunnel;

	private int disposed;

	private DateTime idleSince;

	private WebOperation currentOperation;

	public ServicePoint ServicePoint { get; }

	public bool Closed => false;

	public DateTime IdleSince => default(DateTime);

	internal bool NtlmAuthenticated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal NetworkCredential NtlmCredential
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool UnsafeAuthenticatedConnectionSharing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public WebConnection(ServicePoint sPoint)
	{
	}

	private bool CanReuse()
	{
		return false;
	}

	private bool CheckReusable()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CConnect_003Ed__16))]
	private Task Connect(WebOperation operation, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCreateStream_003Ed__18))]
	private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInitConnection_003Ed__19))]
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
	{
		return null;
	}

	internal static WebException GetException(WebExceptionStatus status, Exception error)
	{
		return null;
	}

	internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output)
	{
		return false;
	}

	internal bool CanReuseConnection(WebOperation operation)
	{
		return false;
	}

	private bool PrepareSharingNtlm(WebOperation operation)
	{
		return false;
	}

	private void Reset()
	{
	}

	private void Close(bool reset)
	{
	}

	private void CloseSocket()
	{
	}

	public bool StartOperation(WebOperation operation, bool reused)
	{
		return false;
	}

	public bool Continue(WebOperation next)
	{
		return false;
	}

	private void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
	}

	private void ResetNtlm()
	{
	}
}
