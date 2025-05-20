using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess;

[StructLayout((LayoutKind)0, Size = 1)]
internal struct PlanarGraph
{
	private static readonly double kEpsilon;

	private static readonly int kMaxIntersectionTolerance;

	internal static void RemoveDuplicateEdges(ref NativeArray<int2> edges, ref int edgeCount, NativeArray<int> duplicates, int duplicateCount)
	{
	}

	internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1)
	{
		return false;
	}

	internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1)
	{
		return false;
	}

	internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result)
	{
		return false;
	}

	internal static bool CalculateEdgeIntersections(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, ref NativeArray<int2> results, ref NativeArray<double2> intersects, ref int resultCount)
	{
		return false;
	}

	internal static bool CalculateTJunctions(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, NativeArray<int2> results, ref int resultCount)
	{
		return false;
	}

	internal static bool CutEdges(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int2> edges, ref int edgeCount, ref NativeArray<int2> tJunctions, ref int tJunctionCount, NativeArray<int2> intersections, NativeArray<double2> intersects, int intersectionCount)
	{
		return false;
	}

	internal static void RemoveDuplicatePoints(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int> duplicates, ref int duplicateCount, Allocator allocator)
	{
	}

	internal static bool Validate(Allocator allocator, NativeArray<float2> inputPoints, int pointCount, NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2> outputPoints, ref int outputPointCount, ref NativeArray<int2> outputEdges, ref int outputEdgeCount)
	{
		return false;
	}
}
