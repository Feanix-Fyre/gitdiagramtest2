using System.Collections;

namespace System.Windows.Forms;

internal class MWFFileView : ListView
{
	private ArrayList filterArrayList;

	private bool showHiddenFiles;

	private string selectedFilesString;

	private int filterIndex;

	private ToolTip toolTip;

	private int oldItemIndexForToolTip;

	private ContextMenu contextMenu;

	private MenuItem menuItemView;

	private MenuItem menuItemNew;

	private MenuItem smallIconMenutItem;

	private MenuItem tilesMenutItem;

	private MenuItem largeIconMenutItem;

	private MenuItem listMenutItem;

	private MenuItem detailsMenutItem;

	private MenuItem newFolderMenuItem;

	private MenuItem showHiddenFilesMenuItem;

	private int previousCheckedMenuItemIndex;

	private ArrayList viewMenuItemClones;

	private FSEntry currentFSEntry;

	private string currentFolder;

	private string currentRealFolder;

	private FSEntry currentFolderFSEntry;

	private Stack directoryStack;

	private ArrayList dirStackControlsOrComponents;

	private ToolBarButton folderUpToolBarButton;

	private ArrayList registered_senders;

	private bool should_push;

	private MWFVFS vfs;

	private View old_view;

	private int old_menuitem_index;

	private bool do_update_view;

	private ColumnHeader[] columns;

	private static object MSelectedFileChangedEvent;

	private static object MSelectedFilesChangedEvent;

	private static object MDirectoryChangedEvent;

	private static object MForceDialogEndEvent;

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

	public string CurrentRealFolder => null;

	public FSEntry CurrentFSEntry => null;

	public MenuItem[] ViewMenuItems => null;

	public ArrayList FilterArrayList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool ShowHiddenFiles => false;

	public int FilterIndex
	{
		set
		{
		}
	}

	public string SelectedFilesString => null;

	public event EventHandler SelectedFileChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EventHandler SelectedFilesChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EventHandler ForceDialogEnd
	{
		add
		{
		}
		remove
		{
		}
	}

	public MWFFileView(MWFVFS vfs)
	{
	}

	private ColumnHeader CreateColumnHeader(string text, int width, HorizontalAlignment alignment)
	{
		return null;
	}

	public void PushDir()
	{
	}

	public void PopDir()
	{
	}

	public void PopDir(string filter)
	{
	}

	public void RegisterSender(IUpdateFolder iud)
	{
	}

	public void CreateNewFolder()
	{
	}

	public void OneDirUp()
	{
	}

	public void OneDirUp(string filter)
	{
	}

	public void ChangeDirectory(object sender, string folder)
	{
	}

	public void ChangeDirectory(object sender, string folder, string filter)
	{
	}

	public void UpdateFileView()
	{
	}

	public void UpdateFileView(string custom_filter)
	{
	}

	public void RealFileViewUpdate(ArrayList directoriesArrayList, ArrayList fileArrayList)
	{
	}

	public void AddControlToEnableDisableByDirStack(object control)
	{
	}

	public void SetFolderUpToolBarButton(ToolBarButton tb)
	{
	}

	public void WriteRecentlyUsed(string fullfilename)
	{
	}

	private void EnableOrDisableDirstackObjects()
	{
	}

	private void DoOneFSEntry(FSEntry fsEntry)
	{
	}

	private void MWF_KeyDown(object sender, KeyEventArgs e)
	{
	}

	protected override void OnClick(EventArgs e)
	{
	}

	protected override void OnDoubleClick(EventArgs e)
	{
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
	}

	private void OnClickContextMenu(object sender, EventArgs e)
	{
	}

	private void OnClickViewMenuSubItem(object sender, EventArgs e)
	{
	}

	protected override void OnBeforeLabelEdit(LabelEditEventArgs e)
	{
	}

	protected override void OnAfterLabelEdit(LabelEditEventArgs e)
	{
	}

	private void UpdateMenuItems(MenuItem senderMenuItem)
	{
	}

	private void OnClickNewFolderMenuItem(object sender, EventArgs e)
	{
	}
}
