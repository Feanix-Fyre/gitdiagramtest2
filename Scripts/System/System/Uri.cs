using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI.</summary>
[Serializable]
[TypeConverter(typeof(UriTypeConverter))]
public class Uri : ISerializable
{
	[Flags]
	private enum Flags : ulong
	{
		Zero = 0uL,
		SchemeNotCanonical = 1uL,
		UserNotCanonical = 2uL,
		HostNotCanonical = 4uL,
		PortNotCanonical = 8uL,
		PathNotCanonical = 0x10uL,
		QueryNotCanonical = 0x20uL,
		FragmentNotCanonical = 0x40uL,
		CannotDisplayCanonical = 0x7FuL,
		E_UserNotCanonical = 0x80uL,
		E_HostNotCanonical = 0x100uL,
		E_PortNotCanonical = 0x200uL,
		E_PathNotCanonical = 0x400uL,
		E_QueryNotCanonical = 0x800uL,
		E_FragmentNotCanonical = 0x1000uL,
		E_CannotDisplayCanonical = 0x1F80uL,
		ShouldBeCompressed = 0x2000uL,
		FirstSlashAbsent = 0x4000uL,
		BackslashInPath = 0x8000uL,
		IndexMask = 0xFFFFuL,
		HostTypeMask = 0x70000uL,
		HostNotParsed = 0uL,
		IPv6HostType = 0x10000uL,
		IPv4HostType = 0x20000uL,
		DnsHostType = 0x30000uL,
		UncHostType = 0x40000uL,
		BasicHostType = 0x50000uL,
		UnusedHostType = 0x60000uL,
		UnknownHostType = 0x70000uL,
		UserEscaped = 0x80000uL,
		AuthorityFound = 0x100000uL,
		HasUserInfo = 0x200000uL,
		LoopbackHost = 0x400000uL,
		NotDefaultPort = 0x800000uL,
		UserDrivenParsing = 0x1000000uL,
		CanonicalDnsHost = 0x2000000uL,
		ErrorOrParsingRecursion = 0x4000000uL,
		DosPath = 0x8000000uL,
		UncPath = 0x10000000uL,
		ImplicitFile = 0x20000000uL,
		MinimalUriInfoSet = 0x40000000uL,
		AllUriInfoSet = 0x80000000uL,
		IdnHost = 0x100000000uL,
		HasUnicode = 0x200000000uL,
		HostUnicodeNormalized = 0x400000000uL,
		RestUnicodeNormalized = 0x800000000uL,
		UnicodeHost = 0x1000000000uL,
		IntranetUri = 0x2000000000uL,
		UseOrigUncdStrOffset = 0x4000000000uL,
		UserIriCanonical = 0x8000000000uL,
		PathIriCanonical = 0x10000000000uL,
		QueryIriCanonical = 0x20000000000uL,
		FragmentIriCanonical = 0x40000000000uL,
		IriCanonical = 0x78000000000uL,
		CompressedSlashes = 0x100000000000uL
	}

	private class UriInfo
	{
		public string Host;

		public string ScopeId;

		public string String;

		public Offset Offset;

		public string DnsSafeHost;

		public MoreInfo MoreInfo;
	}

	[StructLayout((LayoutKind)0, Pack = 1, Size = 16)]
	private struct Offset
	{
		public ushort Scheme;

		public ushort User;

		public ushort Host;

		public ushort PortValue;

		public ushort Path;

		public ushort Query;

		public ushort Fragment;

		public ushort End;
	}

	private class MoreInfo
	{
		public string Path;

		public string Query;

		public string Fragment;

		public string AbsoluteUri;

		public int Hash;

		public string RemoteUrl;
	}

	[Flags]
	private enum Check
	{
		None = 0,
		EscapedCanonical = 1,
		DisplayCanonical = 2,
		DotSlashAttn = 4,
		DotSlashEscaped = 0x80,
		BackslashInPath = 0x10,
		ReservedFound = 0x20,
		NotIriCanonical = 0x40,
		FoundNonAscii = 8
	}

	/// <summary>Specifies that the URI is a pointer to a file. This field is read-only.</summary>
	public static readonly string UriSchemeFile;

