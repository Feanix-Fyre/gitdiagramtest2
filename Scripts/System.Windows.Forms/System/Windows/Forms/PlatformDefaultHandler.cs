namespace System.Windows.Forms;

internal class PlatformDefaultHandler : PlatformMimeIconHandler
{
	public override MimeExtensionHandlerStatus Start()
	{
		return default(MimeExtensionHandlerStatus);
	}
}
