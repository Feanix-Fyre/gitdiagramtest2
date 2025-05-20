using System.Collections;
using System.Runtime.Serialization;

namespace System.Net;

/// <summary>Provides a set of properties and methods that are used to manage cookies. This class cannot be inherited.</summary>
[Serializable]
public sealed class Cookie
{
	internal static readonly char[] PortSplitDelimiters;

	internal static readonly char[] Reserved2Name;

	internal static readonly char[] Reserved2Value;

	private static Comparer staticComparer;

	private string m_comment;

	private Uri m_commentUri;

	private CookieVariant m_cookieVariant;

	private bool m_discard;

	private string m_domain;

	private bool m_domain_implicit;

	private DateTime m_expires;

	private string m_name;

	private string m_path;

	private bool m_path_implicit;

	private string m_port;

	private bool m_port_implicit;

	private int[] m_port_list;

	private bool m_secure;

	[OptionalField]
	private bool m_httpOnly;

	private DateTime m_timeStamp;

	private string m_value;

	private int m_version;

	private string m_domainKey;

	internal bool IsQuotedVersion;

	internal bool IsQuotedDomain;

	/// <summary>Gets or sets a comment that the server can add to a <see cref="T:System.Net.Cookie" />.</summary>
	/// <returns>An optional comment to document intended usage for this <see cref="T:System.Net.Cookie" />.</returns>
	public string Comment
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a URI comment that the server can provide with a <see cref="T:System.Net.Cookie" />.</summary>
	/// <returns>An optional comment that represents the intended usage of the URI reference for this <see cref="T:System.Net.Cookie" />. The value must conform to URI format.</returns>
	public Uri CommentUri
	{
		set
		{
		}
	}

	/// <summary>Determines whether a page script or other active content can access this cookie.</summary>
	/// <returns>Boolean value that determines whether a page script or other active content can access this cookie.</returns>
	public bool HttpOnly
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the discard flag set by the server.</summary>
	/// <returns>
	///   <see langword="true" /> if the client is to discard the <see cref="T:System.Net.Cookie" /> at the end of the current session; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool Discard
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the URI for which the <see cref="T:System.Net.Cookie" /> is valid.</summary>
	/// <returns>The URI for which the <see cref="T:System.Net.Cookie" /> is valid.</returns>
	public string Domain
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string _Domain => null;

	/// <summary>Gets or sets the current state of the <see cref="T:System.Net.Cookie" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Cookie" /> has expired; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool Expired => false;

	/// <summary>Gets or sets the expiration date and time for the <see cref="T:System.Net.Cookie" /> as a <see cref="T:System.DateTime" />.</summary>
	/// <returns>The expiration date and time for the <see cref="T:System.Net.Cookie" /> as a <see cref="T:System.DateTime" /> instance.</returns>
	public DateTime Expires
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the name for the <see cref="T:System.Net.Cookie" />.</summary>
	/// <returns>The name for the <see cref="T:System.Net.Cookie" />.</returns>
	/// <exception cref="T:System.Net.CookieException">The value specified for a set operation is <see langword="null" /> or the empty string  
	/// -or-
	///  The value specified for a set operation contained an illegal character. The following characters must not be used inside the <see cref="P:System.Net.Cookie.Name" /> property: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character.</exception>
	public string Name => null;

	/// <summary>Gets or sets the URIs to which the <see cref="T:System.Net.Cookie" /> applies.</summary>
	/// <returns>The URIs to which the <see cref="T:System.Net.Cookie" /> applies.</returns>
	public string Path
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string _Path => null;

	internal bool Plain => false;

	/// <summary>Gets or sets a list of TCP ports that the <see cref="T:System.Net.Cookie" /> applies to.</summary>
	/// <returns>The list of TCP ports that the <see cref="T:System.Net.Cookie" /> applies to.</returns>
	/// <exception cref="T:System.Net.CookieException">The value specified for a set operation could not be parsed or is not enclosed in double quotes.</exception>
	public string Port
	{
		set
		{
		}
	}

	internal int[] PortList => null;

	private string _Port => null;

	/// <summary>Gets or sets the security level of a <see cref="T:System.Net.Cookie" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the client is only to return the cookie in subsequent requests if those requests use Secure Hypertext Transfer Protocol (HTTPS); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool Secure
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="P:System.Net.Cookie.Value" /> for the <see cref="T:System.Net.Cookie" />.</summary>
	/// <returns>The <see cref="P:System.Net.Cookie.Value" /> for the <see cref="T:System.Net.Cookie" />.</returns>
	public string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal CookieVariant Variant => default(CookieVariant);

	internal string DomainKey => null;

	/// <summary>Gets or sets the version of HTTP state maintenance to which the cookie conforms.</summary>
	/// <returns>The version of HTTP state maintenance to which the cookie conforms.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a version is not allowed.</exception>
	public int Version
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private string _Version => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cookie" /> class.</summary>
	public Cookie()
	{
	}

	internal bool InternalSetName(string value)
	{
		return false;
	}

	private static bool IsDomainEqualToHost(string domain, string host)
	{
		return false;
	}

	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
	{
		return false;
	}

	private static bool DomainCharsTest(string name)
	{
		return false;
	}

	internal static IComparer GetComparer()
	{
		return null;
	}

	/// <summary>Overrides the <see cref="M:System.Object.Equals(System.Object)" /> method.</summary>
	/// <param name="comparand">A reference to a <see cref="T:System.Net.Cookie" />.</param>
	/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Net.Cookie" /> is equal to <paramref name="comparand" />. Two <see cref="T:System.Net.Cookie" /> instances are equal if their <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, <see cref="P:System.Net.Cookie.Domain" />, and <see cref="P:System.Net.Cookie.Version" /> properties are equal. <see cref="P:System.Net.Cookie.Name" /> and <see cref="P:System.Net.Cookie.Domain" /> string comparisons are case-insensitive.</returns>
	public override bool Equals(object comparand)
	{
		return false;
	}

	/// <summary>Overrides the <see cref="M:System.Object.GetHashCode" /> method.</summary>
	/// <returns>The 32-bit signed integer hash code for this instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Overrides the <see cref="M:System.Object.ToString" /> method.</summary>
	/// <returns>Returns a string representation of this <see cref="T:System.Net.Cookie" /> object that is suitable for including in a HTTP Cookie: request header.</returns>
	public override string ToString()
	{
		return null;
	}
}