	/// <summary>Specifies that the URI is accessed through the File Transfer Protocol (FTP). This field is read-only.</summary>
	public static readonly string UriSchemeFtp;

	/// <summary>Specifies that the URI is accessed through the Gopher protocol. This field is read-only.</summary>
	public static readonly string UriSchemeGopher;

	/// <summary>Specifies that the URI is accessed through the Hypertext Transfer Protocol (HTTP). This field is read-only.</summary>
	public static readonly string UriSchemeHttp;

	/// <summary>Specifies that the URI is accessed through the Secure Hypertext Transfer Protocol (HTTPS). This field is read-only.</summary>
	public static readonly string UriSchemeHttps;

	internal static readonly string UriSchemeWs;

	internal static readonly string UriSchemeWss;

	/// <summary>Specifies that the URI is an email address and is accessed through the Simple Mail Transport Protocol (SMTP). This field is read-only.</summary>
	public static readonly string UriSchemeMailto;

	/// <summary>Specifies that the URI is an Internet news group and is accessed through the Network News Transport Protocol (NNTP). This field is read-only.</summary>
	public static readonly string UriSchemeNews;

	/// <summary>Specifies that the URI is an Internet news group and is accessed through the Network News Transport Protocol (NNTP). This field is read-only.</summary>
	public static readonly string UriSchemeNntp;

	/// <summary>Specifies that the URI is accessed through the NetTcp scheme used by Windows Communication Foundation (WCF). This field is read-only.</summary>
	public static readonly string UriSchemeNetTcp;

	/// <summary>Specifies that the URI is accessed through the NetPipe scheme used by Windows Communication Foundation (WCF). This field is read-only.</summary>
	public static readonly string UriSchemeNetPipe;

	/// <summary>Specifies the characters that separate the communication protocol scheme from the address portion of the URI. This field is read-only.</summary>
	public static readonly string SchemeDelimiter;

	private const int c_Max16BitUtf8SequenceLength = 12;

	internal const int c_MaxUriBufferSize = 65520;

	private const int c_MaxUriSchemeName = 1024;

	private string m_String;

	private string m_originalUnicodeString;

	private UriParser m_Syntax;

	private string m_DnsSafeHost;

	private Flags m_Flags;

	private UriInfo m_Info;

	private bool m_iriParsing;

	private static bool s_ConfigInitialized;

	private static bool s_ConfigInitializing;

	private static UriIdnScope s_IdnScope;

	private static bool s_IriParsing;

	private static bool useDotNetRelativeOrAbsolute;

	private const UriKind DotNetRelativeOrAbsolute = (UriKind)300;

	internal static readonly bool IsWindowsFileSystem;

	private static object s_initLock;

	private const UriFormat V1ToStringUnescape = (UriFormat)32767;

	internal const char c_DummyChar = '\uffff';

	internal const char c_EOL = '\ufffe';

	internal static readonly char[] HexLowerChars;

	private static readonly char[] _WSchars;

	private bool IsImplicitFile => false;

	private bool IsUncOrDosPath => false;

	private bool IsDosPath => false;

	private bool IsUncPath => false;

	private Flags HostType => default(Flags);

	private UriParser Syntax => null;

	private bool IsNotAbsoluteUri => false;

	private bool AllowIdn => false;

	internal bool UserDrivenParsing => false;

	private ushort SecuredPathIndex => 0;

	/// <summary>Gets the absolute path of the URI.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the absolute path to the resource.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string AbsolutePath => null;

	private string PrivateAbsolutePath => null;

	/// <summary>Gets the absolute URI.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the entire URI.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string AbsoluteUri => null;

	/// <summary>Gets a local operating-system representation of a file name.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the local operating-system representation of a file name.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string LocalPath => null;

	/// <summary>Gets the Domain Name System (DNS) host name or IP address and the port number for a server.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the authority component of the URI represented by this instance.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string Authority => null;

	/// <summary>Gets the type of the host name specified in the URI.</summary>
	/// <returns>A member of the <see cref="T:System.UriHostNameType" /> enumeration.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public UriHostNameType HostNameType => default(UriHostNameType);

	/// <summary>Gets whether the port value of the URI is the default for this scheme.</summary>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the value in the <see cref="P:System.Uri.Port" /> property is the default port for this scheme; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public bool IsDefaultPort => false;

