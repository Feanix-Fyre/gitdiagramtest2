using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics.Geometry;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
internal struct MinMaxAABB : IEquatable<MinMaxAABB>
{
	public float3 Min;

	public float3 Max;

	public float3 Extents => default(float3);

	public float3 HalfExtents => default(float3);

	public float3 Center => default(float3);

	public bool IsValid => false;

	public float SurfaceArea => 0f;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public MinMaxAABB(float3 min, float3 max)
	{
		Min = default(float3);
		Max = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents)
	{
		return default(MinMaxAABB);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents)
	{
		return default(MinMaxAABB);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Contains(float3 point)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Contains(MinMaxAABB aabb)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Overlaps(MinMaxAABB aabb)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Expand(float signedDistance)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Encapsulate(MinMaxAABB aabb)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Encapsulate(float3 point)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(MinMaxAABB other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}
}
