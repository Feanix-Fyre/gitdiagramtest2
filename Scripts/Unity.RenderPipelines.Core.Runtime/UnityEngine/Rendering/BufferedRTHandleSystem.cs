using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public class BufferedRTHandleSystem : IDisposable
{
	private Dictionary<int, RTHandle[]> m_RTHandles;

	private RTHandleSystem m_RTHandleSystem;

	private bool m_DisposedValue;

	public int maxWidth => 0;

	public int maxHeight => 0;

	public RTHandleProperties rtHandleProperties => default(RTHandleProperties);

	public RTHandle GetFrameRT(int bufferId, int frameIndex)
	{
		return null;
	}

	public void AllocBuffer(int bufferId, Func<RTHandleSystem, int, RTHandle> allocator, int bufferCount)
	{
	}

	public void ReleaseBuffer(int bufferId)
	{
	}

	public void SwapAndSetReferenceSize(int width, int height)
	{
	}

	public void ResetReferenceSize(int width, int height)
	{
	}

	public int GetNumFramesAllocated(int bufferId)
	{
		return 0;
	}

	public Vector2 CalculateRatioAgainstMaxSize(int width, int height)
	{
		return default(Vector2);
	}

	private void Swap()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
	}

	public void ReleaseAll()
	{
	}
}
