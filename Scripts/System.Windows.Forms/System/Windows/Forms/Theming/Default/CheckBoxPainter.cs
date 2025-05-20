using System.Drawing;

namespace System.Windows.Forms.Theming.Default;

internal class CheckBoxPainter
{
	protected SystemResPool ResPool => null;

	private Color ColorControl => default(Color);

	public void PaintCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, ElementState state, FlatStyle style, CheckState checkState)
	{
	}

	public virtual void DrawNormalCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawHotCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawPressedCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawDisabledCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawFlatNormalCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawFlatHotCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawFlatPressedCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawFlatDisabledCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawPopupNormalCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawPopupHotCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawPopupPressedCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawPopupDisabledCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public virtual void DrawCheck(Graphics g, Rectangle bounds, Color checkColor)
	{
	}

	private int Clamp(int value, int lower, int upper)
	{
		return 0;
	}
}
