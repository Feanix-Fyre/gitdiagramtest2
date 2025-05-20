using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Experimental;

public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003ClinkID_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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

	static PointerUpLinkTagEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText)
	{
		return null;
	}
}
