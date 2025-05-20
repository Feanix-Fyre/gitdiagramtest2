using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Displays a dialog box from which the user can select a file.</summary>
[DefaultEvent("FileOk")]
[DefaultProperty("FileName")]
public abstract class FileDialog : CommonDialog
{
	internal enum FileDialogType
	{
		OpenFileDialog = 0,
		SaveFileDialog = 1
	}

	private class FileNamesTokenizer
	{
		private readonly bool _allowMultiple;

		private int _position;

		private readonly string _text;

		private TokenType _tokenType;

		private string _tokenText;

		public TokenType CurrentToken => default(TokenType);

		public string TokenText => null;

		public bool AllowMultiple => false;

		public FileNamesTokenizer(string text, bool allowMultiple)
		{
		}

		private int ReadChar()
		{
			return 0;
		}

		private int PeekChar()
		{
			return 0;
		}

		private void SkipWhitespaceAndQuotes()
		{
		}

		public void GetNextFile()
		{
		}
	}

	internal enum TokenType
	{
		BOF = 0,
		EOF = 1,
		FileName = 2
	}

	/// <summary>Owns the <see cref="E:System.Windows.Forms.FileDialog.FileOk" /> event.</summary>
	protected static readonly object EventFileOk;

	private static int MaxFileNameItems;

	private bool addExtension;

	private bool checkFileExists;

	private bool checkPathExists;

	private string defaultExt;

	private bool dereferenceLinks;

	private string[] fileNames;

	private string filter;

	private int filterIndex;

	private string initialDirectory;

	private bool restoreDirectory;

	private bool showHelp;

	private string title;

	private bool validateNames;

	private bool auto_upgrade_enable;

	private FileDialogCustomPlacesCollection custom_places;

	private bool supportMultiDottedExtensions;

	private bool checkForIllegalChars;

	private Button cancelButton;

	private ToolBarButton upToolBarButton;

	private PopupButtonPanel popupButtonPanel;

	private Button openSaveButton;

	private Button helpButton;

	private Label fileTypeLabel;

	private ToolBarButton menueToolBarButton;

	private ContextMenu menueToolBarButtonContextMenu;

	private ToolBar smallButtonToolBar;

	private DirComboBox dirComboBox;

	private ComboBox fileNameComboBox;

	private Label fileNameLabel;

	private MWFFileView mwfFileView;

	private MwfFileViewItemComparer file_view_comparer;

	private Label searchSaveLabel;

	private ToolBarButton newdirToolBarButton;

	private ToolBarButton backToolBarButton;

	private ComboBox fileTypeComboBox;

	private ImageList imageListTopToolbar;

	private CheckBox readonlyCheckBox;

	private bool multiSelect;

	private string restoreDirectoryString;

	internal FileDialogType fileDialogType;

	private bool do_not_call_OnSelectedIndexChangedFileTypeComboBox;

	private bool showReadOnly;

	private bool readOnlyChecked;

	internal bool createPrompt;

	internal bool overwritePrompt;

	private FileFilter fileFilter;

	private string[] configFileNames;

	private string lastFolder;

	private MWFVFS vfs;

	private readonly char[] wildcard_chars;

	private bool disable_form_closed_event;

	/// <summary>Gets or sets a value indicating whether the dialog box automatically adds an extension to a file name if the user omits the extension.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box adds an extension to a file name if the user omits the extension; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool AddExtension
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box displays a warning if the user specifies a file name that does not exist; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public virtual bool CheckFileExists
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the dialog box displays a warning if the user specifies a path that does not exist.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box displays a warning when the user specifies a path that does not exist; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool CheckPathExists
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the default file name extension.</summary>
	/// <returns>The default file name extension. The returned string does not include the period. The default value is an empty string ("").</returns>
	[DefaultValue(null)]
	public string DefaultExt
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the dialog box returns the location of the file referenced by the shortcut or whether it returns the location of the shortcut (.lnk).</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box returns the location of the file referenced by the shortcut; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool DereferenceLinks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a string containing the file name selected in the file dialog box.</summary>
	/// <returns>The file name selected in the file dialog box. The default value is an empty string ("").</returns>
	[DefaultValue(null)]
	public string FileName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the file names of all selected files in the dialog box.</summary>
	/// <returns>An array of type <see cref="T:System.String" />, containing the file names of all selected files in the dialog box.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public string[] FileNames => null;

