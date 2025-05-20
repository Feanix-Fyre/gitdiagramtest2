using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct quaternion : IEquatable<quaternion>, IFormattable
{
	public float4 value;

	public static readonly quaternion identity;

	public static implicit operator Quaternion(quaternion q)
	{
		return default(Quaternion);
	}

	public static implicit operator quaternion(Quaternion q)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public quaternion(float x, float y, float z, float w)
	{
		value = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public quaternion(float4 value)
	{
		this.value = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator quaternion(float4 v)
	{
		return default(quaternion);
	}

	public quaternion(float3x3 m)
	{
		value = default(float4);
	}

	public quaternion(float4x4 m)
	{
		value = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion AxisAngle(float3 axis, float angle)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerXYZ(float3 xyz)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerXZY(float3 xyz)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerYXZ(float3 xyz)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerYZX(float3 xyz)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerZXY(float3 xyz)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerZYX(float3 xyz)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerXYZ(float x, float y, float z)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerXZY(float x, float y, float z)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerYXZ(float x, float y, float z)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerYZX(float x, float y, float z)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerZXY(float x, float y, float z)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion EulerZYX(float x, float y, float z)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion RotateX(float angle)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion RotateY(float angle)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion RotateZ(float angle)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static quaternion LookRotation(float3 forward, float3 up)
	{
		return default(quaternion);
	}

	public static quaternion LookRotationSafe(float3 forward, float3 up)
	{
		return default(quaternion);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(quaternion x)
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
