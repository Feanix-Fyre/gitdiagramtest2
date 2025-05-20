using System.IO;

namespace System.Windows.Forms;

internal class FSEntry
{
	public enum FSEntryType
	{
		Desktop = 0,
		RecentlyUsed = 1,
		MyComputer = 2,
		File = 3,
		Directory = 4,
		Device = 5,
		RemovableDevice = 6,
		Network = 7
	}

	private MasterMount.FsTypes fsType;

	private string device_short;

	private string fullName;

	private string name;

	private string realName;

	private FileAttributes attributes;

	private long fileSize;

	private FSEntryType fileType;

	private DateTime lastAccessTime;

	private FSEntry mainTopNode;

	private int iconIndex;

	private string parent;

	public MasterMount.FsTypes FsType
	{
		set
		{
		}
	}

	public string DeviceShort
	{
		set
		{
		}
	}

	public string FullName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string RealName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FileAttributes Attributes
	{
		get
		{
			return default(FileAttributes);
		}
		set
		{
		}
	}

	public long FileSize
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public FSEntryType FileType
	{
		get
		{
			return default(FSEntryType);
		}
		set
		{
		}
	}

	public DateTime LastAccessTime
	{
		get
		{
			return default(DateTime);
		}
		set
		{
		}
	}

	public int IconIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public FSEntry MainTopNode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Parent => null;

	private string GetParent()
	{
		return null;
	}
}
