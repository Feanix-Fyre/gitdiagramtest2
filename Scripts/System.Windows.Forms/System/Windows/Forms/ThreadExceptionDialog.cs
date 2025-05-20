using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Implements a dialog box that is displayed when an unhandled exception occurs in a thread.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class ThreadExceptionDialog : Form
{
	private Exception e;

	private bool details;

	private Button buttonIgnore;

	private Button buttonAbort;

	private Button buttonDetails;

	private Label labelException;

	private Label label1;

	private TextBox textBoxDetails;

	private Label helpText;

	/// <summary>Gets or sets a value indicating whether the dialog box automatically sizes to its content.</summary>
	/// <returns>
	///   <see langword="true" /> if the dialog box automatically sizes; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool AutoSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ThreadExceptionDialog" /> class.</summary>
	/// <param name="t">The <see cref="T:System.Exception" /> that represents the exception that occurred.</param>
	public ThreadExceptionDialog(Exception t)
	{
	}

	private void InitializeComponent()
	{
	}

	private void buttonDetails_Click(object sender, EventArgs e)
	{
	}

	private void FillExceptionDetails()
	{
	}

	private void RefreshDetails()
	{
	}

	private void buttonAbort_Click(object sender, EventArgs e)
	{
	}

	private void PaintHandler(object o, PaintEventArgs args)
	{
	}
}
