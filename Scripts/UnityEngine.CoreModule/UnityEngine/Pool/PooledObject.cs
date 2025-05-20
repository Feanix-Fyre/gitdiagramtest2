using System;

namespace UnityEngine.Pool;

public struct PooledObject<T> : IDisposable where T : class
{
	private readonly T m_ToReturn;

	private readonly IObjectPool<T> m_Pool;

	public PooledObject(T value, IObjectPool<T> pool)
	{
		m_ToReturn = null;
		m_Pool = null;
	}

	void IDisposable.Dispose()
	{
	}
}
