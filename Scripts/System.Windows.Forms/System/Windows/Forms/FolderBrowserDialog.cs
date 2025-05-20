using System.ComponentModel;
using System.Drawing.Design;

namespace System.Windows.Forms;

/// <summary>Prompts the user to select a folder. This class cannot be inherited.</summary>
[DefaultProperty("SelectedPath")]
[Designer("System.Windows.Forms.Design.FolderBrowserDialogDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[DefaultEvent("HelpRequest")]
public sealed class FolderBrowserDialog : CommonDialog
{
	internal class FolderBrowserTreeView : TreeView
	{
		private MWFVFS vfs;

		private new FBTreeNode root_node;

		private FolderBrowserDialog parentDialog;

		private ImageList imageList;

		private Environment.SpecialFolder rootFolder;

		private bool dont_enable;

		private TreeNode node_under_mouse;

		private string parent_real_path;

		private bool dont_do_onbeforeexpand;

		public Environment.SpecialFolder RootFolder
		{
			set
			{
			}
		}

		public string SelectedPath
		{
			set
			{
			}
		}

		public FolderBrowserTreeView(FolderBrowserDialog parent_dialog)
		{
		}

		public void CreateNewFolder()
		{
		}

		protected override void OnAfterLabelEdit(NodeLabelEditEventArgs e)
		{
		}

		private void SetSelectedPath(string path)
		{
		}

		private FBTreeNode FindPathInNodes(string path, TreeNodeCollection nodes)
		{
			return null;
		}

		private bool Check_if_path_is_child_of_RootFolder(string path)
		{
			return false;
		}

		private void FillNode(TreeNode node)
		{
		}

		private void SetupImageList()
		{
		}

		private int NodeImageIndex(string path)
		{
			return 0;
		}

		protected override void OnAfterSelect(TreeViewEventArgs e)
		{
		}

		protected internal override void OnBeforeExpand(TreeViewCancelEventArgs e)
		{
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
		}
	}

	internal class FBTreeNode : TreeNode
	{
		private string realPath;

		public string RealPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FBTreeNode(string text)
			: base((TreeView)null)
		{
		}
	}

	private Environment.SpecialFolder rootFolder;

	private string selectedPath;

	private bool showNewFolderButton;

	private Label descriptionLabel;

	private Button cancelButton;

	private Button okButton;

	private FolderBrowserTreeView folderBrowserTreeView;

	private Button newFolderButton;

	private ContextMenu folderBrowserTreeViewContextMenu;

	private MenuItem newFolderMenuItem;

	private string old_selectedPath;

	private readonly string folderbrowserdialog_string;

	private readonly string width_string;

	private readonly string height_string;

	private readonly string x_string;

	private readonly string y_string;

	/// <summary>Gets or sets the descriptive text displayed above the tree view control in the dialog box.</summary>
	/// <returns>The description to display. The default is an empty string ("").</returns>
	[Browsable(true)]
	[DefaultValue(null)]
	[Localizable(true)]
	public string Description
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the root folder where the browsing starts from.</summary>
	/// <returns>One of the <see cref="T:System.Environment.SpecialFolder" /> values. The default is <see langword="Desktop" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Environment.SpecialFolder" /> values.</exception>
	[Localizable(false)]
	[TypeConverter(typeof(SpecialFolderEnumConverter))]
	[Browsable(true)]
	[DefaultValue(Environment.SpecialFolder.Desktop)]
	public Environment.SpecialFolder RootFolder
	{
		get
		{
			return default(Environment.SpecialFolder);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the path selected by the user.</summary>
	/// <returns>The path of the folder first selected in the dialog box or the last folder selected by the user. The default is an empty string ("").</returns>
	[Browsable(true)]
	[Editor("System.Windows.Forms.Design.SelectedPathEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(true)]
	[DefaultValue(null)]
	public string SelectedPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the New Folder button appears in the folder browser dialog box.</summary>
	/// <returns>
	///   <see langword="true" /> if the New Folder button is shown in the dialog box; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(false)]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool ShowNewFolderButton
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.FolderBrowserDialog" /> class.</summary>
	public FolderBrowserDialog()
	{
	}

	/// <summary>Resets properties to their default values.</summary>
	public override void Reset()
	{
	}

	protected override bool RunDialog(IntPtr hWndOwner)
	{
		return false;
	}

	private void OnClickOKButton(object sender, EventArgs e)
	{
	}

	private void OnClickCancelButton(object sender, EventArgs e)
	{
	}

	private void OnClickNewFolderButton(object sender, EventArgs e)
	{
	}

	private void OnFormVisibleChanged(object sender, EventArgs e)
	{
	}

	private void WriteConfigValues()
	{
	}
}
