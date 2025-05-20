using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct float4x4 : IEquatable<float4x4>, IFormattable
{
	public float4 c0;

	public float4 c1;

	public float4 c2;

	public float4 c3;

	public static readonly float4x4 identity;

	public static readonly float4x4 zero;

	public ref float4 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
	{
		this.c0 = default(float4);
		this.c1 = default(float4);
		this.c2 = default(float4);
		this.c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(float v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(bool v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(bool4x4 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(int v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(int4x4 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(uint v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(uint4x4 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(double v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x4(double4x4 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x4(float v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x4(bool v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x4(bool4x4 v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x4(int v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x4(int4x4 v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x4(uint v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x4(uint4x4 v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x4(double v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x4(double4x4 v)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator *(float4x4 lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator *(float4x4 lhs, float rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator *(float lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator +(float4x4 lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator +(float4x4 lhs, float rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator +(float lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator -(float4x4 lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator -(float4x4 lhs, float rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator -(float lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator /(float4x4 lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator /(float4x4 lhs, float rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator /(float lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator %(float4x4 lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator %(float4x4 lhs, float rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator %(float lhs, float4x4 rhs)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator ++(float4x4 val)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator --(float4x4 val)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <(float4x4 lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <(float4x4 lhs, float rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <(float lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <=(float4x4 lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <=(float4x4 lhs, float rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <=(float lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >(float4x4 lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >(float4x4 lhs, float rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >(float lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >=(float4x4 lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >=(float4x4 lhs, float rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >=(float lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator -(float4x4 val)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 operator +(float4x4 val)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(float4x4 lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(float4x4 lhs, float rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(float lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(float4x4 lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(float4x4 lhs, float rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(float lhs, float4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(float4x4 rhs)
	{
		return false;
	}

	public override bool Equals(object o)
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

	public static implicit operator float4x4(Matrix4x4 m)
	{
		return default(float4x4);
	}

	public static implicit operator Matrix4x4(float4x4 m)
	{
		return default(Matrix4x4);
	}

	public float4x4(float3x3 rotation, float3 translation)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	public float4x4(quaternion rotation, float3 translation)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	public float4x4(RigidTransform transform)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
		c3 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 AxisAngle(float3 axis, float angle)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerXYZ(float3 xyz)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerXZY(float3 xyz)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerYXZ(float3 xyz)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerYZX(float3 xyz)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerZXY(float3 xyz)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerZYX(float3 xyz)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerXYZ(float x, float y, float z)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerXZY(float x, float y, float z)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerYXZ(float x, float y, float z)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerYZX(float x, float y, float z)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerZXY(float x, float y, float z)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 EulerZYX(float x, float y, float z)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 RotateX(float angle)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 RotateY(float angle)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 RotateZ(float angle)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 Scale(float s)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 Scale(float x, float y, float z)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 Scale(float3 scales)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 Translate(float3 vector)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 LookAt(float3 eye, float3 target, float3 up)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 Ortho(float width, float height, float near, float far)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 OrthoOffCenter(float left, float right, float bottom, float top, float near, float far)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 PerspectiveFov(float verticalFov, float aspect, float near, float far)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
	{
		return default(float4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale)
	{
		return default(float4x4);
	}
}
