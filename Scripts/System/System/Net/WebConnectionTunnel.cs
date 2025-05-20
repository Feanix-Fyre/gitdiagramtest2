using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class WebConnectionTunnel
{
	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebConnectionTunnel _003C_003E4__this;

		public Stream stream;

		public CancellationToken cancellationToken;

		private bool _003Chave_auth_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<(WebHeaderCollection, byte[], int)>.ConfiguredTaskAwaiter _003C_003Eu__2;

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
	private struct _003CReadHeaders_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(WebHeaderCollection, byte[], int)> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public Stream stream;

		public WebConnectionTunnel _003C_003E4__this;

		private byte[] _003CretBuffer_003E5__2;

		private int _003Cstatus_003E5__3;

		private byte[] _003Cbuffer_003E5__4;

		private MemoryStream _003Cms_003E5__5;

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

	private HttpWebRequest connectRequest;

	private NtlmAuthState ntlmAuthState;

	[CompilerGenerated]
	private string _003CStatusDescription_003Ek__BackingField;

	public HttpWebRequest Request { get; }

	public Uri ConnectUri { get; }

	public bool Success { get; private set; }

	public bool CloseConnection { get; private set; }

	public int StatusCode { get; private set; }

	private string StatusDescription
	{
		[CompilerGenerated]
		set
		{
			_003CStatusDescription_003Ek__BackingField = value;
		}
	}

	public string[] Challenge { get; private set; }

	public WebHeaderCollection Headers { get; private set; }

	public Version ProxyVersion { get; private set; }

	public byte[] Data { get; private set; }

	public WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__42))]
	internal Task Initialize(Stream stream, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadHeaders_003Ed__43))]
	private Task<(WebHeaderCollection, byte[], int)> ReadHeaders(Stream stream, CancellationToken cancellationToken)
	{
		return null;
	}

	private void FlushContents(Stream stream, int contentLength)
	{
	}
}
