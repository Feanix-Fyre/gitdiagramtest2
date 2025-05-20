using System.Collections.Specialized;

namespace System.Net;

internal class KnownHttpVerb
{
	internal string Name;

	internal bool RequireContentBody;

	internal bool ContentBodyNotAllowed;

	internal bool ConnectRequest;

	internal bool ExpectNoContentResponse;

	private static ListDictionary NamedHeaders;

	internal static KnownHttpVerb Get;

	internal static KnownHttpVerb Connect;

	internal static KnownHttpVerb Head;

	internal static KnownHttpVerb Put;

	internal static KnownHttpVerb Post;

	internal static KnownHttpVerb MkCol;

	internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse)
	{
	}

	static KnownHttpVerb()
	{
	}

	public static KnownHttpVerb Parse(string name)
	{
		return null;
	}
}
