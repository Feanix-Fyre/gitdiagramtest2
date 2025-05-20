using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct double4x3 : IEquatable<double4x3>, IFormattable
{
	public double4 c0;

	public double4 c1;

	public double4 c2;

	public static readonly double4x3 zero;

	public ref double4 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(double4 c0, double4 c1, double4 c2)
	{
		this.c0 = default(double4);
		this.c1 = default(double4);
		this.c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(double v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(bool v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(bool4x3 v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(int v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(int4x3 v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(uint v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(uint4x3 v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(float v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double4x3(float4x3 v)
	{
		c0 = default(double4);
		c1 = default(double4);
		c2 = default(double4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double4x3(double v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator double4x3(bool v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator double4x3(bool4x3 v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double4x3(int v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double4x3(int4x3 v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double4x3(uint v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double4x3(uint4x3 v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double4x3(float v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double4x3(float4x3 v)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator *(double4x3 lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator *(double4x3 lhs, double rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator *(double lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator +(double4x3 lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator +(double4x3 lhs, double rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator +(double lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator -(double4x3 lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator -(double4x3 lhs, double rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator -(double lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator /(double4x3 lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator /(double4x3 lhs, double rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator /(double lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator %(double4x3 lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator %(double4x3 lhs, double rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator %(double lhs, double4x3 rhs)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator ++(double4x3 val)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator --(double4x3 val)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(double4x3 lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(double4x3 lhs, double rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(double lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(double4x3 lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(double4x3 lhs, double rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(double lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(double4x3 lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(double4x3 lhs, double rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(double lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(double4x3 lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(double4x3 lhs, double rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(double lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator -(double4x3 val)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double4x3 operator +(double4x3 val)
	{
		return default(double4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(double4x3 lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(double4x3 lhs, double rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(double lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(double4x3 lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(double4x3 lhs, double rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(double lhs, double4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(double4x3 rhs)
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
