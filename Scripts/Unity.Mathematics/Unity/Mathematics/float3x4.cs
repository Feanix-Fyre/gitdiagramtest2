using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct float3x4 : IEquatable<float3x4>, IFormattable
{
	public float3 c0;

	public float3 c1;

	public float3 c2;

	public float3 c3;

	public static readonly float3x4 zero;

	public ref float3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(float3 c0, float3 c1, float3 c2, float3 c3)
	{
		this.c0 = default(float3);
		this.c1 = default(float3);
		this.c2 = default(float3);
		this.c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(float v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(bool v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(bool3x4 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(int v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(int3x4 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(uint v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(uint3x4 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(double v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x4(double3x4 v)
	{
		c0 = default(float3);
		c1 = default(float3);
		c2 = default(float3);
		c3 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x4(float v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x4(bool v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x4(bool3x4 v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x4(int v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x4(int3x4 v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x4(uint v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x4(uint3x4 v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x4(double v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x4(double3x4 v)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator *(float3x4 lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator *(float3x4 lhs, float rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator *(float lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator +(float3x4 lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator +(float3x4 lhs, float rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator +(float lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator -(float3x4 lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator -(float3x4 lhs, float rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator -(float lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator /(float3x4 lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator /(float3x4 lhs, float rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator /(float lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator %(float3x4 lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator %(float3x4 lhs, float rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator %(float lhs, float3x4 rhs)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator ++(float3x4 val)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator --(float3x4 val)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(float3x4 lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(float3x4 lhs, float rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(float lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(float3x4 lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(float3x4 lhs, float rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(float lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(float3x4 lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(float3x4 lhs, float rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(float lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(float3x4 lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(float3x4 lhs, float rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(float lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator -(float3x4 val)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x4 operator +(float3x4 val)
	{
		return default(float3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(float3x4 lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(float3x4 lhs, float rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(float lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(float3x4 lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(float3x4 lhs, float rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(float lhs, float3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(float3x4 rhs)
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
}
