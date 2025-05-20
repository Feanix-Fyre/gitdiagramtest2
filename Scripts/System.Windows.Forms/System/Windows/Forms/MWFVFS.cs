using System.Collections;
using System.Collections.Specialized;
using System.Threading;

namespace System.Windows.Forms;

internal class MWFVFS
{
	internal class WorkerThread
	{
		private FileSystem fileSystem;

		private StringCollection the_filters;

		private UpdateDelegate updateDelegate;

		private Control calling_control;

		private readonly object lockobject;

		private bool stopped;

		public WorkerThread(FileSystem fileSystem, StringCollection the_filters, UpdateDelegate updateDelegate, Control calling_control)
		{
		}

		public void GetFolderContentThread()
		{
		}

		public void Stop()
		{
		}
	}

	public delegate void UpdateDelegate(ArrayList folders, ArrayList files);

	private FileSystem fileSystem;

	public static readonly string DesktopPrefix;

	public static readonly string PersonalPrefix;

	public static readonly string MyComputerPrefix;

	public static readonly string RecentlyUsedPrefix;

	public static readonly string MyNetworkPrefix;

	public static readonly string MyComputerPersonalPrefix;

	public static Hashtable MyComputerDevicesPrefix;

	private UpdateDelegate updateDelegate;

	private Control calling_control;

	private ThreadStart get_folder_content_thread_start;

	private Thread worker;

	private WorkerThread workerThread;

	private StringCollection the_filters;

	public FSEntry ChangeDirectory(string folder)
	{
		return null;
	}

	public void GetFolderContent()
	{
	}

	public void GetFolderContent(StringCollection filters)
	{
	}

	public ArrayList GetFoldersOnly()
	{
		return null;
	}

	public void WriteRecentlyUsedFiles(string filename)
	{
	}

	public ArrayList GetMyComputerContent()
	{
		return null;
	}

	public bool CreateFolder(string new_folder)
	{
		return false;
	}

	public bool MoveFolder(string sourceDirName, string destDirName)
	{
		return false;
	}

	public bool MoveFile(string sourceFileName, string destFileName)
	{
		return false;
	}

	public string GetParent()
	{
		return null;
	}

	public void RegisterUpdateDelegate(UpdateDelegate updateDelegate, Control control)
	{
	}
}
