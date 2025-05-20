using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

internal class ToolBarItem : Component
{
	private ToolBar toolbar;

	private ToolBarButton button;

	private Rectangle bounds;

	private Rectangle image_rect;

	private Rectangle text_rect;

	private bool dd_pressed;

	private bool inside;

	private bool hilight;

	private bool pressed;

	public ToolBarButton Button => null;

	public Rectangle Rectangle => default(Rectangle);

	public Point Location
	{
		get
		{
			return default(Point);
		}
		set
		{
		}
	}

	public Rectangle ImageRectangle => default(Rectangle);

	public Rectangle TextRectangle => default(Rectangle);

	private Size TextSize => default(Size);

	public bool Pressed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DDPressed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Inside
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Hilight
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ToolBarItem(ToolBarButton button)
	{
	}

	public Size CalculateSize()
	{
		return default(Size);
	}

	public bool Layout(bool vertical, int calculated_size)
	{
		return false;
	}

	public bool Layout(Size size)
	{
		return false;
	}

	public void Invalidate()
	{
	}
}
