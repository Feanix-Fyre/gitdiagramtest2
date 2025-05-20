namespace System.Windows.Forms;

internal class LabelEditTextBox : FixedSizeTextBox
{
	public event EventHandler EditingCancelled
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EventHandler EditingFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public LabelEditTextBox()
		: base(fixed_horz: false, fixed_vert: false)
	{
	}

	protected override bool IsInputKey(Keys key_data)
	{
		return false;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
	}

	protected override void OnLostFocus(EventArgs e)
	{
	}

	protected void OnEditingCancelled(EventArgs e)
	{
	}

	protected void OnEditingFinished(EventArgs e)
	{
	}
}
