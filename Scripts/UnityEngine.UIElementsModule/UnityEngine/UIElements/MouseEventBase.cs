using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Pointer)]
public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal where T : MouseEventBase<T>, new()
{
	public EventModifiers modifiers { get; protected set; }

	public Vector2 mousePosition { get; protected set; }

	public Vector2 localMousePosition { get; internal set; }

	public Vector2 mouseDelta { get; protected set; }

	public int clickCount { get; protected set; }

	public int button { get; protected set; }

	public int pressedButtons { get; protected set; }

	public bool shiftKey => false;

	public bool ctrlKey => false;

	public bool commandKey => false;

	public bool altKey => false;

	bool IMouseEventInternal.triggeredByOS
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	bool IMouseEventInternal.recomputeTopElementUnderMouse
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	IPointerEvent IMouseEventInternal.sourcePointerEvent
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override IEventHandler currentTarget
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	protected internal override void PreDispatch(IPanel panel)
	{
	}

	protected internal override void PostDispatch(IPanel panel)
	{
	}

	public static T GetPooled(Event systemEvent)
	{
		return null;
	}

	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse)
	{
		return null;
	}

	public static T GetPooled(IMouseEvent triggerEvent)
	{
		return null;
	}

	protected static T GetPooled(IPointerEvent pointerEvent)
	{
		return null;
	}
}
