using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides a menu system for a form.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class MenuStrip : ToolStrip
{
	private ToolStripMenuItem mdi_window_list_item;

	private static object MenuActivateEvent;

	private static object MenuDeactivateEvent;

	internal bool MenuDroppedDown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuStrip.MenuActivate" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnMenuActivate(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MenuStrip.MenuDeactivate" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnMenuDeactivate(EventArgs e)
	{
	}

	internal void FireMenuActivate()
	{
	}

	internal void FireMenuDeactivate()
	{
	}

	internal override bool OnMenuKey()
	{
		return false;
	}

	private void ToolStripMenuTracker_AppFocusChange(object sender, EventArgs e)
	{
	}

	private void ToolStripMenuTracker_AppClicked(object sender, EventArgs e)
	{
	}

	internal void RefreshMdiItems()
	{
	}

	private ToolStripMenuItem FindMdiMenuItemOfForm(Form f)
	{
		return null;
	}

	private int CountMdiMenuItems()
	{
		return 0;
	}

	private bool NeedToReorderMdi()
	{
		return false;
	}

	private void ReorderMdiMenu()
	{
	}
}
