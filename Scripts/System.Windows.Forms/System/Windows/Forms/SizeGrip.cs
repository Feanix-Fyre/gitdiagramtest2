using System.Drawing;

namespace System.Windows.Forms;

internal class SizeGrip : Control
{
	private Point capture_point;

	private Control captured_control;

	private int window_w;

	private int window_h;

	private bool hide_pending;

	private bool captured;

	private bool is_virtual;

	private bool enabled;

	private bool fill_background;

	private Rectangle last_painted_area;

	public bool FillBackground
	{
		set
		{
		}
	}

	public bool Virtual
	{
		set
		{
		}
	}

	public Control CapturedControl
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SizeGrip(Control CapturedControl)
	{
	}

	internal static Size GetDefaultSize()
	{
		return default(Size);
	}

	internal static Rectangle GetDefaultRectangle(Control Parent)
	{
		return default(Rectangle);
	}

	private void HandleResize(object sender, EventArgs e)
	{
	}

	private void HandleEnabledChanged(object sender, EventArgs e)
	{
	}

	internal void HandlePaint(object sender, PaintEventArgs e)
	{
	}

	private void HandleMouseCaptureChanged(object sender, EventArgs e)
	{
	}

	internal void HandleMouseDown(object sender, MouseEventArgs e)
	{
	}

	internal void HandleMouseMove(object sender, MouseEventArgs e)
	{
	}

	internal void HandleMouseUp(object sender, MouseEventArgs e)
	{
	}

	protected override void SetVisibleCore(bool value)
	{
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
	}

	protected override void OnMouseCaptureChanged(EventArgs e)
	{
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
	}
}