	/// <summary>Gets a value indicating whether the specified <see cref="T:System.Uri" /> is a file URI.</summary>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <see cref="T:System.Uri" /> is a file URI; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public bool IsFile => false;

	/// <summary>Gets whether the specified <see cref="T:System.Uri" /> references the local host.</summary>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if this <see cref="T:System.Uri" /> references the local host; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public bool IsLoopback => false;

	/// <summary>Gets the <see cref="P:System.Uri.AbsolutePath" /> and <see cref="P:System.Uri.Query" /> properties separated by a question mark (?).</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the <see cref="P:System.Uri.AbsolutePath" /> and <see cref="P:System.Uri.Query" /> properties separated by a question mark (?).</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string PathAndQuery => null;

	/// <summary>Gets an array containing the path segments that make up the specified URI.</summary>
	/// <returns>A <see cref="T:System.String" /> array that contains the path segments that make up the specified URI.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string[] Segments => null;

	/// <summary>Gets whether the specified <see cref="T:System.Uri" /> is a universal naming convention (UNC) path.</summary>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <see cref="T:System.Uri" /> is a UNC path; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public bool IsUnc => false;

	/// <summary>Gets the host component of this instance.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the host name. This is usually the DNS host name or IP address of the server.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string Host => null;

	private static object InitializeLock => null;

	/// <summary>Gets the port number of this URI.</summary>
	/// <returns>An <see cref="T:System.Int32" /> value that contains the port number for this URI.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public int Port => 0;

	/// <summary>Gets any query information included in the specified URI.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains any query information included in the specified URI.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string Query => null;

	/// <summary>Gets the escaped URI fragment.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains any URI fragment information.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string Fragment => null;

	/// <summary>Gets the scheme name for this URI.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the scheme for this URI, converted to lowercase.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string Scheme => null;

	private bool OriginalStringSwitched => false;

	/// <summary>Gets the original URI string that was passed to the <see cref="T:System.Uri" /> constructor.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the exact URI specified when this instance was constructed; otherwise, <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string OriginalString => null;

	/// <summary>Gets a host name that, after being unescaped if necessary, is safe to use for DNS resolution.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the host part of the URI in a format suitable for DNS resolution; or the original host string, if it is already suitable for resolution.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string DnsSafeHost => null;

	/// <summary>Gets whether the <see cref="T:System.Uri" /> instance is absolute.</summary>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <see cref="T:System.Uri" /> instance is absolute; otherwise, <see langword="false" />.</returns>
	public bool IsAbsoluteUri => false;

	/// <summary>Indicates that the URI string was completely escaped before the <see cref="T:System.Uri" /> instance was created.</summary>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <paramref name="dontEscape" /> parameter was set to <see langword="true" /> when the <see cref="T:System.Uri" /> instance was created; otherwise, <see langword="false" />.</returns>
	public bool UserEscaped => false;

	/// <summary>Gets the user name, password, or other user-specific information associated with the specified URI.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the user information associated with the URI. The returned value does not include the '@' character reserved for delimiting the user information part of the URI.</returns>
	/// <exception cref="T:System.InvalidOperationException">This instance represents a relative URI, and this property is valid only for absolute URIs.</exception>
	public string UserInfo => null;

	internal bool HasAuthority => false;

	internal static bool IriParsingStatic(UriParser syntax)
	{
		return false;
	}

	private bool AllowIdnStatic(UriParser syntax, Flags flags)
	{
		return false;
	}

	private bool IsIntranet(string schemeHost)
	{
		return false;
	}

	private void SetUserDrivenParsing()
	{
	}

	private bool NotAny(Flags flags)
	{
		return false;
	}

	private bool InFact(Flags flags)
	{
		return false;
	}

	private static bool StaticNotAny(Flags allFlags, Flags checkFlags)
	{
		return false;
	}

	private static bool StaticInFact(Flags allFlags, Flags checkFlags)
	{
		return false;
	}

	private UriInfo EnsureUriInfo()
	{
		return null;
	}

	private void EnsureParseRemaining()
	{
	}

