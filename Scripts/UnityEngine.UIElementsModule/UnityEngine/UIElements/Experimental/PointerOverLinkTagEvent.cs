using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Experimental;

[EventCategory(EventCategory.EnterLeave)]
public class PointerOverLinkTagEvent : PointerEventBase<PointerOverLinkTagEvent>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003ClinkID_003Ek__BackingField;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003ClinkText_003Ek__BackingField;

	private string linkID
	{
		[CompilerGenerated]
		set
		{
			_003ClinkID_003Ek__BackingField = value;
		}
	}

	private string linkText
	{
		[CompilerGenerated]
		set
		{
			_003ClinkText_003Ek__BackingField = value;
		}
	}

	static PointerOverLinkTagEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
	{
		return null;
	}
}
