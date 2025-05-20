using System.IO;
using System.Net.Sockets;
using System.Text;

namespace System.Net;

internal class FtpControlStream : CommandStream
{
	private enum GetPathOption
	{
		Normal = 0,
		AssumeFilename = 1,
		AssumeNoFilename = 2
	}

	private Socket _dataSocket;

	private IPEndPoint _passiveEndPoint;

	private TlsStream _tlsStream;

	private StringBuilder _bannerMessage;

	private StringBuilder _welcomeMessage;

	private StringBuilder _exitMessage;

	private WeakReference _credentials;

	private string _currentTypeSetting;

	private long _contentLength;

	private DateTime _lastModified;

	private bool _dataHandshakeStarted;

	private string _loginDirectory;

	private string _establishedServerDirectory;

	private string _requestedServerDirectory;

	private Uri _responseUri;

	private FtpLoginState _loginState;

	internal FtpStatusCode StatusCode;

	internal string StatusLine;

	private static readonly AsyncCallback s_acceptCallbackDelegate;

	private static readonly AsyncCallback s_connectCallbackDelegate;

	private static readonly AsyncCallback s_SSLHandshakeCallback;

	internal NetworkCredential Credentials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal long ContentLength => 0L;

	internal DateTime LastModified => default(DateTime);

	internal Uri ResponseUri => null;

	internal string BannerMessage => null;

	internal string WelcomeMessage => null;

	internal string ExitMessage => null;

	internal FtpControlStream(TcpClient client)
		: base(null)
	{
	}

	internal void AbortConnect()
	{
	}

	private static void AcceptCallback(IAsyncResult asyncResult)
	{
	}

	private static void ConnectCallback(IAsyncResult asyncResult)
	{
	}

	private static void SSLHandshakeCallback(IAsyncResult asyncResult)
	{
	}

	private PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream)
	{
		return default(PipelineInstruction);
	}

	protected override void ClearState()
	{
	}

	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
	{
		return default(PipelineInstruction);
	}

	protected override PipelineEntry[] BuildCommandsList(WebRequest req)
	{
		return null;
	}

	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady)
	{
		isSocketReady = default(bool);
		return default(PipelineInstruction);
	}

	private static void GetPathInfo(GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename)
	{
		path = null;
		directory = null;
		filename = null;
	}

	private string FormatAddress(IPAddress address, int Port)
	{
		return null;
	}

	private string FormatAddressV6(IPAddress address, int port)
	{
		return null;
	}

	private long GetContentLengthFrom213Response(string responseString)
	{
		return 0L;
	}

	private DateTime GetLastModifiedFrom213Response(string str)
	{
		return default(DateTime);
	}

	private void TryUpdateResponseUri(string str, FtpWebRequest request)
	{
	}

	private void TryUpdateContentLength(string str)
	{
	}

	private string GetLoginDirectory(string str)
	{
		return null;
	}

	private int GetPortV4(string responseString)
	{
		return 0;
	}

	private int GetPortV6(string responseString)
	{
		return 0;
	}

	private void CreateFtpListenerSocket(FtpWebRequest request)
	{
	}

	private string GetPortCommandLine(FtpWebRequest request)
	{
		return null;
	}

	private string FormatFtpCommand(string command, string parameter)
	{
		return null;
	}

	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket)
	{
		return null;
	}

	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
	{
		return false;
	}

	private TriState IsFtpDataStreamWriteable()
	{
		return default(TriState);
	}
}
