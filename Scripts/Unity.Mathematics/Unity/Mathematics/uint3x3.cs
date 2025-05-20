using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct uint3x3 : IEquatable<uint3x3>, IFormattable
{
	public uint3 c0;

	public uint3 c1;

	public uint3 c2;

	public static readonly uint3x3 identity;

	public static readonly uint3x3 zero;

	public ref uint3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(uint3 c0, uint3 c1, uint3 c2)
	{
		this.c0 = default(uint3);
		this.c1 = default(uint3);
		this.c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(uint v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(bool v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(bool3x3 v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(int v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(int3x3 v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(float v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(float3x3 v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(double v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint3x3(double3x3 v)
	{
		c0 = default(uint3);
		c1 = default(uint3);
		c2 = default(uint3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator uint3x3(uint v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(bool v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(bool3x3 v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(int v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(int3x3 v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(float v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(float3x3 v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(double v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator uint3x3(double3x3 v)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator *(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator *(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator *(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator +(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator +(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator +(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator -(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator -(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator -(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator /(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator /(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator /(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator %(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator %(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator %(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator ++(uint3x3 val)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator --(uint3x3 val)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <(uint3x3 lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <(uint3x3 lhs, uint rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <(uint lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <=(uint3x3 lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <=(uint3x3 lhs, uint rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator <=(uint lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >(uint3x3 lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >(uint3x3 lhs, uint rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >(uint lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >=(uint3x3 lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >=(uint3x3 lhs, uint rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator >=(uint lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator -(uint3x3 val)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator +(uint3x3 val)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator <<(uint3x3 x, int n)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator >>(uint3x3 x, int n)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(uint3x3 lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(uint3x3 lhs, uint rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(uint lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(uint3x3 lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(uint3x3 lhs, uint rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(uint lhs, uint3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator ~(uint3x3 val)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator &(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator &(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator &(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator |(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator |(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator |(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator ^(uint3x3 lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator ^(uint3x3 lhs, uint rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint3x3 operator ^(uint lhs, uint3x3 rhs)
	{
		return default(uint3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(uint3x3 rhs)
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
