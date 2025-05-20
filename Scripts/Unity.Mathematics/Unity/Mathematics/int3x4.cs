using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct int3x4 : IEquatable<int3x4>, IFormattable
{
	public int3 c0;

	public int3 c1;

	public int3 c2;

	public int3 c3;

	public static readonly int3x4 zero;

	public ref int3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(int3 c0, int3 c1, int3 c2, int3 c3)
	{
		this.c0 = default(int3);
		this.c1 = default(int3);
		this.c2 = default(int3);
		this.c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(int v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(bool v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(bool3x4 v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(uint v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(uint3x4 v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(float v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(float3x4 v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(double v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int3x4(double3x4 v)
	{
		c0 = default(int3);
		c1 = default(int3);
		c2 = default(int3);
		c3 = default(int3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator int3x4(int v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(bool v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(bool3x4 v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(uint v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(uint3x4 v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(float v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(float3x4 v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(double v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator int3x4(double3x4 v)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator *(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator *(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator *(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator +(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator +(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator +(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator -(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator -(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator -(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator /(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator /(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator /(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator %(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator %(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator %(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator ++(int3x4 val)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator --(int3x4 val)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(int3x4 lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(int3x4 lhs, int rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <(int lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(int3x4 lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(int3x4 lhs, int rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator <=(int lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(int3x4 lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(int3x4 lhs, int rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >(int lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(int3x4 lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(int3x4 lhs, int rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator >=(int lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator -(int3x4 val)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator +(int3x4 val)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator <<(int3x4 x, int n)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator >>(int3x4 x, int n)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(int3x4 lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(int3x4 lhs, int rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator ==(int lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(int3x4 lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(int3x4 lhs, int rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x4 operator !=(int lhs, int3x4 rhs)
	{
		return default(bool3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator ~(int3x4 val)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator &(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator &(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator &(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator |(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator |(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator |(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator ^(int3x4 lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator ^(int3x4 lhs, int rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int3x4 operator ^(int lhs, int3x4 rhs)
	{
		return default(int3x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(int3x4 rhs)
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
