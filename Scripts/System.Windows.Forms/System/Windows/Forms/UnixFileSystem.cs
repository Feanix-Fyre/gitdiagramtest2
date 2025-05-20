using System.Collections;

namespace System.Windows.Forms;

internal class UnixFileSystem : FileSystem
{
	private MasterMount masterMount;

	private FSEntry desktopFSEntry;

	private FSEntry recentlyusedFSEntry;

	private FSEntry personalFSEntry;

	private FSEntry mycomputerpersonalFSEntry;

	private FSEntry mycomputerFSEntry;

	private FSEntry mynetworkFSEntry;

	private string personal_folder;

	private string recently_used_path;

	private string full_kde_recent_document_dir;

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
