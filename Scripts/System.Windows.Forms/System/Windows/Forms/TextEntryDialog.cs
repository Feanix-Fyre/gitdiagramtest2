using System.Drawing;

namespace System.Windows.Forms;

internal class TextEntryDialog : Form
{
	private Label label1;

	private Button okButton;

	private TextBox newNameTextBox;

	private PictureBox iconPictureBox;

	private Button cancelButton;

	private GroupBox groupBox1;

	public Image IconPictureBoxImage
	{
		set
		{
		}
	}

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
}
