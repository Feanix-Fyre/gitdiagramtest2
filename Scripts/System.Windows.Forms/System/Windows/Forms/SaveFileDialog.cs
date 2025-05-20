using System.ComponentModel;
using System.IO;

namespace System.Windows.Forms;

/// <summary>Prompts the user to select a location for saving a file. This class cannot be inherited.</summary>
[Designer("System.Windows.Forms.Design.SaveFileDialogDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
public sealed class SaveFileDialog : FileDialog
{
	/// <summary>Gets or sets a value indicating whether the dialog box prompts the user for permission to create a file if the user specifies a file that does not exist.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box prompts the user before creating a file if the user specifies a file name that does not exist; <see langword="false" /> if the dialog box automatically creates the new file without prompting the user for permission. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool CreatePrompt
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see langword="Save As" /> dialog box displays a warning if the user specifies a file name that already exists.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box prompts the user before overwriting an existing file if the user specifies a file name that already exists; <see langword="false" /> if the dialog box automatically overwrites the existing file without prompting the user for permission. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool OverwritePrompt
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal override string DialogTitle => null;

	/// <summary>Initializes a new instance of this class.</summary>
	public SaveFileDialog()
	{
	}

	/// <summary>Opens the file with read/write permission selected by the user.</summary>
	/// <returns>The read/write file selected by the user.</returns>
	public Stream OpenFile()
	{
		return null;
	}

	/// <summary>Resets all dialog box options to their default values.</summary>
	public override void Reset()
	{
	}
}
