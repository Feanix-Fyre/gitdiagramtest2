using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class EventCallbackList
{
	private List<EventCallbackFunctorBase> m_List;

	public int trickleDownCallbackCount { get; private set; }

	public int bubbleUpCallbackCount { get; private set; }

	public int Count => 0;

	public EventCallbackFunctorBase this[int i] => null;

	public EventCallbackList()
	{
	}

	public EventCallbackList(EventCallbackList source)
	{
	}

	public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase)
	{
		return false;
	}

	public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase)
	{
		return null;
	}

	public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase)
	{
		return false;
	}

	public void Add(EventCallbackFunctorBase item)
	{
	}

	public void AddRange(EventCallbackList list)
	{
	}

	public void Clear()
	{
	}
}
