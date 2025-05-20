using System.Collections;
using System.Drawing;

namespace System.Windows.Forms;

internal class MenuTracker
{
	private enum KeyNavState
	{
		Idle = 0,
		Startup = 1,
		NoPopups = 2,
		Navigating = 3
	}

	private enum ItemNavigation
	{
		First = 0,
		Last = 1,
		Next = 2,
		Previous = 3
	}

	internal bool active;

	internal bool popup_active;

	internal bool popdown_menu;

	internal bool hotkey_active;

	private bool mouse_down;

	public Menu CurrentMenu;

	public Menu TopMenu;

	public Control GrabControl;

	private Point last_motion;

	private KeyNavState keynav_state;

	private Hashtable shortcuts;

	public bool Navigating => false;

	public MenuTracker(Menu top_menu)
	{
	}

	internal static Point ScreenToMenu(Menu menu, Point pnt)
	{
		return default(Point);
	}

	private void UpdateCursor()
	{
	}

	internal void Deactivate()
	{
	}

	private MenuItem FindItemByCoords(Menu menu, Point pt)
	{
		return null;
	}

	private MenuItem GetItemAtXY(int x, int y)
	{
		return null;
	}

	public bool OnMouseDown(MouseEventArgs args)
	{
		return false;
	}

	public void OnMotion(MouseEventArgs args)
	{
	}

	public void OnMouseUp(MouseEventArgs args)
	{
	}

	public static bool TrackPopupMenu(Menu menu, Point pnt)
	{
		return false;
	}

	private void DeselectItem(MenuItem item)
	{
	}

	private void SelectItem(Menu menu, MenuItem item, bool execute)
	{
	}

	private void ExecFocusedItem(Menu menu, MenuItem item)
	{
	}

	private void ShowSubPopup(Menu menu, MenuItem item)
	{
	}

	public static void HideSubPopups(Menu menu, Menu topmenu)
	{
	}

	private MenuItem FindSubItemByCoord(Menu menu, Point pnt)
	{
		return null;
	}

	private static MenuItem FindItemByKey(Menu menu, IntPtr key)
	{
		return null;
	}

	private static MenuItem GetNextItem(Menu menu, ItemNavigation navigation)
	{
		return null;
	}

	private void ProcessMenuKey(Msg msg_type)
	{
	}

	private bool ProcessMnemonic(Message msg, Keys key_data)
	{
		return false;
	}

	public void AddShortcuts(MenuItem item)
	{
	}

	public void RemoveShortcuts(MenuItem item)
	{
	}

	private bool ProcessShortcut(Keys keyData)
	{
		return false;
	}

	public bool ProcessKeys(ref Message msg, Keys keyData)
	{
		return false;
	}
}
