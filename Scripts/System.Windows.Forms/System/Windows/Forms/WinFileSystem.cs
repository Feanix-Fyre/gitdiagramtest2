using System.Collections;

namespace System.Windows.Forms;

internal class WinFileSystem : FileSystem
{
	private FSEntry desktopFSEntry;

	private FSEntry recentlyusedFSEntry;

	private FSEntry personalFSEntry;

	private FSEntry mycomputerpersonalFSEntry;

	private FSEntry mycomputerFSEntry;

	private FSEntry mynetworkFSEntry;

	public override void WriteRecentlyUsedFiles(string fileToAdd)
	{
	}

	public override ArrayList GetRecentlyUsedFiles()
	{
		return null;
	}

	public override ArrayList GetMyComputerContent()
	{
		return null;
	}

	public override ArrayList GetMyNetworkContent()
	{
		return null;
	}

	protected override FSEntry GetDesktopFSEntry()
	{
		return null;
	}

	protected override FSEntry GetRecentlyUsedFSEntry()
	{
		return null;
	}

	protected override FSEntry GetPersonalFSEntry()
	{
		return null;
	}

	protected override FSEntry GetMyComputerPersonalFSEntry()
	{
		return null;
	}

	protected override FSEntry GetMyComputerFSEntry()
	{
		return null;
	}

	protected override FSEntry GetMyNetworkFSEntry()
	{
		return null;
	}
}
