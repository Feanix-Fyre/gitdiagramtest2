using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace System.Net;

/// <summary>Contains HTTP proxy settings for the <see cref="T:System.Net.WebRequest" /> class.</summary>
[Serializable]
public class WebProxy : IWebProxy, ISerializable
{
	private bool _UseRegistry;

	private bool _BypassOnLocal;

	private bool m_EnableAutoproxy;

	private Uri _ProxyAddress;

	private ArrayList _BypassList;

	private ICredentials _Credentials;

	private Regex[] _RegExBypassList;

	private Hashtable _ProxyHostAddresses;

	private AutoWebProxyScriptEngine m_ScriptEngine;

	/// <summary>Gets or sets the credentials to submit to the proxy server for authentication.</summary>
	/// <returns>An <see cref="T:System.Net.ICredentials" /> instance that contains the credentials to submit to the proxy server for authentication.</returns>
	/// <exception cref="T:System.InvalidOperationException">You attempted to set this property when the <see cref="P:System.Net.WebProxy.UseDefaultCredentials" /> property was set to <see langword="true" />.</exception>
	public ICredentials Credentials => null;

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether the <see cref="P:System.Net.CredentialCache.DefaultCredentials" /> are sent with requests.</summary>
	/// <returns>
	///   <see langword="true" /> if the default credentials are used; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">You attempted to set this property when the <see cref="P:System.Net.WebProxy.Credentials" /> property contains credentials other than the default credentials.</exception>
	public bool UseDefaultCredentials
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal AutoWebProxyScriptEngine ScriptEngine => null;

	/// <summary>Initializes an empty instance of the <see cref="T:System.Net.WebProxy" /> class.</summary>
	public WebProxy()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebProxy" /> class with the specified <see cref="T:System.Uri" /> instance, bypass setting, list of URIs to bypass, and credentials.</summary>
	/// <param name="Address">A <see cref="T:System.Uri" /> instance that contains the address of the proxy server.</param>
	/// <param name="BypassOnLocal">
	///   <see langword="true" /> to bypass the proxy for local addresses; otherwise, <see langword="false" />.</param>
	/// <param name="BypassList">An array of regular expression strings that contains the URIs of the servers to bypass.</param>
	/// <param name="Credentials">An <see cref="T:System.Net.ICredentials" /> instance to submit to the proxy server for authentication.</param>
	public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
	{
	}

	/// <summary>Returns the proxied URI for a request.</summary>
	/// <param name="destination">The <see cref="T:System.Uri" /> instance of the requested Internet resource.</param>
	/// <returns>The <see cref="T:System.Uri" /> instance of the Internet resource, if the resource is on the bypass list; otherwise, the <see cref="T:System.Uri" /> instance of the proxy.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="destination" /> parameter is <see langword="null" />.</exception>
	public Uri GetProxy(Uri destination)
	{
		return null;
	}

	private void UpdateRegExList(bool canThrow)
	{
	}

	private bool IsMatchInBypassList(Uri input)
	{
		return false;
	}

	private bool IsLocal(Uri host)
	{
		return false;
	}

	private bool IsLocalInProxyHash(Uri host)
	{
		return false;
	}

	/// <summary>Indicates whether to use the proxy server for the specified host.</summary>
	/// <param name="host">The <see cref="T:System.Uri" /> instance of the host to check for proxy use.</param>
	/// <returns>
	///   <see langword="true" /> if the proxy server should not be used for <paramref name="host" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="host" /> parameter is <see langword="null" />.</exception>
	public bool IsBypassed(Uri host)
	{
		return false;
	}

	private bool IsBypassedManual(Uri host)
	{
		return false;
	}

	/// <summary>Initializes an instance of the <see cref="T:System.Net.WebProxy" /> class using previously serialized content.</summary>
	/// <param name="serializationInfo">The serialization data.</param>
	/// <param name="streamingContext">The context for the serialized data.</param>
	protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Creates the serialization data and context that are used by the system to serialize a <see cref="T:System.Net.WebProxy" /> object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that indicates the destination for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data that is needed to serialize the target object.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	public static IWebProxy CreateDefaultProxy()
	{
		return null;
	}

	internal WebProxy(bool enableAutoproxy)
	{
	}

	internal void UnsafeUpdateFromRegistry()
	{
	}

	private bool GetProxyAuto(Uri destination, out Uri proxyUri)
	{
		proxyUri = null;
		return false;
	}

	private bool IsBypassedAuto(Uri destination, out bool isBypassed)
	{
		isBypassed = default(bool);
		return false;
	}

	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
	{
		return false;
	}

	private static Uri ProxyUri(string proxyName)
	{
		return null;
	}
}
