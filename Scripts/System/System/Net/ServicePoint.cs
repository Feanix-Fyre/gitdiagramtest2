using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace System.Net;

/// <summary>Provides connection management for HTTP connections.</summary>
public class ServicePoint
{
	private readonly Uri uri;

	private DateTime lastDnsResolve;

	private Version protocolVersion;

	private IPHostEntry host;

	private bool usesProxy;

	private bool sendContinue;

	private bool useConnect;

	private object hostE;

	private bool useNagle;

	private BindIPEndPoint endPointCallback;

	private bool tcp_keepalive;

	private int tcp_keepalive_time;

	private int tcp_keepalive_interval;

	private bool disposed;

	private int connectionLeaseTimeout;

	private int receiveBufferSize;

	private int connectionLimit;

	private int maxIdleTime;

	private object m_ServerCertificateOrBytes;

	private object m_ClientCertificateOrBytes;

	internal ServicePointManager.SPKey Key { get; }

	private ServicePointScheduler Scheduler { get; set; }

	/// <summary>Gets the Uniform Resource Identifier (URI) of the server that this <see cref="T:System.Net.ServicePoint" /> object connects to.</summary>
	/// <returns>An instance of the <see cref="T:System.Uri" /> class that contains the URI of the Internet server that this <see cref="T:System.Net.ServicePoint" /> object connects to.</returns>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Net.ServicePoint" /> is in host mode.</exception>
	public Uri Address => null;

	/// <summary>Gets or sets the maximum number of connections allowed on this <see cref="T:System.Net.ServicePoint" /> object.</summary>
	/// <returns>The maximum number of connections allowed on this <see cref="T:System.Net.ServicePoint" /> object.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The connection limit is equal to or less than 0.</exception>
	public int ConnectionLimit => 0;

	/// <summary>Gets the version of the HTTP protocol that the <see cref="T:System.Net.ServicePoint" /> object uses.</summary>
	/// <returns>A <see cref="T:System.Version" /> object that contains the HTTP protocol version that the <see cref="T:System.Net.ServicePoint" /> object uses.</returns>
	public virtual Version ProtocolVersion => null;

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether 100-Continue behavior is used.</summary>
	/// <returns>
	///   <see langword="true" /> to expect 100-Continue responses for <see langword="POST" /> requests; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	public bool Expect100Continue
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether the Nagle algorithm is used on connections managed by this <see cref="T:System.Net.ServicePoint" /> object.</summary>
	/// <returns>
	///   <see langword="true" /> to use the Nagle algorithm; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	public bool UseNagleAlgorithm
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool SendContinue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool UsesProxy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool UseConnect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool HasTimedOut => false;

	internal IPHostEntry HostEntry => null;

	internal ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
	{
	}

	/// <summary>Enables or disables the keep-alive option on a TCP connection.</summary>
	/// <param name="enabled">If set to true, then the TCP keep-alive option on a TCP connection will be enabled using the specified <paramref name="keepAliveTime" /> and <paramref name="keepAliveInterval" /> values.  
	///  If set to false, then the TCP keep-alive option is disabled and the remaining parameters are ignored.  
	///  The default value is false.</param>
	/// <param name="keepAliveTime">Specifies the timeout, in milliseconds, with no activity until the first keep-alive packet is sent.  
	///  The value must be greater than 0.  If a value of less than or equal to zero is passed an <see cref="T:System.ArgumentOutOfRangeException" /> is thrown.</param>
	/// <param name="keepAliveInterval">Specifies the interval, in milliseconds, between when successive keep-alive packets are sent if no acknowledgement is received.  
	///  The value must be greater than 0.  If a value of less than or equal to zero is passed an <see cref="T:System.ArgumentOutOfRangeException" /> is thrown.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for <paramref name="keepAliveTime" /> or <paramref name="keepAliveInterval" /> parameter is less than or equal to 0.</exception>
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
	{
	}

	internal void KeepAliveSetup(Socket socket)
	{
	}

	private static void PutBytes(byte[] bytes, uint v, int offset)
	{
	}

	internal void SetVersion(Version version)
	{
	}

	internal void SendRequest(WebOperation operation, string groupName)
	{
	}

	/// <summary>Removes the specified connection group from this <see cref="T:System.Net.ServicePoint" /> object.</summary>
	/// <param name="connectionGroupName">The name of the connection group that contains the connections to close and remove from this service point.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that indicates whether the connection group was closed.</returns>
	public bool CloseConnectionGroup(string connectionGroupName)
	{
		return false;
	}

	internal void FreeServicePoint()
	{
	}

	internal void UpdateServerCertificate(X509Certificate certificate)
	{
	}

	internal void UpdateClientCertificate(X509Certificate certificate)
	{
	}

	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
	{
		return false;
	}
}
