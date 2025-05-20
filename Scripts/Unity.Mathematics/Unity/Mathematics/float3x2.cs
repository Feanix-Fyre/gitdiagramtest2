using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct float3x2 : IEquatable<float3x2>, IFormattable
{
	public float3 c0;

	public float3 c1;

	public static readonly float3x2 zero;

	public ref float3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(float3 c0, float3 c1)
	{
		this.c0 = default(float3);
		this.c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(float m00, float m01, float m10, float m11, float m20, float m21)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(float v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(bool v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(bool3x2 v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(int v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(int3x2 v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(uint v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(uint3x2 v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(double v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float3x2(double3x2 v)
	{
		c0 = default(float3);
		c1 = default(float3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x2(float v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x2(bool v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x2(bool3x2 v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x2(int v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x2(int3x2 v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x2(uint v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float3x2(uint3x2 v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x2(double v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float3x2(double3x2 v)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator *(float3x2 lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator *(float3x2 lhs, float rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator *(float lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator +(float3x2 lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator +(float3x2 lhs, float rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator +(float lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator -(float3x2 lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator -(float3x2 lhs, float rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator -(float lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator /(float3x2 lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator /(float3x2 lhs, float rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator /(float lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator %(float3x2 lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator %(float3x2 lhs, float rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator %(float lhs, float3x2 rhs)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator ++(float3x2 val)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator --(float3x2 val)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <(float3x2 lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <(float3x2 lhs, float rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <(float lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <=(float3x2 lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <=(float3x2 lhs, float rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <=(float lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >(float3x2 lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >(float3x2 lhs, float rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >(float lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >=(float3x2 lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >=(float3x2 lhs, float rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >=(float lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator -(float3x2 val)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float3x2 operator +(float3x2 val)
	{
		return default(float3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator ==(float3x2 lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator ==(float3x2 lhs, float rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator ==(float lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator !=(float3x2 lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator !=(float3x2 lhs, float rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator !=(float lhs, float3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(float3x2 rhs)
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
