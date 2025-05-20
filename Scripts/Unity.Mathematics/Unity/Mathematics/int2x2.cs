using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct int2x2 : IEquatable<int2x2>, IFormattable
{
	public int2 c0;

	public int2 c1;

	public static readonly int2x2 identity;

	public static readonly int2x2 zero;

	public ref int2 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(int2 c0, int2 c1)
	{
		this.c0 = default(int2);
		this.c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(int m00, int m01, int m10, int m11)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(int v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(bool v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(bool2x2 v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(uint v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(uint2x2 v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(float v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(float2x2 v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(double v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int2x2(double2x2 v)
	{
		c0 = default(int2);
		c1 = default(int2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator int2x2(int v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(bool v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(bool2x2 v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(uint v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(uint2x2 v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(float v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(float2x2 v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(double v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int2x2(double2x2 v)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator *(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator *(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator *(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator +(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator +(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator +(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator -(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator -(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator -(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator /(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator /(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator /(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator %(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator %(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator %(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator ++(int2x2 val)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator --(int2x2 val)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator <(int2x2 lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator <(int2x2 lhs, int rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator <(int lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator <=(int2x2 lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator <=(int2x2 lhs, int rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator <=(int lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator >(int2x2 lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator >(int2x2 lhs, int rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator >(int lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator >=(int2x2 lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator >=(int2x2 lhs, int rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator >=(int lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator -(int2x2 val)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator +(int2x2 val)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator <<(int2x2 x, int n)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator >>(int2x2 x, int n)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator ==(int2x2 lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator ==(int2x2 lhs, int rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator ==(int lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator !=(int2x2 lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator !=(int2x2 lhs, int rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool2x2 operator !=(int lhs, int2x2 rhs)
	{
		return default(bool2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator ~(int2x2 val)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator &(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator &(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator &(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator |(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator |(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator |(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator ^(int2x2 lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator ^(int2x2 lhs, int rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int2x2 operator ^(int lhs, int2x2 rhs)
	{
		return default(int2x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(int2x2 rhs)
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