	private void EnsureHostString(bool allowDnsOptimization)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class with the specified URI.</summary>
	/// <param name="uriString">A string that identifies the resource to be represented by the <see cref="T:System.Uri" /> instance. Note that an IPv6 address in string form must be enclosed within brackets. For example, "http://[2607:f8b0:400d:c06::69]".</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="uriString" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.
	///
	///    <paramref name="uriString" /> is empty.  
	/// -or-  
	/// The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.  
	/// -or-  
	/// <paramref name="uriString" /> contains too many slashes.  
	/// -or-  
	/// The password specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The host name specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The file name specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The user name specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.  
	/// -or-  
	/// The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.  
	/// -or-  
	/// The length of <paramref name="uriString" /> exceeds 65519 characters.  
	/// -or-  
	/// The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.  
	/// -or-  
	/// There is an invalid character sequence in <paramref name="uriString" />.  
	/// -or-  
	/// The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
	public Uri(string uriString)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class with the specified URI. This constructor allows you to specify if the URI string is a relative URI, absolute URI, or is indeterminate.</summary>
	/// <param name="uriString">A string that identifies the resource to be represented by the <see cref="T:System.Uri" /> instance. Note that an IPv6 address in string form must be enclosed within brackets. For example, "http://[2607:f8b0:400d:c06::69]".</param>
	/// <param name="uriKind">Specifies whether the URI string is a relative URI, absolute URI, or is indeterminate.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="uriKind" /> is invalid.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="uriString" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.
	///
	///    <paramref name="uriString" /> contains a relative URI and <paramref name="uriKind" /> is <see cref="F:System.UriKind.Absolute" />.  
	/// or  
	/// <paramref name="uriString" /> contains an absolute URI and <paramref name="uriKind" /> is <see cref="F:System.UriKind.Relative" />.  
	/// or  
	/// <paramref name="uriString" /> is empty.  
	/// -or-  
	/// The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.  
	/// -or-  
	/// <paramref name="uriString" /> contains too many slashes.  
	/// -or-  
	/// The password specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The host name specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The file name specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The user name specified in <paramref name="uriString" /> is not valid.  
	/// -or-  
	/// The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.  
	/// -or-  
	/// The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.  
	/// -or-  
	/// The length of <paramref name="uriString" /> exceeds 65519 characters.  
	/// -or-  
	/// The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.  
	/// -or-  
	/// There is an invalid character sequence in <paramref name="uriString" />.  
	/// -or-  
	/// The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
	public Uri(string uriString, UriKind uriKind)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class based on the specified base URI and relative URI string.</summary>
	/// <param name="baseUri">The base URI.</param>
	/// <param name="relativeUri">The relative URI to add to the base URI.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="baseUri" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="baseUri" /> is not an absolute <see cref="T:System.Uri" /> instance.</exception>
	/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.
	///
	/// The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is empty or contains only spaces.  
	/// -or-  
	/// The scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> contains too many slashes.  
	/// -or-  
	/// The password specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The host name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The file name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The user name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The host or authority name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> cannot be terminated by backslashes.  
	/// -or-  
	/// The port number specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid or cannot be parsed.  
	/// -or-  
	/// The length of the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 65519 characters.  
	/// -or-  
	/// The length of the scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 1023 characters.  
	/// -or-  
	/// There is an invalid character sequence in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" />.  
	/// -or-  
	/// The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
	public Uri(Uri baseUri, string relativeUri)
	{
	}

	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class based on the combination of a specified base <see cref="T:System.Uri" /> instance and a relative <see cref="T:System.Uri" /> instance.</summary>
	/// <param name="baseUri">An absolute <see cref="T:System.Uri" /> that is the base for the new <see cref="T:System.Uri" /> instance.</param>
	/// <param name="relativeUri">A relative <see cref="T:System.Uri" /> instance that is combined with <paramref name="baseUri" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="baseUri" /> is not an absolute <see cref="T:System.Uri" /> instance.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="baseUri" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="baseUri" /> is not an absolute <see cref="T:System.Uri" /> instance.</exception>
	/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.
	///
	///    The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is empty or contains only spaces.  
	/// -or-  
	/// The scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> contains too many slashes.  
	/// -or-  
	/// The password specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The host name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The file name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The user name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid.  
	/// -or-  
	/// The host or authority name specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> cannot be terminated by backslashes.  
	/// -or-  
	/// The port number specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> is not valid or cannot be parsed.  
	/// -or-  
	/// The length of the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 65519 characters.  
	/// -or-  
	/// The length of the scheme specified in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" /> exceeds 1023 characters.  
	/// -or-  
	/// There is an invalid character sequence in the URI formed by combining <paramref name="baseUri" /> and <paramref name="relativeUri" />.  
	/// -or-  
	/// The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
	public Uri(Uri baseUri, Uri relativeUri)
	{
	}

	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
	{
		return default(ParsingError);
	}

