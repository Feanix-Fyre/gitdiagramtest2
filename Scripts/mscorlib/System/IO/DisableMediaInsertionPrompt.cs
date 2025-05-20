namespace System.IO;

internal struct DisableMediaInsertionPrompt : IDisposable
{
	private bool _disableSuccess;

	private uint _oldMode;

	private static bool useUWPFallback;

	public static DisableMediaInsertionPrompt Create()
	{
		return default(DisableMediaInsertionPrompt);
	}

	public void Dispose()
	{
	}
}
