using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Specifies the base class used for displaying dialog boxes on the screen.</summary>
[ToolboxItemFilter("System.Windows.Forms")]
public abstract class CommonDialog : Component
{
	internal class DialogForm : Form
	{
		protected CommonDialog owner;

		protected override CreateParams CreateParams => null;

		internal DialogForm(CommonDialog owner)
		{
		}
	}

	internal DialogForm form;

	/// <summary>Occurs when the user clicks the Help button on a common dialog box.</summary>
	public event EventHandler HelpRequest
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.CommonDialog" /> class.</summary>
	public CommonDialog()
	{
	}

	/// <summary>When overridden in a derived class, resets the properties of a common dialog box to their default values.</summary>
	public abstract void Reset();

	/// <summary>Runs a common dialog box with the specified owner.</summary>
	/// <param name="owner">Any object that implements <see cref="T:System.Windows.Forms.IWin32Window" /> that represents the top-level window that will own the modal dialog box.</param>
	/// <returns>
	///   <see cref="F:System.Windows.Forms.DialogResult.OK" /> if the user clicks OK in the dialog box; otherwise, <see cref="F:System.Windows.Forms.DialogResult.Cancel" />.</returns>
	public DialogResult ShowDialog(IWin32Window owner)
	{
		return default(DialogResult);
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.CommonDialog.HelpRequest" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.HelpEventArgs" /> that provides the event data.</param>
	protected virtual void OnHelpRequest(EventArgs e)
	{
	}

	/// <summary>When overridden in a derived class, specifies a common dialog box.</summary>
	/// <param name="hwndOwner">A value that represents the window handle of the owner window for the common dialog box.</param>
	/// <returns>
	///   <see langword="true" /> if the dialog box was successfully run; otherwise, <see langword="false" />.</returns>
	protected abstract bool RunDialog(IntPtr hwndOwner);
}