	private static UriFormatException GetException(ParsingError err)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Uri" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
	/// <param name="serializationInfo">An instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class containing the information required to serialize the new <see cref="T:System.Uri" /> instance.</param>
	/// <param name="streamingContext">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class containing the source of the serialized stream associated with the new <see cref="T:System.Uri" /> instance.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationInfo" /> parameter contains a <see langword="null" /> URI.</exception>
	/// <exception cref="T:System.UriFormatException">The <paramref name="serializationInfo" /> parameter contains a URI that is empty.  
	///  -or-  
	///  The scheme specified is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.  
	///  -or-  
	///  The URI contains too many slashes.  
	///  -or-  
	///  The password specified in the URI is not valid.  
	///  -or-  
	///  The host name specified in URI is not valid.  
	///  -or-  
	///  The file name specified in the URI is not valid.  
	///  -or-  
	///  The user name specified in the URI is not valid.  
	///  -or-  
	///  The host or authority name specified in the URI cannot be terminated by backslashes.  
	///  -or-  
	///  The port number specified in the URI is not valid or cannot be parsed.  
	///  -or-  
	///  The length of URI exceeds 65519 characters.  
	///  -or-  
	///  The length of the scheme specified in the URI exceeds 1023 characters.  
	///  -or-  
	///  There is an invalid character sequence in the URI.  
	///  -or-  
	///  The MS-DOS path specified in the URI must start with c:\\.</exception>
	protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Returns the data needed to serialize the current instance.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Uri" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Uri" />.</param>
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	/// <summary>Returns the data needed to serialize the current instance.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Uri" />.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Uri" />.</param>
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private static bool StaticIsFile(UriParser syntax)
	{
		return false;
	}

	private static void InitializeUriConfig()
	{
	}

	private string GetLocalPath()
	{
		return null;
	}

	internal static bool IsGenDelim(char ch)
	{
		return false;
	}

	/// <summary>Determines whether the specified scheme name is valid.</summary>
	/// <param name="schemeName">The scheme name to validate.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the scheme name is valid; otherwise, <see langword="false" />.</returns>
	public static bool CheckSchemeName(string schemeName)
	{
		return false;
	}

	/// <summary>Determines whether a specified character is a valid hexadecimal digit.</summary>
	/// <param name="character">The character to validate.</param>
	/// <returns>
	///   <see langword="true" /> if the character is a valid hexadecimal digit; otherwise, <see langword="false" />.</returns>
	public static bool IsHexDigit(char character)
	{
		return false;
	}

	/// <summary>Gets the decimal value of a hexadecimal digit.</summary>
	/// <param name="digit">The hexadecimal digit (0-9, a-f, A-F) to convert.</param>
	/// <returns>An <see cref="T:System.Int32" /> value that contains a number from 0 to 15 that corresponds to the specified hexadecimal digit.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="digit" /> is not a valid hexadecimal digit (0-9, a-f, A-F).</exception>
	public static int FromHex(char digit)
	{
		return 0;
	}

	/// <summary>Gets the hash code for the URI.</summary>
	/// <returns>An <see cref="T:System.Int32" /> containing the hash value generated for this URI.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Gets a canonical string representation for the specified <see cref="T:System.Uri" /> instance.</summary>
	/// <returns>A <see cref="T:System.String" /> instance that contains the unescaped canonical representation of the <see cref="T:System.Uri" /> instance. All characters are unescaped except #, ?, and %.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Determines whether two <see cref="T:System.Uri" /> instances have the same value.</summary>
	/// <param name="uri1">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri2" />.</param>
	/// <param name="uri2">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri1" />.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <see cref="T:System.Uri" /> instances are equivalent; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Uri uri1, Uri uri2)
	{
		return false;
	}

