using System.Drawing;
using System.Windows.Forms.Layout;

namespace System.Windows.Forms;

internal class ToolStripSplitStackLayout : LayoutEngine
{
	public override bool Layout(object container, LayoutEventArgs args)
	{
		return false;
	}

	private void LayoutHorizontalToolStrip(ToolStrip ts, Rectangle bounds)
	{
	}

	private void LayoutVerticalToolStrip(ToolStrip ts, Rectangle bounds)
	{
	}
}
