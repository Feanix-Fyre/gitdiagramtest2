using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public class DropdownMenu
{
	private List<DropdownMenuItem> m_MenuItems;

	private DropdownMenuEventInfo m_DropdownMenuEventInfo;

	public List<DropdownMenuItem> MenuItems()
	{
		return null;
	}

	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData = null)
	{
	}

	public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.Normal)
	{
	}

	public void AppendSeparator(string subMenuPath = null)
	{
	}

	public void InsertSeparator(string subMenuPath, int atIndex)
	{
	}

	public void PrepareForDisplay(EventBase e)
	{
	}
}
