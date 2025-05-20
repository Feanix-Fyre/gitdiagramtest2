using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct int3x2 : IEquatable<int3x2>, IFormattable
{
	public int3 c0;

	public int3 c1;

	public static readonly int3x2 zero;

	public ref int3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(int3 c0, int3 c1)
	{
		this.c0 = default(int3);
		this.c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(int m00, int m01, int m10, int m11, int m20, int m21)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(int v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(bool v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(bool3x2 v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(uint v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(uint3x2 v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(float v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(float3x2 v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(double v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x2(double3x2 v)
	{
		c0 = default(int3);
		c1 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator int3x2(int v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(bool v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(bool3x2 v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(uint v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(uint3x2 v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(float v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(float3x2 v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(double v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x2(double3x2 v)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator *(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator *(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator *(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator +(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator +(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator +(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator -(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator -(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator -(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator /(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator /(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator /(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator %(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator %(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator %(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator ++(int3x2 val)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator --(int3x2 val)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <(int3x2 lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <(int3x2 lhs, int rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <(int lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <=(int3x2 lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <=(int3x2 lhs, int rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator <=(int lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >(int3x2 lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >(int3x2 lhs, int rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >(int lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >=(int3x2 lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >=(int3x2 lhs, int rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator >=(int lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator -(int3x2 val)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator +(int3x2 val)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator <<(int3x2 x, int n)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator >>(int3x2 x, int n)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator ==(int3x2 lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator ==(int3x2 lhs, int rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator ==(int lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator !=(int3x2 lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator !=(int3x2 lhs, int rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x2 operator !=(int lhs, int3x2 rhs)
	{
		return default(bool3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator ~(int3x2 val)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator &(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator &(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator &(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator |(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator |(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator |(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator ^(int3x2 lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator ^(int3x2 lhs, int rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x2 operator ^(int lhs, int3x2 rhs)
	{
		return default(int3x2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(int3x2 rhs)
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
