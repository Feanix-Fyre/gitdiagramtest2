namespace System.Windows.Forms;

internal class PopUpWindow : Control
{
	private Menu menu;

	private Control form;

	protected override CreateParams CreateParams => null;

	internal override bool ActivateOnShow => false;

	public PopUpWindow(Control form, Menu menu)
	{
	}

	public void ShowWindow()
	{
	}

	internal override void OnPaintInternal(PaintEventArgs args)
	{
	}

	public void HideWindow()
	{
	}

	protected override void CreateHandle()
	{
	}

	internal void RefreshItems()
	{
	}
}
