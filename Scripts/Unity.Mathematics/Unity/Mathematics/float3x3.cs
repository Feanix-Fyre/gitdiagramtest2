using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct float3x3 : IEquatable<float3x3>, IFormattable
{
	public float3 c0;

	public float3 c1;

	public float3 c2;

	public static readonly float3x3 identity;

	public static readonly float3x3 zero;

	public ref float3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(float3 c0, float3 c1, float3 c2)
	{
		this.c0 = default(float3);
		this.c1 = default(float3);
		this.c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(float v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(bool v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(bool3x3 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(int v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(int3x3 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(uint v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(uint3x3 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(double v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x3(double3x3 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x3(float v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x3(bool v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x3(bool3x3 v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x3(int v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x3(int3x3 v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x3(uint v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x3(uint3x3 v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x3(double v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x3(double3x3 v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator *(float3x3 lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator *(float3x3 lhs, float rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator *(float lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator +(float3x3 lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator +(float3x3 lhs, float rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator +(float lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator -(float3x3 lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator -(float3x3 lhs, float rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator -(float lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator /(float3x3 lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator /(float3x3 lhs, float rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator /(float lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator %(float3x3 lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator %(float3x3 lhs, float rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator %(float lhs, float3x3 rhs)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator ++(float3x3 val)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator --(float3x3 val)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <(float3x3 lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <(float3x3 lhs, float rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <(float lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <=(float3x3 lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <=(float3x3 lhs, float rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <=(float lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >(float3x3 lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >(float3x3 lhs, float rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >(float lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >=(float3x3 lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >=(float3x3 lhs, float rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >=(float lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator -(float3x3 val)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 operator +(float3x3 val)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(float3x3 lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(float3x3 lhs, float rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(float lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(float3x3 lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(float3x3 lhs, float rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(float lhs, float3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(float3x3 rhs)
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

	public float3x3(float4x4 f4x4)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	public float3x3(quaternion q)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 AxisAngle(float3 axis, float angle)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerXYZ(float3 xyz)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerXZY(float3 xyz)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerYXZ(float3 xyz)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerYZX(float3 xyz)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerZXY(float3 xyz)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerZYX(float3 xyz)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerXYZ(float x, float y, float z)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerXZY(float x, float y, float z)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerYXZ(float x, float y, float z)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerYZX(float x, float y, float z)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerZXY(float x, float y, float z)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 EulerZYX(float x, float y, float z)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 RotateX(float angle)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 RotateY(float angle)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 RotateZ(float angle)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 Scale(float s)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 Scale(float x, float y, float z)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 Scale(float3 v)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 LookRotation(float3 forward, float3 up)
	{
		return default(float3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x3 LookRotationSafe(float3 forward, float3 up)
	{
		return default(float3x3);
	}

	public static explicit operator float3x3(float4x4 f4x4)
	{
		return default(float3x3);
	}
}
