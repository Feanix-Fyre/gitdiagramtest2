namespace System.Windows.Forms;

internal abstract class PlatformMimeIconHandler
{
	public abstract MimeExtensionHandlerStatus Start();

	public virtual object AddAndGetIconIndex(string filename, string mime_type)
	{
		return null;
	}

	public virtual object AddAndGetIconIndex(string mime_type)
	{
		return null;
	}
}
