using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class Clickable : PointerManipulator
{
	private readonly long m_Delay;

	private readonly long m_Interval;

	private int m_ActivePointerId;

	private bool m_AcceptClicksIfDisabled;

	private IVisualElementScheduledItem m_Repeater;

	protected bool active { get; set; }

	public Vector2 lastMousePosition { get; private set; }

	internal bool acceptClicksIfDisabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private InvokePolicy invokePolicy => default(InvokePolicy);

	public event Action<EventBase> clickedWithEventInfo
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action clicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public Clickable(Action handler, long delay, long interval)
	{
	}

	public Clickable(Action<EventBase> handler)
	{
	}

	public Clickable(Action handler)
	{
	}

	private void OnTimer(TimerState timerState)
	{
	}

	private bool IsRepeatable()
	{
		return false;
	}

	protected override void RegisterCallbacksOnTarget()
	{
	}

	protected override void UnregisterCallbacksFromTarget()
	{
	}

	protected void OnMouseDown(MouseDownEvent evt)
	{
	}

	protected void OnMouseMove(MouseMoveEvent evt)
	{
	}

	protected void OnMouseUp(MouseUpEvent evt)
	{
	}

	private void OnMouseCaptureOut(MouseCaptureOutEvent evt)
	{
	}

	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
	{
	}

	private bool ContainsPointer(int pointerId)
	{
		return false;
	}

	private static bool IsNotMouseEvent(int pointerId)
	{
		return false;
	}

	protected void Invoke(EventBase evt)
	{
	}

	internal void SimulateSingleClick(EventBase evt, int delayMs = 100)
	{
	}

	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
	{
	}

	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	protected virtual void ProcessCancelEvent(EventBase evt, int pointerId)
	{
	}
}
