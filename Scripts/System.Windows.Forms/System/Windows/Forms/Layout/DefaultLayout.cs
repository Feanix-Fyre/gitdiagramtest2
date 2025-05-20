using System.Drawing;

namespace System.Windows.Forms.Layout;

internal class DefaultLayout : LayoutEngine
{
	private void LayoutDockedChildren(Control parent, Control[] controls)
	{
	}

	private void LayoutAnchoredChildren(Control parent, Control[] controls)
	{
	}

	private void LayoutAutoSizedChildren(Control parent, Control[] controls)
	{
	}

	private void LayoutAutoSizeContainer(Control container)
	{
	}

	public override bool Layout(object container, LayoutEventArgs args)
	{
		return false;
	}

	private Size GetPreferredControlSize(Control child)
	{
		return default(Size);
	}
}
