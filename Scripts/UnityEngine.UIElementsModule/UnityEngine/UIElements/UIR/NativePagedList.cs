using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

internal class NativePagedList<T> : IDisposable where T : struct
{
	private readonly int k_PoolCapacity;

	private List<NativeArray<T>> m_Pages;

	private NativeArray<T> m_CurrentPage;

	private int m_CurrentPageCount;

	private List<NativeSlice<T>> m_Enumerator;

	protected bool disposed { get; private set; }

	public NativePagedList(int poolCapacity)
	{
	}

	public void Add(ref T data)
	{
	}

	public List<NativeSlice<T>> GetPages()
	{
		return null;
	}

	public void Reset()
	{
	}

	public void Dispose()
	{
	}

	protected void Dispose(bool disposing)
	{
	}
}
