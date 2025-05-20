using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess;

internal struct Tessellator
{
	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TestHullPointL : ICondition2<UHull, float2>
	{
		public bool Test(UHull h, float2 p, ref float t)
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TestHullPointU : ICondition2<UHull, float2>
	{
		public bool Test(UHull h, float2 p, ref float t)
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TestHullEventLe : ICondition2<UHull, UEvent>
	{
		public bool Test(UHull h, UEvent p, ref float t)
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TestHullEventE : ICondition2<UHull, UEvent>
	{
		public bool Test(UHull h, UEvent p, ref float t)
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TestEdgePointE : ICondition2<int2, int2>
	{
		public bool Test(int2 h, int2 p, ref float t)
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TestCellE : ICondition2<int3, int3>
	{
		public bool Test(int3 h, int3 p, ref float t)
		{
			return false;
		}
	}

	private NativeArray<int2> m_Edges;

	private NativeArray<UStar> m_Stars;

	private NativeArray<int3> m_Cells;

	private int m_CellCount;

	private NativeArray<int> m_ILArray;

	private NativeArray<int> m_IUArray;

	private NativeArray<int> m_SPArray;

	private int m_NumEdges;

	private int m_NumHulls;

	private int m_NumPoints;

	private int m_StarCount;

	private NativeArray<int> m_Flags;

	private NativeArray<int> m_Neighbors;

	private NativeArray<int> m_Constraints;

	private Allocator m_Allocator;

	private static float FindSplit(UHull hull, UEvent edge)
	{
		return 0f;
	}

	private void SetAllocator(Allocator allocator)
	{
	}

	private bool AddPoint(NativeArray<UHull> hulls, int hullCount, NativeArray<float2> points, float2 p, int idx)
	{
		return false;
	}

	private static void InsertHull(NativeArray<UHull> Hulls, int Pos, ref int Count, UHull Value)
	{
	}

	private static void EraseHull(NativeArray<UHull> Hulls, int Pos, ref int Count)
	{
	}

	private bool SplitHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt)
	{
		return false;
	}

	private bool MergeHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt)
	{
		return false;
	}

	private static void InsertUniqueEdge(NativeArray<int2> edges, int2 e, ref int edgeCount)
	{
	}

	private void PrepareDelaunay(NativeArray<int2> edges, int edgeCount)
	{
	}

	private int OppositeOf(int a, int b)
	{
		return 0;
	}

	private int FindConstraint(int a, int b)
	{
		return 0;
	}

	private void AddTriangle(int i, int j, int k)
	{
	}

	private void RemovePair(int r, int j, int k)
	{
	}

	private void RemoveTriangle(int i, int j, int k)
	{
	}

	private void EdgeFlip(int i, int j)
	{
	}

	private bool Flip(NativeArray<float2> points, ref NativeArray<int> stack, ref int stackCount, int a, int b, int x)
	{
		return false;
	}

	private NativeArray<int3> GetCells(ref int count)
	{
		return default(NativeArray<int3>);
	}

	internal bool ApplyDelaunay(NativeArray<float2> points, NativeArray<int2> edges)
	{
		return false;
	}

	private int FindNeighbor(NativeArray<int3> cells, int count, int a, int b, int c)
	{
		return 0;
	}

	private NativeArray<int3> Constrain(ref int count)
	{
		return default(NativeArray<int3>);
	}

	internal NativeArray<int3> RemoveExterior(ref int cellCount)
	{
		return default(NativeArray<int3>);
	}

	internal NativeArray<int3> RemoveInterior(int cellCount)
	{
		return default(NativeArray<int3>);
	}

	internal bool Triangulate(NativeArray<float2> points, int pointCount, NativeArray<int2> edges, int edgeCount)
	{
		return false;
	}

	internal static bool Tessellate(Allocator allocator, NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2> outputVertices, ref int vertexCount, ref NativeArray<int> outputIndices, ref int indexCount)
	{
		return false;
	}

	internal void Cleanup()
	{
	}
}
