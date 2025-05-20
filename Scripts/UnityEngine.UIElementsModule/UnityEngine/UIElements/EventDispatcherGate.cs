using System;

namespace UnityEngine.UIElements;

public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate>
{
	private readonly EventDispatcher m_Dispatcher;

	public EventDispatcherGate(EventDispatcher d)
	{
		m_Dispatcher = null;
	}

	public void Dispose()
	{
	}

	public bool Equals(EventDispatcherGate other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
