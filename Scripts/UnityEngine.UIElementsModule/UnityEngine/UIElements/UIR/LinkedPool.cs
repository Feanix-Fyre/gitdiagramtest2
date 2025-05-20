using System;

namespace UnityEngine.UIElements.UIR;

internal class LinkedPool<T> where T : LinkedPoolItem<T>
{
	private readonly Func<T> m_CreateFunc;

	private readonly Action<T> m_ResetAction;

	private readonly int m_Limit;

	private T m_PoolFirst;

	public int Count { get; private set; }

	public LinkedPool(Func<T> createFunc, Action<T> resetAction, int limit = 10000)
	{
	}

	public void Clear()
	{
	}

	public T Get()
	{
		return null;
	}

	public void Return(T item)
	{
	}
}
