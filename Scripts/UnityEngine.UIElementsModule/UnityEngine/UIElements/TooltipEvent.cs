using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Tooltip)]
public class TooltipEvent : EventBase<TooltipEvent>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003Ctooltip_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Rect _003Crect_003Ek__BackingField;

	public string tooltip
	{
		[CompilerGenerated]
		set
		{
			_003Ctooltip_003Ek__BackingField = value;
		}
	}

	public Rect rect
	{
		[CompilerGenerated]
		set
		{
			_003Crect_003Ek__BackingField = value;
		}
	}

	static TooltipEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}
}
