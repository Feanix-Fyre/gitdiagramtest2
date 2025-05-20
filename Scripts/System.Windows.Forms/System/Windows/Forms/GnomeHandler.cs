namespace System.Windows.Forms;

internal class GnomeHandler : PlatformMimeIconHandler
{
	public override MimeExtensionHandlerStatus Start()
	{
		return default(MimeExtensionHandlerStatus);
	}

	private void CreateUIIcons()
	{
	}

	private void AddGnomeIcon(string internal_mime_type, string name)
	{
	}

	public override object AddAndGetIconIndex(string filename, string mime_type)
	{
		return null;
	}

	public override object AddAndGetIconIndex(string mime_type)
	{
		return null;
	}
}
