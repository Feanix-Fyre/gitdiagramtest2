using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Displays a message window, also known as a dialog box, which presents a message to the user. It is a modal window, blocking other actions in the application until the user closes it. A <see cref="T:System.Windows.Forms.MessageBox" /> can contain text, buttons, and symbols that inform and instruct the user.</summary>
public class MessageBox
{
	internal class MessageBoxForm : Form
	{
		private string msgbox_text;

		private bool size_known;

		private Icon icon_image;

		private RectangleF text_rect;

		private MessageBoxButtons msgbox_buttons;

		private MessageBoxDefaultButton msgbox_default;

		private bool buttons_placed;

		private int button_left;

		private Button[] buttons;

		private bool show_help;

		private AlertType alert_type;

		protected override CreateParams CreateParams => null;

		public MessageBoxForm(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool displayHelpButton)
		{
		}

		public MessageBoxForm(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton)
		{
		}

		public MessageBoxForm(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
		}

		public DialogResult RunDialog()
		{
			return default(DialogResult);
		}

		internal override void OnPaintInternal(PaintEventArgs e)
		{
		}

		private void InitFormsSize()
		{
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			return false;
		}

		protected override bool ProcessDialogChar(char charCode)
		{
			return false;
		}

		private void Copy()
		{
		}

		private void AddButtons()
		{
		}

		private Button AddButton(string text, int left, EventHandler click_event)
		{
			return null;
		}

		private Button AddOkButton(int left)
		{
			return null;
		}

		private Button AddCancelButton(int left)
		{
			return null;
		}

		private Button AddAbortButton(int left)
		{
			return null;
		}

		private Button AddRetryButton(int left)
		{
			return null;
		}

		private Button AddIgnoreButton(int left)
		{
			return null;
		}

		private Button AddYesButton(int left)
		{
			return null;
		}

		private Button AddNoButton(int left)
		{
			return null;
		}

		private Button AddHelpButton(int left)
		{
			return null;
		}

		private void OkClick(object sender, EventArgs e)
		{
		}

		private void CancelClick(object sender, EventArgs e)
		{
		}

		private void AbortClick(object sender, EventArgs e)
		{
		}

		private void RetryClick(object sender, EventArgs e)
		{
		}

		private void IgnoreClick(object sender, EventArgs e)
		{
		}

		private void YesClick(object sender, EventArgs e)
		{
		}

		private void NoClick(object sender, EventArgs e)
		{
		}
	}

	/// <summary>Displays a message box with specified text, caption, buttons, and icon.</summary>
	/// <param name="text">The text to display in the message box.</param>
	/// <param name="caption">The text to display in the title bar of the message box.</param>
	/// <param name="buttons">One of the <see cref="T:System.Windows.Forms.MessageBoxButtons" /> values that specifies which buttons to display in the message box.</param>
	/// <param name="icon">One of the <see cref="T:System.Windows.Forms.MessageBoxIcon" /> values that specifies which icon to display in the message box.</param>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The <paramref name="buttons" /> parameter specified is not a member of <see cref="T:System.Windows.Forms.MessageBoxButtons" />.  
	///  -or-  
	///  The <paramref name="icon" /> parameter specified is not a member of <see cref="T:System.Windows.Forms.MessageBoxIcon" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An attempt was made to display the <see cref="T:System.Windows.Forms.MessageBox" /> in a process that is not running in User Interactive mode. This is specified by the <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" /> property.</exception>
	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		return default(DialogResult);
	}

	/// <summary>Displays a message box in front of the specified object and with the specified text, caption, buttons, icon, default button, and options.</summary>
	/// <param name="owner">An implementation of <see cref="T:System.Windows.Forms.IWin32Window" /> that will own the modal dialog box.</param>
	/// <param name="text">The text to display in the message box.</param>
	/// <param name="caption">The text to display in the title bar of the message box.</param>
	/// <param name="buttons">One of the <see cref="T:System.Windows.Forms.MessageBoxButtons" /> values that specifies which buttons to display in the message box.</param>
	/// <param name="icon">One of the <see cref="T:System.Windows.Forms.MessageBoxIcon" /> values that specifies which icon to display in the message box.</param>
	/// <param name="defaultButton">One of the <see cref="T:System.Windows.Forms.MessageBoxDefaultButton" /> values the specifies the default button for the message box.</param>
	/// <param name="options">One of the <see cref="T:System.Windows.Forms.MessageBoxOptions" /> values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
	///   <paramref name="buttons" /> is not a member of <see cref="T:System.Windows.Forms.MessageBoxButtons" />.  
	/// -or-  
	/// <paramref name="icon" /> is not a member of <see cref="T:System.Windows.Forms.MessageBoxIcon" />.  
	/// -or-  
	/// <paramref name="defaultButton" /> is not a member of <see cref="T:System.Windows.Forms.MessageBoxDefaultButton" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An attempt was made to display the <see cref="T:System.Windows.Forms.MessageBox" /> in a process that is not running in User Interactive mode. This is specified by the <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" /> property.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> specified both <see cref="F:System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly" /> and <see cref="F:System.Windows.Forms.MessageBoxOptions.ServiceNotification" />.  
	/// -or-  
	/// <paramref name="options" /> specified <see cref="F:System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly" /> or <see cref="F:System.Windows.Forms.MessageBoxOptions.ServiceNotification" /> and specified a value in the <paramref name="owner" /> parameter. These two options should be used only if you invoke the version of this method that does not take an <paramref name="owner" /> parameter.  
	/// -or-  
	/// <paramref name="buttons" /> specified an invalid combination of <see cref="T:System.Windows.Forms.MessageBoxButtons" />.</exception>
	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
	{
		return default(DialogResult);
	}
}
