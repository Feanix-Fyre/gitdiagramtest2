using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode.Default, DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
internal struct TilingJob : IJobFor
{
	[ReadOnly]
	public NativeArray<VisibleLight> lights;

	[ReadOnly]
	public NativeArray<VisibleReflectionProbe> reflectionProbes;

	[NativeDisableParallelForRestriction]
	public NativeArray<InclusiveRange> tileRanges;

	public int itemsPerTile;

	public int rangesPerItem;

	public Fixed2<float4x4> worldToViews;

	public float2 tileScale;

	public float2 tileScaleInv;

	public Fixed2<float> viewPlaneBottoms;

	public Fixed2<float> viewPlaneTops;

	public Fixed2<float4> viewToViewportScaleBiases;

	public int2 tileCount;

	public float near;

	public bool isOrthographic;

	private InclusiveRange m_TileYRange;

	private int m_Offset;

	private int m_ViewIndex;

	private float2 m_CenterOffset;

	private static readonly float3[] k_CubePoints;

	private static readonly int4[] k_CubeLineIndices;

	public void Execute(int jobIndex)
	{
	}

	private void TileLight(int lightIndex)
	{
	}

	private void TileLightOrthographic(int lightIndex)
	{
	}

	private void TileReflectionProbe(int index)
	{
	}

	private float2 ViewToTileSpace(float3 positionVS)
	{
		return default(float2);
	}

	private float2 ViewToTileSpaceOrthographic(float3 positionVS)
	{
		return default(float2);
	}

	private void ExpandY(float3 positionVS)
	{
	}

	private void ExpandOrthographic(float3 positionVS)
	{
	}

	private void ExpandRangeOrthographic(ref InclusiveRange range, float xVS)
	{
	}

	private static float square(float x)
	{
		return 0f;
	}

	private static void GetSphereHorizon(float2 center, float radius, float near, float clipRadius, out float2 p0, out float2 p1)
	{
		p0 = default(float2);
		p1 = default(float2);
	}

	private static void GetSphereYPlaneHorizon(float3 center, float sphereRadius, float near, float clipRadius, float y, out float3 left, out float3 right)
	{
		left = default(float3);
		right = default(float3);
	}

	private static bool GetCircleClipPoints(float3 circleCenter, float3 circleNormal, float circleRadius, float near, out float3 p0, out float3 p1)
	{
		p0 = default(float3);
		p1 = default(float3);
		return false;
	}

	private static (float, float) IntersectEllipseLine(float a, float b, float3 line)
	{
		return default((float, float));
	}

	private static void GetProjectedCircleHorizon(float2 center, float radius, float2 U, float2 V, out float2 uv1, out float2 uv2)
	{
		uv1 = default(float2);
		uv2 = default(float2);
	}

	private static bool IntersectCircleYPlane(float y, float3 circleCenter, float3 circleNormal, float3 circleU, float3 circleV, float circleRadius, out float3 p1, out float3 p2)
	{
		p1 = default(float3);
		p2 = default(float3);
		return false;
	}

	private static void GetConeSideTangentPoints(float3 vertex, float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, float3 circleU, float3 circleV, out float3 l1, out float3 l2)
	{
		l1 = default(float3);
		l2 = default(float3);
	}

	private static float3 EvaluateNearConic(float near, float3 o, float3 d, float r, float3 u, float3 v, float theta)
	{
		return default(float3);
	}

	private static float2 FindNearConicTangentTheta(float2 o, float2 d, float r, float2 u, float2 v)
	{
		return default(float2);
	}

	private static float2 FindNearConicYTheta(float near, float3 o, float3 d, float r, float3 u, float3 v, float y)
	{
		return default(float2);
	}
}
