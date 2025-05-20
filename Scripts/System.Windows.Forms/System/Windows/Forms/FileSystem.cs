using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace System.Windows.Forms;

internal abstract class FileSystem
{
	internal class FileInfoComparer : IComparer
	{
		public int Compare(object fileInfo1, object fileInfo2)
		{
			return 0;
		}
	}

	internal class FSEntryComparer : IComparer
	{
		public int Compare(object fileInfo1, object fileInfo2)
		{
			return 0;
		}
	}

	protected string currentTopFolder;

	protected FSEntry currentFolderFSEntry;

	protected FSEntry currentTopFolderFSEntry;

	private FileInfoComparer fileInfoComparer;

	private FSEntryComparer fsEntryComparer;

	public FSEntry ChangeDirectory(string folder)
	{
		return null;
	}

	public string GetParent()
	{
		return null;
	}

	public void GetFolderContent(StringCollection filters, out ArrayList directories_out, out ArrayList files_out)
	{
		directories_out = null;
		files_out = null;
	}

	public ArrayList GetFoldersOnly()
	{
		return null;
	}

	protected void GetNormalFolderContent(string from_folder, StringCollection filters, out ArrayList directories_out, out ArrayList files_out)
	{
		directories_out = null;
		files_out = null;
	}

	protected ArrayList GetNormalFolders(string from_folder)
	{
		return null;
	}

	protected virtual FSEntry GetDirectoryFSEntry(DirectoryInfo dirinfo, FSEntry topFolderFSEntry)
	{
		return null;
	}

	protected virtual FSEntry GetFileFSEntry(FileInfo fileinfo)
	{
		return null;
	}

	protected abstract FSEntry GetDesktopFSEntry();

	protected abstract FSEntry GetRecentlyUsedFSEntry();

	protected abstract FSEntry GetPersonalFSEntry();

	protected abstract FSEntry GetMyComputerPersonalFSEntry();

	protected abstract FSEntry GetMyComputerFSEntry();

	protected abstract FSEntry GetMyNetworkFSEntry();

	public abstract void WriteRecentlyUsedFiles(string fileToAdd);

	public abstract ArrayList GetRecentlyUsedFiles();

	public abstract ArrayList GetMyComputerContent();

	public abstract ArrayList GetMyNetworkContent();
}
