namespace System.Net;

internal class FtpMethodInfo
{
	internal string Method;

	internal FtpOperation Operation;

	internal FtpMethodFlags Flags;

	internal string HttpCommand;

	private static readonly FtpMethodInfo[] s_knownMethodInfo;

	internal bool IsCommandOnly => false;

	internal bool IsUpload => false;

	internal bool IsDownload => false;

	internal bool ShouldParseForResponseUri => false;

	internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand)
	{
	}

	internal bool HasFlag(FtpMethodFlags flags)
	{
		return false;
	}

	internal static FtpMethodInfo GetMethodInfo(string method)
	{
		return null;
	}
}
