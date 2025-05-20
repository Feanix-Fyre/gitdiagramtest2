using System.Collections.Concurrent;
using System.Net.Security;

namespace System.Net;

/// <summary>Manages the collection of <see cref="T:System.Net.ServicePoint" /> objects.</summary>
public class ServicePointManager
{
	internal class SPKey
	{
		private Uri uri;

		private Uri proxy;

		private bool use_connect;

		public bool UsesProxy => false;

		public SPKey(Uri uri, Uri proxy, bool use_connect)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}

	private static ConcurrentDictionary<SPKey, ServicePoint> servicePoints;

	private static ICertificatePolicy policy;

	private static int defaultConnectionLimit;

	private static int maxServicePointIdleTime;

	private static int maxServicePoints;

	private static int dnsRefreshTimeout;

	private static bool _checkCRL;

	private static SecurityProtocolType _securityProtocol;

	private static bool expectContinue;

	private static bool useNagle;

	private static ServerCertValidationCallback server_cert_cb;

	private static bool tcp_keepalive;

	private static int tcp_keepalive_time;

	private static int tcp_keepalive_interval;

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that indicates whether the certificate is checked against the certificate authority revocation list.</summary>
	/// <returns>
	///   <see langword="true" /> if the certificate revocation list is checked; otherwise, <see langword="false" />.</returns>
	[System.MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList => false;

	/// <summary>Gets or sets a value that indicates how long a Domain Name Service (DNS) resolution is considered valid.</summary>
	/// <returns>The time-out value, in milliseconds. A value of -1 indicates an infinite time-out period. The default value is 120,000 milliseconds (two minutes).</returns>
	public static int DnsRefreshTimeout => 0;

	/// <summary>Gets or sets the security protocol used by the <see cref="T:System.Net.ServicePoint" /> objects managed by the <see cref="T:System.Net.ServicePointManager" /> object.</summary>
	/// <returns>One of the values defined in the <see cref="T:System.Net.SecurityProtocolType" /> enumeration.</returns>
	/// <exception cref="T:System.NotSupportedException">The value specified to set the property is not a valid <see cref="T:System.Net.SecurityProtocolType" /> enumeration value.</exception>
	public static SecurityProtocolType SecurityProtocol => default(SecurityProtocolType);

	internal static ServerCertValidationCallback ServerCertValidationCallback => null;

	/// <summary>Gets or sets the callback to validate a server certificate.</summary>
	/// <returns>A <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" />. The default value is <see langword="null" />.</returns>
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	static ServicePointManager()
	{
	}

	internal static ICertificatePolicy GetLegacyCertificatePolicy()
	{
		return null;
	}

	/// <summary>Finds an existing <see cref="T:System.Net.ServicePoint" /> object or creates a new <see cref="T:System.Net.ServicePoint" /> object to manage communications with the specified <see cref="T:System.Uri" /> object.</summary>
	/// <param name="address">A <see cref="T:System.Uri" /> object that contains the address of the Internet resource to contact.</param>
	/// <param name="proxy">The proxy data for this request.</param>
	/// <returns>The <see cref="T:System.Net.ServicePoint" /> object that manages communications for the request.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="address" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The maximum number of <see cref="T:System.Net.ServicePoint" /> objects defined in <see cref="P:System.Net.ServicePointManager.MaxServicePoints" /> has been reached.</exception>
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
	{
		return null;
	}

	internal static void CloseConnectionGroup(string connectionGroupName)
	{
	}

	internal static void RemoveServicePoint(ServicePoint sp)
	{
	}
}
