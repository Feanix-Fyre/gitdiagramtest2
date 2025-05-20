using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct double3x4 : IEquatable<double3x4>, IFormattable
{
	public double3 c0;

	public double3 c1;

	public double3 c2;

	public double3 c3;

	public static readonly double3x4 zero;

	public ref double3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(double3 c0, double3 c1, double3 c2, double3 c3)
	{
		this.c0 = default(double3);
		this.c1 = default(double3);
		this.c2 = default(double3);
		this.c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(double v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(bool v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(bool3x4 v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(int v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(int3x4 v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(uint v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(uint3x4 v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(float v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double3x4(float3x4 v)
	{
		c0 = default(double3);
		c1 = default(double3);
		c2 = default(double3);
		c3 = default(double3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double3x4(double v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator double3x4(bool v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator double3x4(bool3x4 v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double3x4(int v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double3x4(int3x4 v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double3x4(uint v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double3x4(uint3x4 v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double3x4(float v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double3x4(float3x4 v)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator *(double3x4 lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator *(double3x4 lhs, double rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator *(double lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator +(double3x4 lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator +(double3x4 lhs, double rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator +(double lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator -(double3x4 lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator -(double3x4 lhs, double rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator -(double lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator /(double3x4 lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator /(double3x4 lhs, double rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator /(double lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator %(double3x4 lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator %(double3x4 lhs, double rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator %(double lhs, double3x4 rhs)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator ++(double3x4 val)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator --(double3x4 val)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(double3x4 lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(double3x4 lhs, double rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(double lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(double3x4 lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(double3x4 lhs, double rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(double lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(double3x4 lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(double3x4 lhs, double rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(double lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(double3x4 lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(double3x4 lhs, double rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(double lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator -(double3x4 val)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double3x4 operator +(double3x4 val)
	{
		return default(double3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(double3x4 lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(double3x4 lhs, double rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(double lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(double3x4 lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(double3x4 lhs, double rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(double lhs, double3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(double3x4 rhs)
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
