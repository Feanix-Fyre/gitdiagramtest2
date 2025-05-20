using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal class UIRAtlasAllocator : IDisposable
{
	private class Row
	{
		private static ObjectPool<Row> s_Pool;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _003Cheight_003Ek__BackingField;

		public int Cursor;

		public int offsetX { get; private set; }

		public int offsetY { get; private set; }

		public int width { get; private set; }

		private int height
		{
			[CompilerGenerated]
			set
			{
				_003Cheight_003Ek__BackingField = value;
			}
		}

		public static Row Acquire(int offsetX, int offsetY, int width, int height)
		{
			return null;
		}

		public void Release()
		{
		}
	}

	private class AreaNode
	{
		private static ObjectPool<AreaNode> s_Pool;

		public RectInt rect;

		public AreaNode previous;

		public AreaNode next;

		public static AreaNode Acquire(RectInt rect)
		{
			return null;
		}

		public void Release()
		{
		}

		public void RemoveFromChain()
		{
		}

		public void AddAfter(AreaNode previous)
		{
		}
	}

	private AreaNode m_FirstUnpartitionedArea;

	private Row[] m_OpenRows;

	private int m_1SidePadding;

	private int m_2SidePadding;

	private static ProfilerMarker s_MarkerTryAllocate;

	public int maxAtlasSize { get; }

	public int maxImageWidth { get; }

	public int maxImageHeight { get; }

	public int virtualWidth { get; private set; }

	public int virtualHeight { get; private set; }

	public int physicalWidth { get; private set; }

	public int physicalHeight { get; private set; }

	protected bool disposed { get; private set; }

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	private static int GetLog2OfNextPower(int n)
	{
		return 0;
	}

	public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1)
	{
	}

	public bool TryAllocate(int width, int height, out RectInt location)
	{
		location = default(RectInt);
		return false;
	}

	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth)
	{
		return false;
	}

	private void BuildAreas()
	{
	}
}
