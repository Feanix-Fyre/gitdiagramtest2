using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct int4x3 : IEquatable<int4x3>, IFormattable
{
	public int4 c0;

	public int4 c1;

	public int4 c2;

	public static readonly int4x3 zero;

	public ref int4 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(int4 c0, int4 c1, int4 c2)
	{
		this.c0 = default(int4);
		this.c1 = default(int4);
		this.c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(int v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(bool v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(bool4x3 v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(uint v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(uint4x3 v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(float v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(float4x3 v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(double v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int4x3(double4x3 v)
	{
		c0 = default(int4);
		c1 = default(int4);
		c2 = default(int4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator int4x3(int v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(bool v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(bool4x3 v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(uint v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(uint4x3 v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(float v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(float4x3 v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(double v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int4x3(double4x3 v)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator *(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator *(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator *(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator +(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator +(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator +(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator -(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator -(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator -(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator /(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator /(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator /(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator %(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator %(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator %(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator ++(int4x3 val)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator --(int4x3 val)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(int4x3 lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(int4x3 lhs, int rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <(int lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(int4x3 lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(int4x3 lhs, int rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator <=(int lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(int4x3 lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(int4x3 lhs, int rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >(int lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(int4x3 lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(int4x3 lhs, int rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator >=(int lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator -(int4x3 val)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator +(int4x3 val)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator <<(int4x3 x, int n)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator >>(int4x3 x, int n)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(int4x3 lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(int4x3 lhs, int rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator ==(int lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(int4x3 lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(int4x3 lhs, int rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x3 operator !=(int lhs, int4x3 rhs)
	{
		return default(bool4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator ~(int4x3 val)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator &(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator &(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator &(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator |(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator |(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator |(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator ^(int4x3 lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator ^(int4x3 lhs, int rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int4x3 operator ^(int lhs, int4x3 rhs)
	{
		return default(int4x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(int4x3 rhs)
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
