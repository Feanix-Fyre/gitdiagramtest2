namespace System.Windows.Forms;

internal class ToolWindowManager : InternalWindowManager
{
	public ToolWindowManager(Form form)
		: base(null)
	{
	}

	public override void SetWindowState(FormWindowState old_state, FormWindowState window_state)
	{
	}
}
