using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable
{
	internal enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4
	}

	internal enum UnityWebRequestError
	{
		OK = 0,
		OKCached = 1,
		Unknown = 2,
		SDKError = 3,
		UnsupportedProtocol = 4,
		MalformattedUrl = 5,
		CannotResolveProxy = 6,
		CannotResolveHost = 7,
		CannotConnectToHost = 8,
		AccessDenied = 9,
		GenericHttpError = 10,
		WriteError = 11,
		ReadError = 12,
		OutOfMemory = 13,
		Timeout = 14,
		HTTPPostError = 15,
		SSLCannotConnect = 16,
		Aborted = 17,
		TooManyRedirects = 18,
		ReceivedNoData = 19,
		SSLNotSupported = 20,
		FailedToSendData = 21,
		FailedToReceiveData = 22,
		SSLCertificateError = 23,
		SSLCipherNotAvailable = 24,
		SSLCACertError = 25,
		UnrecognizedContentEncoding = 26,
		LoginFailed = 27,
		SSLShutdownFailed = 28,
		RedirectLimitInvalid = 29,
		InvalidRedirect = 30,
		CannotModifyRequest = 31,
		HeaderNameContainsInvalidCharacters = 32,
		HeaderValueContainsInvalidCharacters = 33,
		CannotOverrideSystemHeaders = 34,
		AlreadySent = 35,
		InvalidMethod = 36,
		NotImplemented = 37,
		NoInternetConnection = 38,
		DataProcessingError = 39,
		InsecureConnectionNotAllowed = 40
	}

	public enum Result
	{
		InProgress = 0,
		Success = 1,
		ConnectionError = 2,
		ProtocolError = 3,
		DataProcessingError = 4
	}

	[NonSerialized]
	internal IntPtr m_Ptr;

	[NonSerialized]
	internal DownloadHandler m_DownloadHandler;

	[NonSerialized]
	internal UploadHandler m_UploadHandler;

	[NonSerialized]
	internal CertificateHandler m_CertificateHandler;

	[NonSerialized]
	internal Uri m_Uri;

	public const string kHttpVerbGET = "GET";

	public const string kHttpVerbHEAD = "HEAD";

	public const string kHttpVerbPOST = "POST";

	public const string kHttpVerbPUT = "PUT";

	public const string kHttpVerbCREATE = "CREATE";

	public const string kHttpVerbDELETE = "DELETE";

	public bool disposeCertificateHandlerOnDispose { get; set; }

	public bool disposeDownloadHandlerOnDispose { get; set; }

	public bool disposeUploadHandlerOnDispose { get; set; }

	public string method
	{
		set
		{
		}
	}

	public string error => null;

	public string url
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long responseCode => 0L;

	public bool isModifiable
	{
		[NativeMethod("IsModifiable")]
		get
		{
			return false;
		}
	}

	public bool isDone => false;

	public Result result
	{
		[NativeMethod("GetResult")]
		get
		{
			return default(Result);
		}
	}

	[Obsolete("HTTP/2 and many HTTP/1.1 servers don't support this; we recommend leaving it set to false (default).", false)]
	public bool chunkedTransfer
	{
		set
		{
		}
	}

	public UploadHandler uploadHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DownloadHandler downloadHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CertificateHandler certificateHandler => null;

	[NativeMethod(IsThreadSafe = true)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	private static string GetWebErrorString(UnityWebRequestError err)
	{
		return null;
	}

	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode)
	{
		return null;
	}

	[NativeThrows]
	internal static IntPtr Create()
	{
		return (IntPtr)0;
	}

	[NativeMethod(IsThreadSafe = true)]
	private void Release()
	{
	}

	internal void InternalDestroy()
	{
	}

	private void InternalSetDefaults()
	{
	}

	public UnityWebRequest(string url, string method)
	{
	}

	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
	{
	}

	~UnityWebRequest()
	{
	}

	public void Dispose()
	{
	}

	private void DisposeHandlers()
	{
	}

	[NativeThrows]
	internal UnityWebRequestAsyncOperation BeginWebRequest()
	{
		return null;
	}

	public UnityWebRequestAsyncOperation SendWebRequest()
	{
		return null;
	}

	[NativeMethod(IsThreadSafe = true)]
	public void Abort()
	{
	}

	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType)
	{
		return default(UnityWebRequestError);
	}

	internal void InternalSetMethod(UnityWebRequestMethod methodType)
	{
	}

	private UnityWebRequestError SetCustomMethod(string customMethodName)
	{
		return default(UnityWebRequestError);
	}

	internal void InternalSetCustomMethod(string customMethodName)
	{
	}

	private UnityWebRequestError GetError()
	{
		return default(UnityWebRequestError);
	}

	private string GetUrl()
	{
		return null;
	}

	private UnityWebRequestError SetUrl(string url)
	{
		return default(UnityWebRequestError);
	}

	private void InternalSetUrl(string url)
	{
	}

	private UnityWebRequestError SetChunked(bool chunked)
	{
		return default(UnityWebRequestError);
	}

	[NativeMethod("SetRequestHeader")]
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value)
	{
		return default(UnityWebRequestError);
	}

	public void SetRequestHeader(string name, string value)
	{
	}

	private UnityWebRequestError SetUploadHandler(UploadHandler uh)
	{
		return default(UnityWebRequestError);
	}

	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
	{
		return default(UnityWebRequestError);
	}

	public static UnityWebRequest Get(string uri)
	{
		return null;
	}

	public static UnityWebRequest Post(string uri, WWWForm formData)
	{
		return null;
	}

	private static void SetupPost(UnityWebRequest request, WWWForm formData)
	{
	}
}
