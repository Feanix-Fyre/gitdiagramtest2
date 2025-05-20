using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct double2x3 : IEquatable<double2x3>, IFormattable
{
	public double2 c0;

	public double2 c1;

	public double2 c2;

	public static readonly double2x3 zero;

	public ref double2 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(double2 c0, double2 c1, double2 c2)
	{
		this.c0 = default(double2);
		this.c1 = default(double2);
		this.c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(double m00, double m01, double m02, double m10, double m11, double m12)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(double v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(bool v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(bool2x3 v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(int v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(int2x3 v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(uint v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(uint2x3 v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(float v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double2x3(float2x3 v)
	{
		c0 = default(double2);
		c1 = default(double2);
		c2 = default(double2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double2x3(double v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator double2x3(bool v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator double2x3(bool2x3 v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double2x3(int v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double2x3(int2x3 v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double2x3(uint v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double2x3(uint2x3 v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double2x3(float v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double2x3(float2x3 v)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator *(double2x3 lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator *(double2x3 lhs, double rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator *(double lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator +(double2x3 lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator +(double2x3 lhs, double rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator +(double lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator -(double2x3 lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator -(double2x3 lhs, double rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator -(double lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator /(double2x3 lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator /(double2x3 lhs, double rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator /(double lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator %(double2x3 lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator %(double2x3 lhs, double rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator %(double lhs, double2x3 rhs)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator ++(double2x3 val)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator --(double2x3 val)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(double2x3 lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(double2x3 lhs, double rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(double lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(double2x3 lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(double2x3 lhs, double rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(double lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(double2x3 lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(double2x3 lhs, double rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(double lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(double2x3 lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(double2x3 lhs, double rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(double lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator -(double2x3 val)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double2x3 operator +(double2x3 val)
	{
		return default(double2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(double2x3 lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(double2x3 lhs, double rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(double lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(double2x3 lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(double2x3 lhs, double rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(double lhs, double2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(double2x3 rhs)
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
