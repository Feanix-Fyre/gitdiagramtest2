using System.Collections.Generic;

namespace System;

/// <summary>Parses a new URI scheme. This is an abstract class.</summary>
public abstract class UriParser
{
	private enum UriQuirksVersion
	{
		V2 = 2,
		V3 = 3
	}

	private class BuiltInUriParser : UriParser
	{
		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
			: base(default(UriSyntaxFlags))
		{
		}
	}

	private const UriSyntaxFlags SchemeOnlyFlags = UriSyntaxFlags.MayHavePath;

	private static readonly Dictionary<string, UriParser> m_Table;

	private static Dictionary<string, UriParser> m_TempTable;

	private UriSyntaxFlags m_Flags;

	private UriSyntaxFlags m_UpdatableFlags;

	private bool m_UpdatableFlagsUsed;

	private const UriSyntaxFlags c_UpdatableFlags = UriSyntaxFlags.UnEscapeDotsAndSlashes;

	private int m_Port;

	private string m_Scheme;

	internal const int NoDefaultPort = -1;

	private const int c_InitialTableSize = 25;

	internal static UriParser HttpUri;

	internal static UriParser HttpsUri;

	internal static UriParser WsUri;

	internal static UriParser WssUri;

	internal static UriParser FtpUri;

	internal static UriParser FileUri;

	internal static UriParser GopherUri;

	internal static UriParser NntpUri;

	internal static UriParser NewsUri;

	internal static UriParser MailToUri;

	internal static UriParser UuidUri;

	internal static UriParser TelnetUri;

	internal static UriParser LdapUri;

	internal static UriParser NetTcpUri;

	internal static UriParser NetPipeUri;

	internal static UriParser VsMacrosUri;

	private static readonly UriQuirksVersion s_QuirksVersion;

	private const int c_MaxCapacity = 512;

	private const UriSyntaxFlags UnknownV1SyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.OptionalAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.V1_UnknownUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private static readonly UriSyntaxFlags HttpSyntaxFlags;

	private const UriSyntaxFlags FtpSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private static readonly UriSyntaxFlags FileSyntaxFlags;

	private const UriSyntaxFlags VsmacrosSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.FileLikeUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags GopherSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NewsSyntaxFlags = UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NntpSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags TelnetSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags LdapSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags MailtoSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.MailToLikeUri | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NetPipeSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	private const UriSyntaxFlags NetTcpSyntaxFlags = UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

	internal string SchemeName => null;

	internal int DefaultPort => 0;

	internal static bool ShouldUseLegacyV2Quirks => false;

	internal UriSyntaxFlags Flags => default(UriSyntaxFlags);

	internal bool IsSimple => false;

	/// <summary>Invoked by a <see cref="T:System.Uri" /> constructor to get a <see cref="T:System.UriParser" /> instance</summary>
	/// <returns>A <see cref="T:System.UriParser" /> for the constructed <see cref="T:System.Uri" />.</returns>
	protected virtual UriParser OnNewUri()
	{
		return null;
	}

	/// <summary>Initialize the state of the parser and validate the URI.</summary>
	/// <param name="uri">The T:System.Uri to validate.</param>
	/// <param name="parsingError">Validation errors, if any.</param>
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
	{
		parsingError = null;
	}

	/// <summary>Called by <see cref="T:System.Uri" /> constructors and <see cref="Overload:System.Uri.TryCreate" /> to resolve a relative URI.</summary>
	/// <param name="baseUri">A base URI.</param>
	/// <param name="relativeUri">A relative URI.</param>
	/// <param name="parsingError">Errors during the resolve process, if any.</param>
	/// <returns>The string of the resolved relative <see cref="T:System.Uri" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="baseUri" /> parameter is not an absolute <see cref="T:System.Uri" />  
	/// -or-
	///  <paramref name="baseUri" /> parameter requires user-driven parsing.</exception>
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
	{
		parsingError = null;
		return null;
	}

	/// <summary>Determines whether <paramref name="baseUri" /> is a base URI for <paramref name="relativeUri" />.</summary>
	/// <param name="baseUri">The base URI.</param>
	/// <param name="relativeUri">The URI to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="baseUri" /> is a base URI for <paramref name="relativeUri" />; otherwise, <see langword="false" />.</returns>
	protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri)
	{
		return false;
	}

	/// <summary>Gets the components from a URI.</summary>
	/// <param name="uri">The URI to parse.</param>
	/// <param name="components">The <see cref="T:System.UriComponents" /> to retrieve from <paramref name="uri" />.</param>
	/// <param name="format">One of the <see cref="T:System.UriFormat" /> values that controls how special characters are escaped.</param>
	/// <returns>A string that contains the components.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="uriFormat" /> is invalid.  
	/// -or-
	///  <paramref name="uriComponents" /> is not a combination of valid <see cref="T:System.UriComponents" /> values.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="uri" /> requires user-driven parsing  
	/// -or-
	///  <paramref name="uri" /> is not an absolute URI. Relative URIs cannot be used with this method.</exception>
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
	{
		return null;
	}

	/// <summary>Indicates whether a URI is well-formed.</summary>
	/// <param name="uri">The URI to check.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="uri" /> is well-formed; otherwise, <see langword="false" />.</returns>
	protected virtual bool IsWellFormedOriginalString(Uri uri)
	{
		return false;
	}

	static UriParser()
	{
	}

	internal bool NotAny(UriSyntaxFlags flags)
	{
		return false;
	}

	internal bool InFact(UriSyntaxFlags flags)
	{
		return false;
	}

	internal bool IsAllSet(UriSyntaxFlags flags)
	{
		return false;
	}

	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
	{
		return false;
	}

	internal UriParser(UriSyntaxFlags flags)
	{
	}

	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
	{
		return null;
	}

	internal static UriParser GetSyntax(string lwrCaseScheme)
	{
		return null;
	}

	internal UriParser InternalOnNewUri()
	{
		return null;
	}

	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError)
	{
		parsingError = null;
	}

	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
	{
		parsingError = null;
		return null;
	}

	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink)
	{
		return false;
	}

	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
	{
		return null;
	}

	internal bool InternalIsWellFormedOriginalString(Uri thisUri)
	{
		return false;
	}
}
