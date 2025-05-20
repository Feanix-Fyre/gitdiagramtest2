using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct uint4x4 : IEquatable<uint4x4>, IFormattable
{
	public uint4 c0;

	public uint4 c1;

	public uint4 c2;

	public uint4 c3;

	public static readonly uint4x4 identity;

	public static readonly uint4x4 zero;

	public ref uint4 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3)
	{
		this.c0 = default(uint4);
		this.c1 = default(uint4);
		this.c2 = default(uint4);
		this.c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(uint v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(bool v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(bool4x4 v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(int v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(int4x4 v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(float v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(float4x4 v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(double v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint4x4(double4x4 v)
	{
		c0 = default(uint4);
		c1 = default(uint4);
		c2 = default(uint4);
		c3 = default(uint4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator uint4x4(uint v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(bool v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(bool4x4 v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(int v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(int4x4 v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(float v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(float4x4 v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(double v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint4x4(double4x4 v)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator *(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator *(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator *(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator +(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator +(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator +(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator -(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator -(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator -(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator /(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator /(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator /(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator %(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator %(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator %(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator ++(uint4x4 val)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator --(uint4x4 val)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <(uint4x4 lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <(uint4x4 lhs, uint rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <(uint lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <=(uint4x4 lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <=(uint4x4 lhs, uint rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator <=(uint lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >(uint4x4 lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >(uint4x4 lhs, uint rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >(uint lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >=(uint4x4 lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >=(uint4x4 lhs, uint rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator >=(uint lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator -(uint4x4 val)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator +(uint4x4 val)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator <<(uint4x4 x, int n)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator >>(uint4x4 x, int n)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(uint4x4 lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(uint4x4 lhs, uint rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(uint lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(uint4x4 lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(uint4x4 lhs, uint rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(uint lhs, uint4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator ~(uint4x4 val)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator &(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator &(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator &(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator |(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator |(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator |(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator ^(uint4x4 lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator ^(uint4x4 lhs, uint rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint4x4 operator ^(uint lhs, uint4x4 rhs)
	{
		return default(uint4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(uint4x4 rhs)
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
