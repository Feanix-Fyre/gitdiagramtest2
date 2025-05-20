using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace System.Net;

/// <summary>Implements a File Transfer Protocol (FTP) client.</summary>
public sealed class FtpWebRequest : WebRequest
{
	private enum RequestStage
	{
		CheckForError = 0,
		RequestStarted = 1,
		WriteReady = 2,
		ReadReady = 3,
		ReleaseConnection = 4
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCreateConnectionAsync_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FtpWebRequest _003C_003E4__this;

		private TcpClient _003Cclient_003E5__2;

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

	private object _syncObject;

	private ICredentials _authInfo;

	private readonly Uri _uri;

	private FtpMethodInfo _methodInfo;

	private string _renameTo;

	private bool _getRequestStreamStarted;

	private bool _getResponseStarted;

	private DateTime _startTime;

	private int _timeout;

	private int _remainingTimeout;

	private long _contentLength;

	private long _contentOffset;

	private X509CertificateCollection _clientCertificates;

	private bool _passive;

	private bool _binary;

	private string _connectionGroupName;

	private bool _async;

	private bool _aborted;

	private bool _timedOut;

	private Exception _exception;

	private TimerThread.Queue _timerQueue;

	private TimerThread.Callback _timerCallback;

	private bool _enableSsl;

	private FtpControlStream _connection;

	private Stream _stream;

	private RequestStage _requestStage;

	private bool _onceFailed;

	private WebHeaderCollection _ftpRequestHeaders;

	private FtpWebResponse _ftpWebResponse;

	private int _readWriteTimeout;

	private ContextAwareResult _writeAsyncResult;

	private LazyAsyncResult _readAsyncResult;

	private LazyAsyncResult _requestCompleteAsyncResult;

	private static readonly NetworkCredential s_defaultFtpNetworkCredential;

	private static readonly TimerThread.Queue s_DefaultTimerQueue;

	internal FtpMethodInfo MethodInfo => null;

	/// <summary>Gets or sets the command to send to the FTP server.</summary>
	/// <returns>A <see cref="T:System.String" /> value that contains the FTP command to send to the server. The default value is <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
	/// <exception cref="T:System.ArgumentException">The method is invalid.  
	/// -or-
	///  The method is not supported.  
	/// -or-
	///  Multiple methods were specified.</exception>
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

	/// <summary>Gets or sets the new name of a file being renamed.</summary>
	/// <returns>The new name of the file being renamed.</returns>
	/// <exception cref="T:System.ArgumentException">The value specified for a set operation is <see langword="null" /> or an empty string.</exception>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
	public string RenameTo => null;

	/// <summary>Gets or sets the credentials used to communicate with the FTP server.</summary>
	/// <returns>An <see cref="T:System.Net.ICredentials" /> instance; otherwise, <see langword="null" /> if the property has not been set.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">An <see cref="T:System.Net.ICredentials" /> of a type other than <see cref="T:System.Net.NetworkCredential" /> was specified for a set operation.</exception>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
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

	/// <summary>Gets the URI requested by this instance.</summary>
	/// <returns>A <see cref="T:System.Uri" /> instance that identifies a resource that is accessed using the File Transfer Protocol.</returns>
	public override Uri RequestUri => null;

	/// <summary>Gets or sets the number of milliseconds to wait for a request.</summary>
	/// <returns>An <see cref="T:System.Int32" /> value that contains the number of milliseconds to wait before a request times out. The default value is <see cref="F:System.Threading.Timeout.Infinite" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than zero and is not <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
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

	internal int RemainingTimeout => 0;

	/// <summary>Gets or sets a time-out when reading from or writing to a stream.</summary>
	/// <returns>The number of milliseconds before the reading or writing times out. The default value is 300,000 milliseconds (5 minutes).</returns>
	/// <exception cref="T:System.InvalidOperationException">The request has already been sent.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than or equal to zero and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	public int ReadWriteTimeout => 0;

	/// <summary>Gets or sets a byte offset into the file being downloaded by this request.</summary>
	/// <returns>An <see cref="T:System.Int64" /> instance that specifies the file offset, in bytes. The default value is zero.</returns>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for this property is less than zero.</exception>
	public long ContentOffset => 0L;

	/// <summary>Gets or sets a value that is ignored by the <see cref="T:System.Net.FtpWebRequest" /> class.</summary>
	/// <returns>An <see cref="T:System.Int64" /> value that should be ignored.</returns>
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

	/// <summary>Gets or sets the proxy used to communicate with the FTP server.</summary>
	/// <returns>An <see cref="T:System.Net.IWebProxy" /> instance responsible for communicating with the FTP server. On .NET Core, its value is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">This property cannot be set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
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

	/// <summary>Gets or sets the name of the connection group that contains the service point used to send the current request.</summary>
	/// <returns>A <see cref="T:System.String" /> value that contains a connection group name.</returns>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
	public override string ConnectionGroupName
	{
		set
		{
		}
	}

	internal bool Aborted => false;

	private TimerThread.Queue TimerQueue => null;

	public override RequestCachePolicy CachePolicy
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies the data type for file transfers.</summary>
	/// <returns>
	///   <see langword="true" /> to indicate to the server that the data to be transferred is binary; <see langword="false" /> to indicate that the data is text. The default value is <see langword="true" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
	public bool UseBinary => false;

	/// <summary>Gets or sets the behavior of a client application's data transfer process.</summary>
	/// <returns>
	///   <see langword="false" /> if the client application's data transfer process listens for a connection on the data port; otherwise, <see langword="true" /> if the client should initiate a connection on the data port. The default value is <see langword="true" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">A new value was specified for this property for a request that is already in progress.</exception>
	public bool UsePassive => false;

