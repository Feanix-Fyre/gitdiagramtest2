using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct RigidTransform
{
	public quaternion rot;

	public float3 pos;

	public static readonly RigidTransform identity;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public RigidTransform(quaternion rotation, float3 translation)
	{
		rot = default(quaternion);
		pos = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public RigidTransform(float3x3 rotation, float3 translation)
	{
		rot = default(quaternion);
		pos = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public RigidTransform(float4x4 transform)
	{
		rot = default(quaternion);
		pos = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform AxisAngle(float3 axis, float angle)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerXYZ(float3 xyz)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerXZY(float3 xyz)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerYXZ(float3 xyz)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerYZX(float3 xyz)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerZXY(float3 xyz)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerZYX(float3 xyz)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerXYZ(float x, float y, float z)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerXZY(float x, float y, float z)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerYXZ(float x, float y, float z)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerYZX(float x, float y, float z)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerZXY(float x, float y, float z)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform EulerZYX(float x, float y, float z)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform RotateX(float angle)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform RotateY(float angle)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform RotateZ(float angle)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RigidTransform Translate(float3 vector)
	{
		return default(RigidTransform);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(RigidTransform x)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object x)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}
}
