using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http;

internal class MonoWebRequestHandler : IMonoHttpClientHandler, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSendAsync_003Ed__99 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public MonoWebRequestHandler _003C_003E4__this;

		public CancellationToken cancellationToken;

		public HttpRequestMessage request;

		private HttpWebRequest _003Cwrequest_003E5__2;

		private HttpWebResponse _003Cwresponse_003E5__3;

		private CancellationTokenRegistration _003C_003E7__wrap3;

		private HttpContent _003Ccontent_003E5__5;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private Stream _003Cstream_003E5__6;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__4;

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

	private static long groupCounter;

	private bool allowAutoRedirect;

	private DecompressionMethods automaticDecompression;

	private CookieContainer cookieContainer;

	private ICredentials credentials;

	private int maxAutomaticRedirections;

	private long maxRequestContentBufferSize;

	private bool preAuthenticate;

	private IWebProxy proxy;

	private bool useCookies;

	private bool useProxy;

	private SslClientAuthenticationOptions sslOptions;

	private bool allowPipelining;

	private RequestCachePolicy cachePolicy;

	private AuthenticationLevel authenticationLevel;

	private TimeSpan continueTimeout;

	private TokenImpersonationLevel impersonationLevel;

	private int maxResponseHeadersLength;

	private int readWriteTimeout;

	private RemoteCertificateValidationCallback serverCertificateValidationCallback;

	private bool unsafeAuthenticatedConnectionSharing;

	private bool sentRequest;

	private string connectionGroupName;

	private TimeSpan? timeout;

	private bool disposed;

	public CookieContainer CookieContainer => null;

	public long MaxRequestContentBufferSize => 0L;

	public SslClientAuthenticationOptions SslOptions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal void EnsureModifiability()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	private bool GetConnectionKeepAlive(HttpRequestHeaders headers)
	{
		return false;
	}

	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request)
	{
		return null;
	}

	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken)
	{
		return null;
	}

	private static bool MethodHasBody(HttpMethod method)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CSendAsync_003Ed__99))]
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		return null;
	}

	void IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout)
	{
	}
}
