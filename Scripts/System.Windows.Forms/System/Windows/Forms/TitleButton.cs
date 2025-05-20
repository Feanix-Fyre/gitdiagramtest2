using System.Drawing;

namespace System.Windows.Forms;

internal class TitleButton
{
	public Rectangle Rectangle;

	public ButtonState State;

	public CaptionButton Caption;

	private EventHandler Clicked;

	public bool Visible;

	private bool entered;

	public bool Entered
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public TitleButton(CaptionButton caption, EventHandler clicked)
	{
	}

	public void OnClick()
	{
	}
}
