using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct int2x3 : IEquatable<int2x3>, IFormattable
{
	public int2 c0;

	public int2 c1;

	public int2 c2;

	public static readonly int2x3 zero;

	public ref int2 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(int2 c0, int2 c1, int2 c2)
	{
		this.c0 = default(int2);
		this.c1 = default(int2);
		this.c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(int m00, int m01, int m02, int m10, int m11, int m12)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(int v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(bool v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(bool2x3 v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(uint v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(uint2x3 v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(float v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(float2x3 v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(double v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x3(double2x3 v)
	{
		c0 = default(int2);
		c1 = default(int2);
		c2 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator int2x3(int v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(bool v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(bool2x3 v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(uint v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(uint2x3 v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(float v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(float2x3 v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(double v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x3(double2x3 v)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator *(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator *(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator *(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator +(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator +(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator +(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator -(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator -(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator -(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator /(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator /(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator /(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator %(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator %(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator %(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator ++(int2x3 val)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator --(int2x3 val)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(int2x3 lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(int2x3 lhs, int rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <(int lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(int2x3 lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(int2x3 lhs, int rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator <=(int lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(int2x3 lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(int2x3 lhs, int rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >(int lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(int2x3 lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(int2x3 lhs, int rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator >=(int lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator -(int2x3 val)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator +(int2x3 val)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator <<(int2x3 x, int n)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator >>(int2x3 x, int n)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(int2x3 lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(int2x3 lhs, int rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator ==(int lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(int2x3 lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(int2x3 lhs, int rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x3 operator !=(int lhs, int2x3 rhs)
	{
		return default(bool2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator ~(int2x3 val)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator &(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator &(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator &(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator |(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator |(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator |(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator ^(int2x3 lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator ^(int2x3 lhs, int rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x3 operator ^(int lhs, int2x3 rhs)
	{
		return default(int2x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(int2x3 rhs)
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
