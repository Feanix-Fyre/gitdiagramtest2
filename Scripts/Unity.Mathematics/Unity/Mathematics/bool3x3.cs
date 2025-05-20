using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct bool3x3 : IEquatable<bool3x3>
{
	public bool3 c0;

	public bool3 c1;

	public bool3 c2;

	public ref bool3 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool3x3(bool3 c0, bool3 c1, bool3 c2)
	{
		this.c0 = default(bool3);
		this.c1 = default(bool3);
		this.c2 = default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22)
	{
		c0 = default(bool3);
		c1 = default(bool3);
		c2 = default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool3x3(bool v)
	{
		c0 = default(bool3);
		c1 = default(bool3);
		c2 = default(bool3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator bool3x3(bool v)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(bool3x3 lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(bool3x3 lhs, bool rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ==(bool lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(bool3x3 lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(bool3x3 lhs, bool rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !=(bool lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator !(bool3x3 val)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator &(bool3x3 lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator &(bool3x3 lhs, bool rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator &(bool lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator |(bool3x3 lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator |(bool3x3 lhs, bool rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator |(bool lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ^(bool3x3 lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ^(bool3x3 lhs, bool rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool3x3 operator ^(bool lhs, bool3x3 rhs)
	{
		return default(bool3x3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(bool3x3 rhs)
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
}
