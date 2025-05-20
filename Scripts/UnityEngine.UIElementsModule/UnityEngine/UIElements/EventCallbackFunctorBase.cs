using System;

namespace UnityEngine.UIElements;

internal abstract class EventCallbackFunctorBase
{
	public CallbackPhase phase { get; }

	public InvokePolicy invokePolicy { get; }

	protected EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy)
	{
	}

	public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase);

	public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);

	protected bool PhaseMatches(PropagationPhase propagationPhase)
	{
		return false;
	}
}
