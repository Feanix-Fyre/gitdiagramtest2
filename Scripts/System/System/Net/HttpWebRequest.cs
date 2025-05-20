using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net;

/// <summary>Provides an HTTP-specific implementation of the <see cref="T:System.Net.WebRequest" /> class.</summary>
[Serializable]
public class HttpWebRequest : WebRequest, ISerializable
{
	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2
	}

	private struct AuthorizationState
	{
		private readonly HttpWebRequest request;

		private readonly bool isProxy;

		private bool isCompleted;

		private NtlmAuthState ntlm_auth_state;

		public bool IsCompleted => false;

		public NtlmAuthState NtlmAuthState => default(NtlmAuthState);

		public bool IsNtlmAuthenticated => false;

		public AuthorizationState(HttpWebRequest request, bool isProxy)
		{
			this.request = null;
			this.isProxy = false;
			isCompleted = false;
			ntlm_auth_state = default(NtlmAuthState);
		}

		public bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			return false;
		}

		public void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRunWithTimeoutWorker_003Ed__241<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public Task<T> workerTask;

		public int timeout;

		public CancellationTokenSource cts;

		public Action abort;

		public Func<bool> aborted;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CMyGetResponseAsync_003Ed__243 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpWebResponse> _003C_003Et__builder;

		public HttpWebRequest _003C_003E4__this;

		public CancellationToken cancellationToken;

		private WebCompletionSource _003Ccompletion_003E5__2;

		private WebOperation _003Coperation_003E5__3;

		private WebException _003CthrowMe_003E5__4;

		private HttpWebResponse _003Cresponse_003E5__5;

		private WebResponseStream _003Cstream_003E5__6;

		private bool _003Credirect_003E5__7;

		private bool _003CmustReadAll_003E5__8;

		private WebOperation _003Cntlm_003E5__9;

		private BufferOffsetSize _003CwriteBuffer_003E5__10;

		private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<WebResponseStream> _003C_003Eu__3;

		private ConfiguredTaskAwaitable<(HttpWebResponse response, bool redirect, bool mustReadAll, BufferOffsetSize writeBuffer, WebOperation ntlm)>.ConfiguredTaskAwaiter _003C_003Eu__4;

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
	private struct _003CGetResponseFromData_003Ed__244 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(HttpWebResponse response, bool redirect, bool mustReadAll, BufferOffsetSize writeBuffer, WebOperation ntlm)> _003C_003Et__builder;

		public HttpWebRequest _003C_003E4__this;

		public WebResponseStream stream;

		public CancellationToken cancellationToken;

		private HttpWebResponse _003Cresponse_003E5__2;

		private WebException _003CthrowMe_003E5__3;

		private bool _003Credirect_003E5__4;

		private bool _003CmustReadAll_003E5__5;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter _003C_003Eu__2;

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

	private Uri requestUri;

	private Uri actualUri;

	private bool hostChanged;

	private bool allowAutoRedirect;

	private bool allowBuffering;

	private X509CertificateCollection certificates;

	private string connectionGroup;

	private bool haveContentLength;

	private long contentLength;

	private HttpContinueDelegate continueDelegate;

	private CookieContainer cookieContainer;

	private ICredentials credentials;

	private bool haveResponse;

	private bool requestSent;

	private WebHeaderCollection webHeaders;

	private bool keepAlive;

	private int maxAutoRedirect;

	private string mediaType;

	private string method;

	private string initialMethod;

	private bool pipelined;

	private bool preAuthenticate;

	private bool usedPreAuth;

	private Version version;

	private bool force_version;

	private Version actualVersion;

	private IWebProxy proxy;

	private bool sendChunked;

	private ServicePoint servicePoint;

	private int timeout;

	private int continueTimeout;

	private WebRequestStream writeStream;

	private HttpWebResponse webResponse;

	private WebCompletionSource responseTask;

	private WebOperation currentOperation;

	private int aborted;

	private bool gotRequestStream;

	private int redirects;

	private bool expectContinue;

	private bool getResponseCalled;

	private object locker;

	private bool finished_reading;

	private DecompressionMethods auto_decomp;

	private static int defaultMaxResponseHeadersLength;

	private static int defaultMaximumErrorResponseLength;

	private static RequestCachePolicy defaultCachePolicy;

	private int readWriteTimeout;

	private MobileTlsProvider tlsProvider;

	private MonoTlsSettings tlsSettings;

	private ServerCertValidationCallback certValidationCallback;

	private bool hostHasPort;

	private Uri hostUri;

	private AuthorizationState auth_state;

	private AuthorizationState proxy_auth_state;

	[NonSerialized]
	internal Func<Stream, Task> ResendContentFactory;

	private bool unsafe_auth_blah;

	/// <summary>Gets the Uniform Resource Identifier (URI) of the Internet resource that actually responds to the request.</summary>
	/// <returns>A <see cref="T:System.Uri" /> that identifies the Internet resource that actually responds to the request. The default is the URI used by the <see cref="M:System.Net.WebRequest.Create(System.String)" /> method to initialize the request.</returns>
	public Uri Address => null;

	/// <summary>Gets or sets a value that indicates whether the request should follow redirection responses.</summary>
	/// <returns>
	///   <see langword="true" /> if the request should automatically follow redirection responses from the Internet resource; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	public virtual bool AllowAutoRedirect
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether to buffer the data sent to the Internet resource.</summary>
	/// <returns>
	///   <see langword="true" /> to enable buffering of the data sent to the Internet resource; <see langword="false" /> to disable buffering. The default is <see langword="true" />.</returns>
	public virtual bool AllowWriteStreamBuffering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the type of decompression that is used.</summary>
	/// <returns>A <see cref="T:System.Net.DecompressionMethods" /> object that indicates the type of decompression that is used.</returns>
	/// <exception cref="T:System.InvalidOperationException">The object's current state does not allow this property to be set.</exception>
	public DecompressionMethods AutomaticDecompression
	{
		get
		{
			return default(DecompressionMethods);
		}
		set
		{
		}
	}

	internal bool InternalAllowBuffering => false;

	private bool MethodWithBuffer => false;

	internal MobileTlsProvider TlsProvider => null;

	internal MonoTlsSettings TlsSettings => null;

	/// <summary>Gets or sets the collection of security certificates that are associated with this request.</summary>
	/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> that contains the security certificates associated with this request.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation is <see langword="null" />.</exception>
	public X509CertificateCollection ClientCertificates => null;

	/// <summary>Gets or sets the name of the connection group for the request.</summary>
	/// <returns>The name of the connection group for this request. The default value is <see langword="null" />.</returns>
	public override string ConnectionGroupName
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="Content-length" /> HTTP header.</summary>
	/// <returns>The number of bytes of data to send to the Internet resource. The default is -1, which indicates the property has not been set and that there is no request data to send.</returns>
	/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The new <see cref="P:System.Net.HttpWebRequest.ContentLength" /> value is less than 0.</exception>
	public override long ContentLength
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	internal long InternalContentLength
	{
		set
		{
		}
	}

	internal bool ThrowOnError { get; set; }

	/// <summary>Gets or sets the cookies associated with the request.</summary>
	/// <returns>A <see cref="T:System.Net.CookieContainer" /> that contains the cookies associated with this request.</returns>
	public virtual CookieContainer CookieContainer
	{
		set
		{
		}
	}

	/// <summary>Gets or sets authentication information for the request.</summary>
	/// <returns>An <see cref="T:System.Net.ICredentials" /> that contains the authentication credentials associated with the request. The default is <see langword="null" />.</returns>
	public override ICredentials Credentials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the default maximum length of an HTTP error response.</summary>
	/// <returns>The default maximum length of an HTTP error response.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value is less than 0 and is not equal to -1.</exception>
	[System.MonoTODO]
	public static int DefaultMaximumErrorResponseLength => 0;

	/// <summary>Specifies a collection of the name/value pairs that make up the HTTP headers.</summary>
	/// <returns>A <see cref="T:System.Net.WebHeaderCollection" /> that contains the name/value pairs that make up the headers for the HTTP request.</returns>
	/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method.</exception>
	public override WebHeaderCollection Headers => null;

	/// <summary>Gets or sets the Host header value to use in an HTTP request independent from the request URI.</summary>
	/// <returns>The Host header value in the HTTP request.</returns>
	/// <exception cref="T:System.ArgumentNullException">The Host header cannot be set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The Host header cannot be set to an invalid value.</exception>
	/// <exception cref="T:System.InvalidOperationException">The Host header cannot be set after the <see cref="T:System.Net.HttpWebRequest" /> has already started to be sent.</exception>
	public string Host
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether to make a persistent connection to the Internet resource.</summary>
	/// <returns>
	///   <see langword="true" /> if the request to the Internet resource should contain a <see langword="Connection" /> HTTP header with the value Keep-alive; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	public bool KeepAlive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the maximum number of redirects that the request follows.</summary>
	/// <returns>The maximum number of redirection responses that the request follows. The default value is 50.</returns>
	/// <exception cref="T:System.ArgumentException">The value is set to 0 or less.</exception>
	public int MaximumAutomaticRedirections
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the default for the <see cref="P:System.Net.HttpWebRequest.MaximumResponseHeadersLength" /> property.</summary>
	/// <returns>The length, in kilobytes (1024 bytes), of the default maximum for response headers received. The default configuration file sets this value to 64 kilobytes.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value is not equal to -1 and is less than zero.</exception>
	[System.MonoTODO("Use this")]
	public static int DefaultMaximumResponseHeadersLength => 0;

	/// <summary>Gets or sets a time-out in milliseconds when writing to or reading from a stream.</summary>
	/// <returns>The number of milliseconds before the writing or reading times out. The default value is 300,000 milliseconds (5 minutes).</returns>
	/// <exception cref="T:System.InvalidOperationException">The request has already been sent.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than or equal to zero and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /></exception>
	public int ReadWriteTimeout => 0;

	/// <summary>Gets or sets the method for the request.</summary>
	/// <returns>The request method to use to contact the Internet resource. The default value is GET.</returns>
	/// <exception cref="T:System.ArgumentException">No method is supplied.  
	///  -or-  
	///  The method string contains invalid characters.</exception>
	public override string Method
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether to send an Authorization header with the request.</summary>
	/// <returns>
	///   <see langword="true" /> to send an  HTTP Authorization header with requests after authentication has taken place; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public override bool PreAuthenticate
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the version of HTTP to use for the request.</summary>
	/// <returns>The HTTP version to use for the request. The default is <see cref="F:System.Net.HttpVersion.Version11" />.</returns>
	/// <exception cref="T:System.ArgumentException">The HTTP version is set to a value other than 1.0 or 1.1.</exception>
	public Version ProtocolVersion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets proxy information for the request.</summary>
	/// <returns>The <see cref="T:System.Net.IWebProxy" /> object to use to proxy the request. The default value is set by calling the <see cref="P:System.Net.GlobalProxySelection.Select" /> property.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <see cref="P:System.Net.HttpWebRequest.Proxy" /> is set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The request has been started by calling <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have permission for the requested operation.</exception>
	public override IWebProxy Proxy
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the original Uniform Resource Identifier (URI) of the request.</summary>
	/// <returns>A <see cref="T:System.Uri" /> that contains the URI of the Internet resource passed to the <see cref="M:System.Net.WebRequest.Create(System.String)" /> method.</returns>
	public override Uri RequestUri => null;

	/// <summary>Gets or sets a value that indicates whether to send data in segments to the Internet resource.</summary>
	/// <returns>
	///   <see langword="true" /> to send data to the Internet resource in segments; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The request has been started by calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" />, or <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method.</exception>
	public bool SendChunked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the service point to use for the request.</summary>
	/// <returns>A <see cref="T:System.Net.ServicePoint" /> that represents the network connection to the Internet resource.</returns>
	public ServicePoint ServicePoint => null;

	internal ServicePoint ServicePointNoLock => null;

	/// <summary>Gets or sets the time-out value in milliseconds for the <see cref="M:System.Net.HttpWebRequest.GetResponse" /> and <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> methods.</summary>
	/// <returns>The number of milliseconds to wait before the request times out. The default value is 100,000 milliseconds (100 seconds).</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	public override int Timeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the value of the <see langword="Transfer-encoding" /> HTTP header.</summary>
	/// <returns>The value of the <see langword="Transfer-encoding" /> HTTP header. The default value is <see langword="null" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set when <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to the value "Chunked".</exception>
	public string TransferEncoding => null;

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether default credentials are sent with requests.</summary>
	/// <returns>
	///   <see langword="true" /> if the default credentials are used; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">You attempted to set this property after the request was sent.</exception>
	public override bool UseDefaultCredentials => false;

	/// <summary>Gets or sets a value that indicates whether to allow high-speed NTLM-authenticated connection sharing.</summary>
	/// <returns>
	///   <see langword="true" /> to keep the authenticated connection open; otherwise, <see langword="false" />.</returns>
	public bool UnsafeAuthenticatedConnectionSharing => false;

	internal bool ExpectContinue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal Uri AuthUri => null;

	internal bool ProxyQuery => false;

	internal ServerCertValidationCallback ServerCertValidationCallback => null;

	/// <summary>Gets or sets a callback function to validate the server certificate.</summary>
	/// <returns>A callback function to validate the server certificate.</returns>
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool FinishedReading
	{
		set
		{
		}
	}

	internal bool Aborted => false;

	static HttpWebRequest()
	{
	}

	public HttpWebRequest(Uri uri)
	{
	}

	internal HttpWebRequest(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings = null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebRequest" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes. This constructor is obsolete.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the new <see cref="T:System.Net.HttpWebRequest" /> object.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the new <see cref="T:System.Net.HttpWebRequest" /> object.</param>
	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private void ResetAuthorization()
	{
	}

	private bool TryGetHostUri(string hostName, out Uri hostUri)
	{
		hostUri = null;
		return false;
	}

	internal ServicePoint GetServicePoint()
	{
		return null;
	}

	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
	{
		return null;
	}

	private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Begins an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate.</param>
	/// <param name="state">The state object for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request.</returns>
	/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.HttpWebRequest.Method" /> property is GET or HEAD.  
	///  -or-  
	///  <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />, and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is being used by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />  
	///  -or-  
	///  <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />.  
	///  -or-  
	///  The thread pool is running out of threads.</exception>
	/// <exception cref="T:System.NotSupportedException">The request cache validator indicated that the response for this request can be served from the cache; however, requests that write data must not use the cache. This exception can occur if you are using a custom cache validator that is incorrectly implemented.</exception>
	/// <exception cref="T:System.Net.WebException">
	///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.</exception>
	/// <exception cref="T:System.ObjectDisposedException">In a .NET Compact Framework application, a request stream with zero content length was not obtained and closed correctly. For more information about handling zero content length requests, see Network Programming in the .NET Compact Framework.</exception>
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends an asynchronous request for a <see cref="T:System.IO.Stream" /> object to use to write data.</summary>
	/// <param name="asyncResult">The pending request for a stream.</param>
	/// <returns>A <see cref="T:System.IO.Stream" /> to use to write request data.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.IOException">The request did not complete, and no stream is available.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by the current instance from a call to <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">This method was called previously using <paramref name="asyncResult" />.</exception>
	/// <exception cref="T:System.Net.WebException">
	///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.  
	/// -or-  
	/// An error occurred while processing the request.</exception>
	public override Stream EndGetRequestStream(IAsyncResult asyncResult)
	{
		return null;
	}

	public override Task<Stream> GetRequestStreamAsync()
	{
		return null;
	}

	internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CRunWithTimeoutWorker_003Ed__241<>))]
	private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
	{
		return null;
	}

	private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CMyGetResponseAsync_003Ed__243))]
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetResponseFromData_003Ed__244))]
	private Task<(HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation)> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
	{
		return null;
	}

	internal static Exception FlattenException(Exception e)
	{
		return null;
	}

	private WebException GetWebException(Exception e)
	{
		return null;
	}

	private static WebException GetWebException(Exception e, bool aborted)
	{
		return null;
	}

	internal static WebException CreateRequestAbortedException()
	{
		return null;
	}

	/// <summary>Begins an asynchronous request to an Internet resource.</summary>
	/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate</param>
	/// <param name="state">The state object for this request.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous request for a response.</returns>
	/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />  
	///  -or-  
	///  <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />.  
	///  -or-  
	///  The thread pool is running out of threads.</exception>
	/// <exception cref="T:System.Net.ProtocolViolationException">
	///   <see cref="P:System.Net.HttpWebRequest.Method" /> is GET or HEAD, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater than zero or <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="true" />.  
	/// -or-  
	/// <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is <see langword="false" />, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" /> and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT.  
	/// -or-  
	/// The <see cref="T:System.Net.HttpWebRequest" /> has an entity body but the <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> method is called without calling the <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" /> method.  
	/// -or-  
	/// The <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater than zero, but the application does not write all of the promised data.</exception>
	/// <exception cref="T:System.Net.WebException">
	///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.</exception>
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends an asynchronous request to an Internet resource.</summary>
	/// <param name="asyncResult">The pending request for a response.</param>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the Internet resource.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">This method was called previously using <paramref name="asyncResult." />  
	///  -or-  
	///  The <see cref="P:System.Net.HttpWebRequest.ContentLength" /> property is greater than 0 but the data has not been written to the request stream.</exception>
	/// <exception cref="T:System.Net.WebException">
	///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.  
	/// -or-  
	/// An error occurred while processing the request.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not returned by the current instance from a call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
	public override WebResponse EndGetResponse(IAsyncResult asyncResult)
	{
		return null;
	}

	/// <summary>Returns a response from an Internet resource.</summary>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> that contains the response from the Internet resource.</returns>
	/// <exception cref="T:System.InvalidOperationException">The stream is already in use by a previous call to <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.  
	///  -or-  
	///  <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> is set to a value and <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />.</exception>
	/// <exception cref="T:System.Net.ProtocolViolationException">
	///   <see cref="P:System.Net.HttpWebRequest.Method" /> is GET or HEAD, and either <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater or equal to zero or <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="true" />.  
	/// -or-  
	/// <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> is <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> is <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is -1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> is <see langword="false" />, and <see cref="P:System.Net.HttpWebRequest.Method" /> is POST or PUT.  
	/// -or-  
	/// The <see cref="T:System.Net.HttpWebRequest" /> has an entity body but the <see cref="M:System.Net.HttpWebRequest.GetResponse" /> method is called without calling the <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> method.  
	/// -or-  
	/// The <see cref="P:System.Net.HttpWebRequest.ContentLength" /> is greater than zero, but the application does not write all of the promised data.</exception>
	/// <exception cref="T:System.NotSupportedException">The request cache validator indicated that the response for this request can be served from the cache; however, this request includes data to be sent to the server. Requests that send data must not use the cache. This exception can occur if you are using a custom cache validator that is incorrectly implemented.</exception>
	/// <exception cref="T:System.Net.WebException">
	///   <see cref="M:System.Net.HttpWebRequest.Abort" /> was previously called.  
	/// -or-  
	/// The time-out period for the request expired.  
	/// -or-  
	/// An error occurred while processing the request.</exception>
	public override WebResponse GetResponse()
	{
		return null;
	}

	/// <summary>Cancels a request to an Internet resource.</summary>
	public override void Abort()
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data required to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private void CheckRequestStarted()
	{
	}

	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
	{
	}

	private void RewriteRedirectToGet()
	{
	}

	private bool Redirect(HttpStatusCode code, WebResponse response)
	{
		return false;
	}

	private string GetHeaders()
	{
		return null;
	}

	private void DoPreAuthenticate()
	{
	}

	internal byte[] GetRequestHeaders()
	{
		return null;
	}

	private (WebOperation, bool) HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
	{
		return default((WebOperation, bool));
	}

	private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
	{
		return false;
	}

	private (Task<BufferOffsetSize>, WebException) GetRewriteHandler(HttpWebResponse response, bool redirect)
	{
		return default((Task<BufferOffsetSize>, WebException));
	}

	private (bool, bool, Task<BufferOffsetSize>, WebException) CheckFinalStatus(HttpWebResponse response)
	{
		return default((bool, bool, Task<BufferOffsetSize>, WebException));
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.HttpWebRequest" /> class. This constructor is obsolete.</summary>
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public HttpWebRequest()
	{
	}
}
