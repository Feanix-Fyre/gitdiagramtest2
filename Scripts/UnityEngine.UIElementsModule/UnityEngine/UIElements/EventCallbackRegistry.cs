using System;

namespace UnityEngine.UIElements;

internal class EventCallbackRegistry
{
	private static readonly EventCallbackListPool s_ListPool;

	private EventCallbackList m_Callbacks;

	private EventCallbackList m_TemporaryCallbacks;

	private int m_IsInvoking;

	private static EventCallbackList GetCallbackList(EventCallbackList initializer = null)
	{
		return null;
	}

	private static void ReleaseCallbackList(EventCallbackList toRelease)
	{
	}

	private EventCallbackList GetCallbackListForWriting()
	{
		return null;
	}

	private EventCallbackList GetCallbackListForReading()
	{
		return null;
	}

	private bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown)
	{
		return false;
	}

	public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
	{
	}

	public void RegisterCallback<TEventType, TCallbackArgs>(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
	{
	}

	public bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
		return false;
	}

	public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase)
	{
	}

	public bool HasTrickleDownHandlers()
	{
		return false;
	}

	public bool HasBubbleHandlers()
	{
		return false;
	}
}
