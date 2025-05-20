using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Specifies identifiers to indicate the return value of a dialog box.</summary>
[ComVisible(true)]
public enum DialogResult
{
	/// <summary>
	///   <see langword="Nothing" /> is returned from the dialog box. This means that the modal dialog continues running.</summary>
	None = 0,
	/// <summary>The dialog box return value is <see langword="OK" /> (usually sent from a button labeled OK).</summary>
	OK = 1,
	/// <summary>The dialog box return value is <see langword="Cancel" /> (usually sent from a button labeled Cancel).</summary>
	Cancel = 2,
	/// <summary>The dialog box return value is <see langword="Abort" /> (usually sent from a button labeled Abort).</summary>
	Abort = 3,
	/// <summary>The dialog box return value is <see langword="Retry" /> (usually sent from a button labeled Retry).</summary>
	Retry = 4,
	/// <summary>The dialog box return value is <see langword="Ignore" /> (usually sent from a button labeled Ignore).</summary>
	Ignore = 5,
	/// <summary>The dialog box return value is <see langword="Yes" /> (usually sent from a button labeled Yes).</summary>
	Yes = 6,
	/// <summary>The dialog box return value is <see langword="No" /> (usually sent from a button labeled No).</summary>
	No = 7
}
