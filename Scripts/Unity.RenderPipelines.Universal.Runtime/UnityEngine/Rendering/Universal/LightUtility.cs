using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

internal static class LightUtility
{
	private enum PivotType
	{
		PivotBase = 0,
		PivotCurve = 1,
		PivotIntersect = 2,
		PivotSkip = 3,
		PivotClip = 4
	}

	[Serializable]
	internal struct LightMeshVertex
	{
		public Vector3 position;

		public Color color;

		public Vector2 uv;

		public static readonly VertexAttributeDescriptor[] VertexLayout;
	}

	public static bool CheckForChange(Light2D.LightType a, ref Light2D.LightType b)
	{
		return false;
	}

	public static bool CheckForChange(int a, ref int b)
	{
		return false;
	}

	public static bool CheckForChange(float a, ref float b)
	{
		return false;
	}

	public static bool CheckForChange(bool a, ref bool b)
	{
		return false;
	}

	private static bool TestPivot(List<IntPoint> path, int activePoint, long lastPoint)
	{
		return false;
	}

	private static List<IntPoint> DegeneratePivots(List<IntPoint> path, List<IntPoint> inPath, ref int interiorStart)
	{
		return null;
	}

	private static List<IntPoint> SortPivots(List<IntPoint> outPath, List<IntPoint> inPath)
	{
		return null;
	}

	private static List<IntPoint> FixPivots(List<IntPoint> outPath, List<IntPoint> inPath, ref int interiorStart)
	{
		return null;
	}

	internal static List<Vector2> GetOutlinePath(Vector3[] shapePath, float offsetDistance)
	{
		return null;
	}

	private static void TransferToMesh(NativeArray<LightMeshVertex> vertices, int vertexCount, NativeArray<ushort> indices, int indexCount, Light2D light)
	{
	}

	public static Bounds GenerateShapeMesh(Light2D light, Vector3[] shapePath, float falloffDistance)
	{
		return default(Bounds);
	}

	public static Bounds GenerateParametricMesh(Light2D light, float radius, float falloffDistance, float angle, int sides)
	{
		return default(Bounds);
	}

	public static Bounds GenerateSpriteMesh(Light2D light, Sprite sprite)
	{
		return default(Bounds);
	}

	public static int GetShapePathHash(Vector3[] path)
	{
		return 0;
	}
}
