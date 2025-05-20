using System.ComponentModel;
using System.IO;

namespace System.Windows.Forms;

/// <summary>Displays a standard dialog box that prompts the user to open a file. This class cannot be inherited.</summary>
public sealed class OpenFileDialog : FileDialog
{
	/// <summary>Gets or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box displays a warning when the user specifies a file name that does not exist; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public override bool CheckFileExists
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the dialog box allows multiple files to be selected.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box allows multiple files to be selected together or concurrently; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool Multiselect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the read-only check box is selected.</summary>
	/// <returns>
	///   <see langword="true" /> if the read-only check box is selected; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public new bool ReadOnlyChecked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the dialog box contains a read-only check box.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box contains a read-only check box; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public new bool ShowReadOnly
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

	/// <summary>Initializes an instance of the <see cref="T:System.Windows.Forms.OpenFileDialog" /> class.</summary>
	public OpenFileDialog()
	{
	}

	/// <summary>Opens the file selected by the user, with read-only permission. The file is specified by the <see cref="P:System.Windows.Forms.FileDialog.FileName" /> property.</summary>
	/// <returns>A <see cref="T:System.IO.Stream" /> that specifies the read-only file selected by the user.</returns>
	/// <exception cref="T:System.ArgumentNullException">The file name is <see langword="null" />.</exception>
	public Stream OpenFile()
	{
		return null;
	}

	/// <summary>Resets all properties to their default values.</summary>
	public override void Reset()
	{
	}
}
