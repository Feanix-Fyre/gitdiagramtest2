using System;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

internal class Page : IDisposable
{
	public class DataSet<T> : IDisposable where T : struct
	{
		public Utility.GPUBuffer<T> gpuData;

		public NativeArray<T> cpuData;

		public NativeArray<GfxUpdateBufferRange> updateRanges;

		public GPUBufferAllocator allocator;

		private readonly uint m_UpdateRangePoolSize;

		private uint m_ElemStride;

		private uint m_UpdateRangeMin;

		private uint m_UpdateRangeMax;

		private uint m_UpdateRangesEnqueued;

		private uint m_UpdateRangesBatchStart;

		private bool m_UpdateRangesSaturated;

		protected bool disposed { get; private set; }

		public DataSet(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer)
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		public void RegisterUpdate(uint start, uint size)
		{
		}

		private bool HasMappedBufferRange()
		{
			return false;
		}

		public void SendUpdates()
		{
		}

		public void SendFullRange()
		{
		}

		public void SendPartialRanges()
		{
		}

		private void ResetUpdateState()
		{
		}
	}

	public DataSet<Vertex> vertices;

	public DataSet<ushort> indices;

	public Page next;

	public int framesEmpty;

	protected bool disposed { get; private set; }

	public bool isEmpty => false;

	public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
