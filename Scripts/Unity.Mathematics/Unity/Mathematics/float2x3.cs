using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct float2x3 : IEquatable<float2x3>, IFormattable
{
	public float2 c0;

	public float2 c1;

	public float2 c2;

	public static readonly float2x3 zero;

	public ref float2 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(float2 c0, float2 c1, float2 c2)
	{
		this.c0 = default(float2);
		this.c1 = default(float2);
		this.c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(float m00, float m01, float m02, float m10, float m11, float m12)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(float v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(bool v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(bool2x3 v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(int v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(int2x3 v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(uint v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(uint2x3 v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(double v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float2x3(double2x3 v)
	{
		c0 = default(float2);
		c1 = default(float2);
		c2 = default(float2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float2x3(float v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float2x3(bool v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float2x3(bool2x3 v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float2x3(int v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float2x3(int2x3 v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float2x3(uint v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float2x3(uint2x3 v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float2x3(double v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float2x3(double2x3 v)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator *(float2x3 lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator *(float2x3 lhs, float rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator *(float lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator +(float2x3 lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator +(float2x3 lhs, float rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator +(float lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator -(float2x3 lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator -(float2x3 lhs, float rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator -(float lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator /(float2x3 lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator /(float2x3 lhs, float rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator /(float lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator %(float2x3 lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator %(float2x3 lhs, float rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator %(float lhs, float2x3 rhs)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator ++(float2x3 val)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator --(float2x3 val)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(float2x3 lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(float2x3 lhs, float rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(float lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(float2x3 lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(float2x3 lhs, float rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(float lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(float2x3 lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(float2x3 lhs, float rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(float lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(float2x3 lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(float2x3 lhs, float rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(float lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator -(float2x3 val)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float2x3 operator +(float2x3 val)
	{
		return default(float2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(float2x3 lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(float2x3 lhs, float rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(float lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(float2x3 lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(float2x3 lhs, float rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(float lhs, float2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(float2x3 rhs)
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
