using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Pointer)]
public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEventInternal where T : PointerCaptureEventBase<T>, new()
{
	private IEventHandler relatedTarget
	{
		[CompilerGenerated]
		set
		{
			_003CrelatedTarget_003Ek__BackingField = value;
		}
	}

	public int pointerId { get; private set; }

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId)
	{
		return null;
	}
}
