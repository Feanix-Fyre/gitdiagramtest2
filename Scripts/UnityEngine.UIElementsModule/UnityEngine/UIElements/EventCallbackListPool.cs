using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class EventCallbackListPool
{
	private readonly Stack<EventCallbackList> m_Stack;

	public EventCallbackList Get(EventCallbackList initializer)
	{
		return null;
	}

	public void Release(EventCallbackList element)
	{
	}
}