	/// <summary>Gets or sets the certificates used for establishing an encrypted connection to the FTP server.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> object that contains the client certificates.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value specified for a set operation is <see langword="null" />.</exception>
	public X509CertificateCollection ClientCertificates => null;

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> that specifies that an SSL connection should be used.</summary>
	/// <returns>
	///   <see langword="true" /> if control and data transmissions are encrypted; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The connection to the FTP server has already been established.</exception>
	public bool EnableSsl => false;

	/// <summary>Gets an empty <see cref="T:System.Net.WebHeaderCollection" /> object.</summary>
	/// <returns>An empty <see cref="T:System.Net.WebHeaderCollection" /> object.</returns>
	public override WebHeaderCollection Headers => null;

	/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
	/// <exception cref="T:System.NotSupportedException">Default credentials are not supported for FTP.</exception>
	public override bool UseDefaultCredentials => false;

	/// <summary>Always throws a <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
	/// <exception cref="T:System.NotSupportedException">Preauthentication is not supported for FTP.</exception>
	public override bool PreAuthenticate
	{
		set
		{
		}
	}

	private bool InUse => false;

	internal FtpWebRequest(Uri uri)
	{
	}

	/// <summary>Returns the FTP server response.</summary>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> reference that contains an <see cref="T:System.Net.FtpWebResponse" /> instance. This object contains the FTP server's response to the request.</returns>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.FtpWebRequest.GetResponse" /> or <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> has already been called for this instance.  
	/// -or-
	///  An HTTP proxy is enabled, and you attempted to use an FTP command other than <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />, <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectory" />, or <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectoryDetails" />.</exception>
	/// <exception cref="T:System.Net.WebException">
	///   <see cref="P:System.Net.FtpWebRequest.EnableSsl" /> is set to <see langword="true" />, but the server does not support this feature.  
	/// -or-
	///  A <see cref="P:System.Net.FtpWebRequest.Timeout" /> was specified and the timeout has expired.</exception>
	public override WebResponse GetResponse()
	{
		return null;
	}

	/// <summary>Begins sending a request and receiving a response from an FTP server asynchronously.</summary>
	/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
	/// <param name="state">A user-defined object that contains information about the operation. This object is passed to the <paramref name="callback" /> delegate when the operation completes.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> instance that indicates the status of the operation.</returns>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Net.FtpWebRequest.GetResponse" /> or <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> has already been called for this instance.</exception>
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends a pending asynchronous operation started with <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</summary>
	/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> that was returned when the operation started.</param>
	/// <returns>A <see cref="T:System.Net.WebResponse" /> reference that contains an <see cref="T:System.Net.FtpWebResponse" /> instance. This object contains the FTP server's response to the request.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not obtained by calling <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">This method was already called for the operation identified by <paramref name="asyncResult" />.</exception>
	/// <exception cref="T:System.Net.WebException">An error occurred using an HTTP proxy.</exception>
	public override WebResponse EndGetResponse(IAsyncResult asyncResult)
	{
		return null;
	}

	/// <summary>Begins asynchronously opening a request's content stream for writing.</summary>
	/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
	/// <param name="state">A user-defined object that contains information about the operation. This object is passed to the <paramref name="callback" /> delegate when the operation completes.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> instance that indicates the status of the operation.</returns>
	/// <exception cref="T:System.InvalidOperationException">A previous call to this method or <see cref="M:System.Net.FtpWebRequest.GetRequestStream" /> has not yet completed.</exception>
	/// <exception cref="T:System.Net.WebException">A connection to the FTP server could not be established.</exception>
	/// <exception cref="T:System.Net.ProtocolViolationException">The <see cref="P:System.Net.FtpWebRequest.Method" /> property is not set to <see cref="F:System.Net.WebRequestMethods.Ftp.UploadFile" />.</exception>
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
	{
		return null;
	}

	/// <summary>Ends a pending asynchronous operation started with <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</summary>
	/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> object that was returned when the operation started.</param>
	/// <returns>A writable <see cref="T:System.IO.Stream" /> instance associated with this instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asyncResult" /> was not obtained by calling <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">This method was already called for the operation identified by <paramref name="asyncResult" />.</exception>
	public override Stream EndGetRequestStream(IAsyncResult asyncResult)
	{
		return null;
	}

	private void SubmitRequest(bool isAsync)
	{
	}

	private Exception TranslateConnectException(Exception e)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCreateConnectionAsync_003Ed__86))]
	private void CreateConnectionAsync()
	{
	}

	private FtpControlStream CreateConnection()
	{
		return null;
	}

	private Stream TimedSubmitRequestHelper(bool isAsync)
	{
		return null;
	}

	private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context)
	{
	}

	private bool AttemptedRecovery(Exception e)
	{
		return false;
	}

	private void SetException(Exception exception)
	{
	}

	private void CheckError()
	{
	}

	internal void RequestCallback(object obj)
	{
	}

	private void SyncRequestCallback(object obj)
	{
	}

	private void AsyncRequestCallback(object obj)
	{
	}

	private RequestStage FinishRequestStage(RequestStage stage)
	{
		return default(RequestStage);
	}

	/// <summary>Terminates an asynchronous FTP operation.</summary>
	public override void Abort()
	{
	}

	private void EnsureFtpWebResponse(Exception exception)
	{
	}

	internal void DataStreamClosed(CloseExState closeState)
	{
	}
}
