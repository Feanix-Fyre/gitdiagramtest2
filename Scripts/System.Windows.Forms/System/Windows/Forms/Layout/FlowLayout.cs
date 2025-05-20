using System.Collections.Generic;

namespace System.Windows.Forms.Layout;

internal class FlowLayout : LayoutEngine
{
	private static FlowLayoutSettings default_settings;

	public override bool Layout(object container, LayoutEventArgs args)
	{
		return false;
	}

	private int FinishRow(List<Control> row)
	{
		return 0;
	}

	private int FinishColumn(List<Control> col)
	{
		return 0;
	}

	private bool LayoutToolStrip(ToolStrip parent)
	{
		return false;
	}

	private int FinishRow(List<ToolStripItem> row)
	{
		return 0;
	}

	private int FinishColumn(List<ToolStripItem> col)
	{
		return 0;
	}
}