	/// <summary>Gets or sets the current file name filter string, which determines the choices that appear in the "Save as file type" or "Files of type" box in the dialog box.</summary>
	/// <returns>The file filtering options available in the dialog box.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="Filter" /> format is invalid.</exception>
	[Localizable(true)]
	[DefaultValue(null)]
	public string Filter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the index of the filter currently selected in the file dialog box.</summary>
	/// <returns>A value containing the index of the filter currently selected in the file dialog box. The default value is 1.</returns>
	[DefaultValue(1)]
	public int FilterIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the initial directory displayed by the file dialog box.</summary>
	/// <returns>The initial directory displayed by the file dialog box. The default is an empty string ("").</returns>
	[DefaultValue(null)]
	public string InitialDirectory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the dialog box restores the directory to the previously selected directory before closing.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box restores the current directory to the previously selected directory if the user changed the directory while searching for files; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool RestoreDirectory
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the Help button is displayed in the file dialog box.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box includes a help button; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool ShowHelp
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets whether the dialog box supports displaying and saving files that have multiple file name extensions.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box supports multiple file name extensions; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool SupportMultiDottedExtensions
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the file dialog box title.</summary>
	/// <returns>The file dialog box title. The default value is an empty string ("").</returns>
	[DefaultValue(null)]
	[Localizable(true)]
	public string Title
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the dialog box accepts only valid Win32 file names.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box accepts only valid Win32 file names; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool ValidateNames
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal virtual string DialogTitle => null;

	internal virtual bool ShowReadOnly
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal virtual bool ReadOnlyChecked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool BMultiSelect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal string OpenSaveButtonText
	{
		set
		{
		}
	}

	internal string SearchSaveLabel
	{
		set
		{
		}
	}

	internal string FileTypeLabel
	{
		set
		{
		}
	}

	internal string CustomFilter => null;

	/// <summary>Occurs when the user clicks on the Open or Save button on a file dialog box.</summary>
	public event CancelEventHandler FileOk
	{
		add
		{
		}
		remove
		{
		}
	}

	internal FileDialog()
	{
	}

	/// <summary>Resets all properties to their default values.</summary>
	public override void Reset()
	{
	}

	/// <summary>Provides a string version of this object.</summary>
	/// <returns>A string version of this object.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.FileDialog.FileOk" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
	protected void OnFileOk(CancelEventArgs e)
	{
	}

	private void CleanupOnClose()
	{
	}

	/// <summary>Specifies a common dialog box.</summary>
	/// <param name="hWndOwner">A value that represents the window handle of the owner window for the common dialog box.</param>
	/// <returns>
	///   <see langword="true" /> if the file could be opened; otherwise, <see langword="false" />.</returns>
	protected override bool RunDialog(IntPtr hWndOwner)
	{
		return false;
	}

	private void SelectFilter()
	{
	}

	private void SetFileAndDirectory(string fname)
	{
	}

	private void OnClickOpenSaveButton(object sender, EventArgs e)
	{
	}

	private bool AddFilterExtension(string fileName)
	{
		return false;
	}

	private string GetExtension(string fileName)
	{
		return null;
	}

	private void OnClickCancelButton(object sender, EventArgs e)
	{
	}

	private void OnClickHelpButton(object sender, EventArgs e)
	{
	}

	private void OnClickSmallButtonToolBar(object sender, ToolBarButtonClickEventArgs e)
	{
	}

	private void OnSelectedIndexChangedFileTypeComboBox(object sender, EventArgs e)
	{
	}

	private void OnSelectedFileChangedFileView(object sender, EventArgs e)
	{
	}

	private void OnSelectedFilesChangedFileView(object sender, EventArgs e)
	{
	}

	private void OnForceDialogEndFileView(object sender, EventArgs e)
	{
	}

	private void OnDirectoryChangedDirComboBox(object sender, EventArgs e)
	{
	}

	private void OnDirectoryChangedPopupButtonPanel(object sender, EventArgs e)
	{
	}

	private void OnCheckCheckChanged(object sender, EventArgs e)
	{
	}

	private void OnFileDialogFormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void OnColumnClickFileView(object sender, ColumnClickEventArgs e)
	{
	}

	private void HandleFormClosedEvent(object sender)
	{
	}

	private void UpdateFilters()
	{
	}

	private void UpdateRecentFiles()
	{
	}

	private void ResizeAndRelocateForHelpOrReadOnly()
	{
	}

	private void WriteConfigValues()
	{
	}

	private void ReadConfigValues()
	{
	}
}