	/// <summary>Determines whether two <see cref="T:System.Uri" /> instances do not have the same value.</summary>
	/// <param name="uri1">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri2" />.</param>
	/// <param name="uri2">A <see cref="T:System.Uri" /> instance to compare with <paramref name="uri1" />.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the two <see cref="T:System.Uri" /> instances are not equal; otherwise, <see langword="false" />. If either parameter is <see langword="null" />, this method returns <see langword="true" />.</returns>
	public static bool operator !=(Uri uri1, Uri uri2)
	{
		return false;
	}

	/// <summary>Compares two <see cref="T:System.Uri" /> instances for equality.</summary>
	/// <param name="comparand">The <see cref="T:System.Uri" /> instance or a URI identifier to compare with the current instance.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the two instances represent the same URI; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object comparand)
	{
		return false;
	}

	private static bool CheckForColonInFirstPathSegment(string uriString)
	{
		return false;
	}

	internal static string InternalEscapeString(string rawString)
	{
		return null;
	}

	private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax)
	{
		return default(ParsingError);
	}

	internal UriFormatException ParseMinimal()
	{
		return null;
	}

	private ParsingError PrivateParseMinimal()
	{
		return default(ParsingError);
	}

	private void PrivateParseMinimalIri(string newHost, ushort idx)
	{
	}

	private void CreateUriInfo(Flags cF)
	{
	}

	private void CreateHostString()
	{
	}

	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId)
	{
		return null;
	}

	private void GetHostViaCustomSyntax()
	{
	}

	internal string GetParts(UriComponents uriParts, UriFormat formatAs)
	{
		return null;
	}

	private string GetEscapedParts(UriComponents uriParts)
	{
		return null;
	}

	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
	{
		return null;
	}

	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
	{
		return null;
	}

	private string GetUriPartsFromUserString(UriComponents uriParts)
	{
		return null;
	}

	private void ParseRemaining()
	{
	}

	private unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax)
	{
		return 0;
	}

	private unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
	{
		return false;
	}

	private unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
	{
		return default(ParsingError);
	}

	private unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost)
	{
		return 0;
	}

	private unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
	{
	}

	private unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err)
	{
	}

	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
	{
	}

	private unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
	{
	}

	private unsafe Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
	{
		return default(Check);
	}

	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs)
	{
		return null;
	}

	private unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
	{
	}

	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax)
	{
		return null;
	}

	internal static int CalculateCaseInsensitiveHashCode(string text)
	{
		return 0;
	}

	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
	{
		return null;
	}

	private static bool IsLWS(char ch)
	{
		return false;
	}

	private static bool IsAsciiLetter(char character)
	{
		return false;
	}

	internal static bool IsAsciiLetterOrDigit(char character)
	{
		return false;
	}

	internal static bool IsBidiControlCharacter(char ch)
	{
		return false;
	}

	internal unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
	{
		return null;
	}

	private void CreateThis(string uri, bool dontEscape, UriKind uriKind)
	{
	}

	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
	{
		e = null;
	}

	private bool CheckForConfigLoad(string data)
	{
		return false;
	}

	private bool CheckForUnicode(string data)
	{
		return false;
	}

	private bool CheckForEscapedUnreserved(string data)
	{
		return false;
	}

	/// <summary>Creates a new <see cref="T:System.Uri" /> using the specified <see cref="T:System.String" /> instance and a <see cref="T:System.UriKind" />.</summary>
	/// <param name="uriString">The <see cref="T:System.String" /> representing the <see cref="T:System.Uri" />.</param>
	/// <param name="uriKind">The type of the Uri.</param>
	/// <param name="result">When this method returns, contains the constructed <see cref="T:System.Uri" />.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <see cref="T:System.Uri" /> was successfully created; otherwise, <see langword="false" />.</returns>
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
	{
		result = null;
		return false;
	}

	/// <summary>Creates a new <see cref="T:System.Uri" /> using the specified base and relative <see cref="T:System.String" /> instances.</summary>
	/// <param name="baseUri">The base <see cref="T:System.Uri" />.</param>
	/// <param name="relativeUri">The relative <see cref="T:System.Uri" />, represented as a <see cref="T:System.String" />, to add to the base <see cref="T:System.Uri" />.</param>
	/// <param name="result">When this method returns, contains a <see cref="T:System.Uri" /> constructed from <paramref name="baseUri" /> and <paramref name="relativeUri" />. This parameter is passed uninitialized.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <see cref="T:System.Uri" /> was successfully created; otherwise, <see langword="false" />.</returns>
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result)
	{
		result = null;
		return false;
	}

	/// <summary>Creates a new <see cref="T:System.Uri" /> using the specified base and relative <see cref="T:System.Uri" /> instances.</summary>
	/// <param name="baseUri">The base <see cref="T:System.Uri" />.</param>
	/// <param name="relativeUri">The relative <see cref="T:System.Uri" /> to add to the base <see cref="T:System.Uri" />.</param>
	/// <param name="result">When this method returns, contains a <see cref="T:System.Uri" /> constructed from <paramref name="baseUri" /> and <paramref name="relativeUri" />. This parameter is passed uninitialized.</param>
	/// <returns>A <see cref="T:System.Boolean" /> value that is <see langword="true" /> if the <see cref="T:System.Uri" /> was successfully created; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="baseUri" /> is <see langword="null" />.</exception>
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result)
	{
		result = null;
		return false;
	}

	/// <summary>Gets the specified components of the current instance using the specified escaping for special characters.</summary>
	/// <param name="components">A bitwise combination of the <see cref="T:System.UriComponents" /> values that specifies which parts of the current instance to return to the caller.</param>
	/// <param name="format">One of the <see cref="T:System.UriFormat" /> values that controls how special characters are escaped.</param>
	/// <returns>A <see cref="T:System.String" /> that contains the components.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="components" /> is not a combination of valid <see cref="T:System.UriComponents" /> values.</exception>
	/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Uri" /> is not an absolute URI. Relative URIs cannot be used with this method.</exception>
	public string GetComponents(UriComponents components, UriFormat format)
	{
		return null;
	}

	/// <summary>Indicates whether the string used to construct this <see cref="T:System.Uri" /> was well-formed and is not required to be further escaped.</summary>
	/// <returns>
	///   <see langword="true" /> if the string was well-formed; otherwise, <see langword="false" />.</returns>
	public bool IsWellFormedOriginalString()
	{
		return false;
	}

	/// <summary>Indicates whether the string is well-formed by attempting to construct a URI with the string and ensures that the string does not require further escaping.</summary>
	/// <param name="uriString">The string used to attempt to construct a <see cref="T:System.Uri" />.</param>
	/// <param name="uriKind">The type of the <see cref="T:System.Uri" /> in <paramref name="uriString" />.</param>
	/// <returns>
	///   <see langword="true" /> if the string was well-formed; otherwise, <see langword="false" />.</returns>
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind)
	{
		return false;
	}

	internal bool InternalIsWellFormedOriginalString()
	{
		return false;
	}

	/// <summary>Converts a string to its unescaped representation.</summary>
	/// <param name="stringToUnescape">The string to unescape.</param>
	/// <returns>A <see cref="T:System.String" /> that contains the unescaped representation of <paramref name="stringToUnescape" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stringToUnescape" /> is <see langword="null" />.</exception>
	public static string UnescapeDataString(string stringToUnescape)
	{
		return null;
	}

	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
	{
		return null;
	}

	private Uri(Flags flags, UriParser uriParser, string uri)
	{
	}

	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
	{
		return null;
	}

	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
	{
		e = null;
		return null;
	}

	private string GetRelativeSerializationString(UriFormat format)
	{
		return null;
	}

	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
	{
		return null;
	}

	/// <summary>Determines whether the current <see cref="T:System.Uri" /> instance is a base of the specified <see cref="T:System.Uri" /> instance.</summary>
	/// <param name="uri">The specified <see cref="T:System.Uri" /> instance to test.</param>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Uri" /> instance is a base of <paramref name="uri" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="uri" /> is <see langword="null" />.</exception>
	public bool IsBaseOf(Uri uri)
	{
		return false;
	}

	internal bool IsBaseOfHelper(Uri uriLink)
	{
		return false;
	}

	private void CreateThisFromUri(Uri otherUri)
	{
	}
}
