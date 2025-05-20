using System.Collections;

namespace System.Windows.Forms;

internal class MasterMount
{
	internal enum FsTypes
	{
		none = 0,
		ext2 = 1,
		ext3 = 2,
		hpfs = 3,
		iso9660 = 4,
		jfs = 5,
		minix = 6,
		msdos = 7,
		ntfs = 8,
		reiserfs = 9,
		ufs = 10,
		umsdos = 11,
		vfat = 12,
		sysv = 13,
		xfs = 14,
		ncpfs = 15,
		nfs = 16,
		smbfs = 17,
		usbfs = 18,
		cifs = 19
	}

	internal struct Mount
	{
		public string device_or_filesystem;

		public string device_short;

		public string mount_point;

		public FsTypes fsType;
	}

	public class MountComparer : IComparer
	{
		public int Compare(object mount1, object mount2)
		{
			return 0;
		}
	}

	private bool proc_mount_available;

	private ArrayList block_devices;

	private ArrayList network_devices;

	private ArrayList removable_devices;

	private MountComparer mountComparer;

	public ArrayList Block_devices => null;

	public ArrayList Network_devices => null;

	public ArrayList Removable_devices => null;

	public bool ProcMountAvailable => false;

	public void GetMounts()
	{
	}

	private void ProcessProcMountLine(string line)
	{
	}
}
