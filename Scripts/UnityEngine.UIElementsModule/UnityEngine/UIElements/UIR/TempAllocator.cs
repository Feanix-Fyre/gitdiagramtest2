using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

internal class TempAllocator<T> : IDisposable where T : struct
{
	private struct Page
	{
		public NativeArray<T> array;

		public int used;
	}

	private readonly int m_ExcessMinCapacity;

	private readonly int m_ExcessMaxCapacity;

	private Page m_Pool;

	private List<Page> m_Excess;

	private int m_NextExcessSize;

	protected bool disposed { get; private set; }

	public TempAllocator(int poolCapacity, int excessMinCapacity, int excessMaxCapacity)
	{
	}

	public void Dispose()
	{
	}

	protected void Dispose(bool disposing)
	{
	}

	public NativeSlice<T> Alloc(int count)
	{
		return default(NativeSlice<T>);
	}

	public void Reset()
	{
	}

	private void ReleaseExcess()
	{
	}
}
