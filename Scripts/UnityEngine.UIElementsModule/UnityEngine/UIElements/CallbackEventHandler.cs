using System;

namespace UnityEngine.UIElements;

public abstract class CallbackEventHandler : IEventHandler
{
	internal bool isIMGUIContainer;

	private EventCallbackRegistry m_CallbackRegistry;

	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction";

	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget";

	public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	private void AddEventCategories<TEventType>() where TEventType : EventBase<TEventType>, new()
	{
	}

	public void RegisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	public abstract void SendEvent(EventBase e);

	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);

	internal void HandleEventAtTargetPhase(EventBase evt)
	{
	}

	internal void HandleEventAtTargetAndDefaultPhase(EventBase evt)
	{
	}

	internal void HandleEventAtCurrentTargetAndPhase(EventBase evt)
	{
	}

	void IEventHandler.HandleEvent(EventBase evt)
	{
	}

	[Obsolete("The virtual method CallbackEventHandler.HandleEvent is deprecated and will be removed in a future release. Please override ExecuteDefaultAction instead.")]
	public virtual void HandleEvent(EventBase evt)
	{
	}

	public bool HasTrickleDownHandlers()
	{
		return false;
	}

	public bool HasBubbleUpHandlers()
	{
		return false;
	}

	[EventInterest(EventInterestOptions.Inherit)]
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}

	[EventInterest(EventInterestOptions.Inherit)]
	protected virtual void ExecuteDefaultAction(EventBase evt)
	{
	}

	[EventInterest(EventInterestOptions.Inherit)]
	internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
	{
	}

	[EventInterest(EventInterestOptions.Inherit)]
	internal virtual void ExecuteDefaultActionDisabled(EventBase evt)
	{
	}
}
