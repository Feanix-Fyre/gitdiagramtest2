using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.UIR;

internal class Allocator2D
{
	public class Area
	{
		public RectInt rect;

		public BestFitAllocator allocator;

		public Area(RectInt rect)
		{
		}
	}

	public class Row : LinkedPoolItem<Row>
	{
		public RectInt rect;

		public Area area;

		public BestFitAllocator allocator;

		public Alloc alloc;

		public Row next;

		public static readonly LinkedPool<Row> pool;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Row Create()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Reset(Row row)
		{
		}
	}

	public struct Alloc2D
	{
		public RectInt rect;

		public Row row;

		public Alloc alloc;

		public Alloc2D(Row row, Alloc alloc, int width, int height)
		{
			rect = default(RectInt);
			this.row = null;
			this.alloc = default(Alloc);
		}
	}

	private readonly Vector2Int m_MinSize;

	private readonly Vector2Int m_MaxSize;

	private readonly Vector2Int m_MaxAllocSize;

	private readonly int m_RowHeightBias;

	private readonly Row[] m_Rows;

	private readonly List<Area> m_Areas;

	public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias)
	{
	}

	public bool TryAllocate(int width, int height, out Alloc2D alloc2D)
	{
		alloc2D = default(Alloc2D);
		return false;
	}

	public void Free(Alloc2D alloc2D)
	{
	}

	private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize)
	{
	}

	private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias)
	{
		return default(Vector2Int);
	}

	private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias)
	{
		return null;
	}
}
