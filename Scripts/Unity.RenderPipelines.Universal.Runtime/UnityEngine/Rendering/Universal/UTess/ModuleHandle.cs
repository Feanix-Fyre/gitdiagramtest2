using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess;

[StructLayout((LayoutKind)0, Size = 1)]
internal struct ModuleHandle
{
	internal static readonly int kMaxArea;

	internal static readonly int kMaxEdgeCount;

	internal static readonly int kMaxIndexCount;

	internal static readonly int kMaxVertexCount;

	internal static readonly int kMaxTriangleCount;

	internal static readonly int kMaxRefineIterations;

	internal static readonly int kMaxSmoothenIterations;

	internal static readonly float kIncrementAreaFactor;

	internal static void Copy<T>(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) where T : struct
	{
	}

	internal static void Copy<T>(NativeArray<T> src, NativeArray<T> dst, int length) where T : struct
	{
	}

	internal unsafe static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) where T : struct where U : IComparer<T>
	{
	}

	internal static int GetLower<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : struct where U : struct where X : ICondition2<T, U>
	{
		return 0;
	}

	internal static int GetUpper<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : struct where U : struct where X : ICondition2<T, U>
	{
		return 0;
	}

	internal static int GetEqual<T, U, X>(NativeArray<T> values, int count, U check, X condition) where T : struct where U : struct where X : ICondition2<T, U>
	{
		return 0;
	}

	internal static float OrientFast(float2 a, float2 b, float2 c)
	{
		return 0f;
	}

	internal static double OrientFastDouble(double2 a, double2 b, double2 c)
	{
		return 0.0;
	}

	internal static UCircle CircumCircle(UTriangle tri)
	{
		return default(UCircle);
	}

	internal static bool IsInsideCircle(UCircle c, float2 v)
	{
		return false;
	}

	internal static float TriangleArea(float2 va, float2 vb, float2 vc)
	{
		return 0f;
	}

	internal static float Sign(float2 p1, float2 p2, float2 p3)
	{
		return 0f;
	}

	internal static bool IsInsideTriangle(float2 pt, float2 v1, float2 v2, float2 v3)
	{
		return false;
	}

	internal static bool IsInsideTriangleApproximate(float2 pt, float2 v1, float2 v2, float2 v3)
	{
		return false;
	}

	internal static bool IsInsideCircle(float2 a, float2 b, float2 c, float2 p)
	{
		return false;
	}

	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea)
	{
	}

	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge)
	{
	}

	internal static void BuildTrianglesAndEdges(NativeArray<float2> vertices, int vertexCount, NativeArray<int> indices, int indexCount, ref NativeArray<UTriangle> triangles, ref int triangleCount, ref NativeArray<int4> delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea)
	{
	}

	private static void CopyGraph(NativeArray<float2> srcPoints, int srcPointCount, ref NativeArray<float2> dstPoints, ref int dstPointCount, NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount)
	{
	}

	private static void CopyGeometry(NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount)
	{
	}

	private static void TransferOutput(NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2> dstEdges, ref int dstEdgeCount, NativeArray<int> srcIndices, int srcIndexCount, ref NativeArray<int> dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2> dstVertices, ref int dstVertexCount)
	{
	}

	private static void GraphConditioner(NativeArray<float2> points, ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, bool resetTopology)
	{
	}

	private static void Reorder(int startVertexCount, int index, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount)
	{
	}

	internal static void VertexCleanupConditioner(int startVertexCount, ref NativeArray<int> indices, ref int indexCount, ref NativeArray<float2> vertices, ref int vertexCount)
	{
	}

	public static float4 ConvexQuad(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount)
	{
		return default(float4);
	}

	public static float4 Tessellate(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount)
	{
		return default(float4);
	}

	public static float4 Subdivide(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2> outVertices, ref int outVertexCount, ref NativeArray<int> outIndices, ref int outIndexCount, ref NativeArray<int2> outEdges, ref int outEdgeCount, float areaFactor, float targetArea, int refineIterations, int smoothenIterations)
	{
		return default(float4);
	}
}
