using System.Drawing;

namespace System.Windows.Forms;

internal class FormWindowManager : InternalWindowManager
{
	private bool pending_activation;

	internal override Rectangle MaximizedBounds => default(Rectangle);

	public FormWindowManager(Form form)
		: base(null)
	{
	}

	private void HandleCaptureChanged(object sender, EventArgs e)
	{
	}

	public override void PointToClient(ref int x, ref int y)
	{
	}

	protected override bool HandleNCLButtonDown(ref Message m)
	{
		return false;
	}

	protected override void HandleTitleBarDoubleClick(int x, int y)
	{
	}
}
