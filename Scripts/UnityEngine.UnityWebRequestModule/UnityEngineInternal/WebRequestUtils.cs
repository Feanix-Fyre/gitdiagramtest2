using System;
using System.Text.RegularExpressions;
using UnityEngine.Scripting;

namespace UnityEngineInternal;

internal static class WebRequestUtils
{
	private static Regex domainRegex;

	[RequiredByNativeCode]
	internal static string RedirectTo(string baseUri, string redirectUri)
	{
		return null;
	}

	internal static string MakeInitialUrl(string targetUrl, string localUrl)
	{
		return null;
	}

	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol)
	{
		return null;
	}

	private static string URLDecode(string encoded)
	{
		return null;
	}
}
