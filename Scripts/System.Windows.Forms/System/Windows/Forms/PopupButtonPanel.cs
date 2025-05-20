using System.Drawing;

namespace System.Windows.Forms;

internal class PopupButtonPanel : Control, IUpdateFolder
{
	internal class PopupButton : Control
	{
		internal enum PopupButtonState
		{
			Normal = 0,
			Down = 1,
			Up = 2
		}

		private Image image;

		private PopupButtonState popupButtonState;

		private StringFormat text_format;

		private Rectangle text_rect;

		public Image Image
		{
			set
			{
			}
		}

		public PopupButtonState ButtonState
		{
			get
			{
				return default(PopupButtonState);
			}
			set
			{
			}
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
		}

		private void Draw(PaintEventArgs pe)
		{
		}

		protected override void OnMouseEnter(EventArgs e)
		{
		}

		protected override void OnMouseLeave(EventArgs e)
		{
		}

		protected override void OnClick(EventArgs e)
		{
		}
	}

	private PopupButton recentlyusedButton;

	private PopupButton desktopButton;

	private PopupButton personalButton;

	private PopupButton mycomputerButton;

	private PopupButton networkButton;

	private PopupButton lastPopupButton;

	private PopupButton focusButton;

	private string currentPath;

	private int currentFocusIndex;

	private static object UIAFocusedItemChangedEvent;

	private static object PDirectoryChangedEvent;

	public string CurrentFolder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event EventHandler DirectoryChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	private void OnClickButton(object sender, EventArgs e)
	{
	}

	internal void OnUIAFocusedItemChanged()
	{
	}

	protected override void OnGotFocus(EventArgs e)
	{
	}

	protected override void OnLostFocus(EventArgs e)
	{
	}

	protected override bool IsInputKey(Keys key)
	{
		return false;
	}

	private void Key_Down(object sender, KeyEventArgs e)
	{
	}

	internal void SetFocusButton(PopupButton button)
	{
	}
}
