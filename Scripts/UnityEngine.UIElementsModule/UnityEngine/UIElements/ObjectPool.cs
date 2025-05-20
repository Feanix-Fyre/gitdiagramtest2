using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class ObjectPool<T> where T : new()
{
	private readonly Stack<T> m_Stack;

	private int m_MaxSize;

	internal Func<T> CreateFunc;

	public int maxSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ObjectPool(Func<T> CreateFunc, int maxSize = 100)
	{
	}

	public int Size()
	{
		return 0;
	}

	public T Get()
	{
		return default(T);
	}

	public void Release(T element)
	{
	}
}
