using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class DropdownMenuAction : DropdownMenuItem
{
	[Flags]
	public enum Status
	{
		None = 0,
		Normal = 1,
		Disabled = 2,
		Checked = 4,
		Hidden = 8
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Status _003Cstatus_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DropdownMenuEventInfo _003CeventInfo_003Ek__BackingField;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object _003CuserData_003Ek__BackingField;

	private readonly Action<DropdownMenuAction> actionCallback;

	private readonly Func<DropdownMenuAction, Status> actionStatusCallback;

	private Status status
	{
		[CompilerGenerated]
		set
		{
			_003Cstatus_003Ek__BackingField = value;
		}
	}

	private DropdownMenuEventInfo eventInfo
	{
		[CompilerGenerated]
		set
		{
			_003CeventInfo_003Ek__BackingField = value;
		}
	}

	private object userData
	{
		[CompilerGenerated]
		set
		{
			_003CuserData_003Ek__BackingField = value;
		}
	}

	public static Status AlwaysEnabled(DropdownMenuAction a)
	{
		return default(Status);
	}

	public static Status AlwaysDisabled(DropdownMenuAction a)
	{
		return default(Status);
	}

	public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null)
	{
	}

	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo)
	{
	}
}
