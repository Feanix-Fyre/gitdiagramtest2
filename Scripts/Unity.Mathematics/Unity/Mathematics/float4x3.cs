using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct float4x3 : IEquatable<float4x3>, IFormattable
{
	public float4 c0;

	public float4 c1;

	public float4 c2;

	public static readonly float4x3 zero;

	public ref float4 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(float4 c0, float4 c1, float4 c2)
	{
		this.c0 = default(float4);
		this.c1 = default(float4);
		this.c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(float v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(bool v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(bool4x3 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(int v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(int4x3 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(uint v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(uint4x3 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(double v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float4x3(double4x3 v)
	{
		c0 = default(float4);
		c1 = default(float4);
		c2 = default(float4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x3(float v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x3(bool v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x3(bool4x3 v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x3(int v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x3(int4x3 v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x3(uint v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float4x3(uint4x3 v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x3(double v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator float4x3(double4x3 v)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator *(float4x3 lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator *(float4x3 lhs, float rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator *(float lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator +(float4x3 lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator +(float4x3 lhs, float rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator +(float lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator -(float4x3 lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator -(float4x3 lhs, float rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator -(float lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator /(float4x3 lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator /(float4x3 lhs, float rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator /(float lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator %(float4x3 lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator %(float4x3 lhs, float rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator %(float lhs, float4x3 rhs)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator ++(float4x3 val)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator --(float4x3 val)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(float4x3 lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(float4x3 lhs, float rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(float lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(float4x3 lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(float4x3 lhs, float rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(float lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(float4x3 lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(float4x3 lhs, float rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(float lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(float4x3 lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(float4x3 lhs, float rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(float lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator -(float4x3 val)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float4x3 operator +(float4x3 val)
	{
		return default(float4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(float4x3 lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(float4x3 lhs, float rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(float lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(float4x3 lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(float4x3 lhs, float rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(float lhs, float4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(float4x3 rhs)
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
