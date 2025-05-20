using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace System.Net.Http;

internal static class PlatformHelper
{
	internal static bool IsContentHeader(string name)
	{
		return false;
	}

	internal static string GetSingleHeaderString(string name, IEnumerable<string> values)
	{
		return null;
	}

	internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken)
	{
		return null;
	}
}
