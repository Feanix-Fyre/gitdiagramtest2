using System.Runtime.CompilerServices;

namespace Unity.Mathematics.Geometry;

internal static class Math
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static MinMaxAABB Transform(RigidTransform transform, MinMaxAABB aabb)
	{
		return default(MinMaxAABB);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static MinMaxAABB Transform(float4x4 transform, MinMaxAABB aabb)
	{
		return default(MinMaxAABB);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static MinMaxAABB Transform(float3x3 transform, MinMaxAABB aabb)
	{
		return default(MinMaxAABB);
	}
}
