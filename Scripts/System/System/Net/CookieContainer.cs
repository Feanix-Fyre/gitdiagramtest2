using System.Collections;
using System.Collections.Generic;

namespace System.Net;

/// <summary>Provides a container for a collection of <see cref="T:System.Net.CookieCollection" /> objects.</summary>
[Serializable]
public class CookieContainer
{
	private static readonly HeaderVariantInfo[] HeaderInfo;

	private Hashtable m_domainTable;

	private int m_maxCookieSize;

	private int m_maxCookies;

	private int m_maxCookiesPerDomain;

	private int m_count;

	private string m_fqdnMyDomain;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.CookieContainer" /> class.</summary>
	public CookieContainer()
	{
	}

	private void AddRemoveDomain(string key, PathList value)
	{
	}

	internal void Add(Cookie cookie, bool throwOnError)
	{
	}

	private bool AgeCookies(string domain)
	{
		return false;
	}

	private int ExpireCollection(CookieCollection cc)
	{
		return 0;
	}

	internal bool IsLocalDomain(string host)
	{
		return false;
	}

	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
	{
		return null;
	}

	internal CookieCollection InternalGetCookies(Uri uri)
	{
		return null;
	}

	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
	{
	}

	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
	{
	}

	/// <summary>Gets the HTTP cookie header that contains the HTTP cookies that represent the <see cref="T:System.Net.Cookie" /> instances that are associated with a specific URI.</summary>
	/// <param name="uri">The URI of the <see cref="T:System.Net.Cookie" /> instances desired.</param>
	/// <returns>An HTTP cookie header, with strings representing <see cref="T:System.Net.Cookie" /> instances delimited by semicolons.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="uri" /> is <see langword="null" />.</exception>
	public string GetCookieHeader(Uri uri)
	{
		return null;
	}

	internal string GetCookieHeader(Uri uri, out string optCookie2)
	{
		optCookie2 = null;
		return null;
	}
}
