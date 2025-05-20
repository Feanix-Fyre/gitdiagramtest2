using System.Collections;

namespace System.Windows.Forms;

internal class DirComboBox : ComboBox, IUpdateFolder
{
	internal class DirComboBoxItem
	{
		private int imageIndex;

		private string name;

		private string path;

		private int xPos;

		private ImageList imageList;

		public int ImageIndex => 0;

		public string Name => null;

		public string Path => null;

		public int XPos => 0;

		public ImageList ImageList => null;

		public DirComboBoxItem(ImageList imageList, int imageIndex, string name, string path, int xPos)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	private ImageList imageList;

	private string currentPath;

	private Stack folderStack;

	private static readonly int indent;

	private DirComboBoxItem recentlyUsedDirComboboxItem;

	private DirComboBoxItem desktopDirComboboxItem;

	private DirComboBoxItem personalDirComboboxItem;

	private DirComboBoxItem myComputerDirComboboxItem;

	private DirComboBoxItem networkDirComboboxItem;

	private ArrayList myComputerItems;

	private DirComboBoxItem mainParentDirComboBoxItem;

	private DirComboBoxItem real_parent;

	private MWFVFS vfs;

	private static object CDirectoryChangedEvent;

	public string CurrentFolder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event EventHandler DirectoryChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public DirComboBox(MWFVFS vfs)
	{
	}

	private void CreateComboList()
	{
	}

	private DirComboBoxItem CreateFolderStack()
	{
		return null;
	}

	private DirComboBoxItem AppendToParent(int nr_indents, DirComboBoxItem parentDirComboBoxItem)
	{
		return null;
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
	}

	protected override void OnSelectionChangeCommitted(EventArgs e)
	{
	}
}
