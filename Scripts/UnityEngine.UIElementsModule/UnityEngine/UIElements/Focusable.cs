using System;

namespace UnityEngine.UIElements;

public abstract class Focusable : CallbackEventHandler
{
	private bool m_DelegatesFocus;

	private bool m_ExcludeFromFocusRing;

	public abstract FocusController focusController { get; }

	public bool focusable { get; set; }

	public int tabIndex { get; set; }

	public bool delegatesFocus
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool excludeFromFocusRing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool canGrabFocus => false;

	public virtual void Focus()
	{
	}

	public virtual void Blur()
	{
	}

	internal void BlurImmediately()
	{
	}

	private Focusable GetFocusDelegate()
	{
		return null;
	}

	private static Focusable GetFirstFocusableChild(VisualElement ve)
	{
		return null;
	}

	[EventInterest(new Type[]
	{
		typeof(PointerDownEvent),
		typeof(NavigationMoveEvent)
	})]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}

	[EventInterest(new Type[]
	{
		typeof(PointerDownEvent),
		typeof(NavigationMoveEvent)
	})]
	internal override void ExecuteDefaultActionDisabled(EventBase evt)
	{
	}

	private void ProcessEvent(EventBase evt)
	{
	}
}
