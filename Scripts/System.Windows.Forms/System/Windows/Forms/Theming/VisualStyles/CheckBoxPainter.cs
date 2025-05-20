using System.Drawing;
using System.Windows.Forms.Theming.Default;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms.Theming.VisualStyles;

internal class CheckBoxPainter : System.Windows.Forms.Theming.Default.CheckBoxPainter
{
	public override void DrawNormalCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public override void DrawHotCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public override void DrawPressedCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	public override void DrawDisabledCheckBox(Graphics g, Rectangle bounds, Color backColor, Color foreColor, CheckState state)
	{
	}

	private static void DrawCheckBox(Graphics g, Rectangle bounds, CheckBoxState state)
	{
	}
}
