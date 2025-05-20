using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct bool4x4 : IEquatable<bool4x4>
{
	public bool4 c0;

	public bool4 c1;

	public bool4 c2;

	public bool4 c3;

	public ref bool4 this[int index]
	{
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3)
	{
		this.c0 = default(bool4);
		this.c1 = default(bool4);
		this.c2 = default(bool4);
		this.c3 = default(bool4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33)
	{
		c0 = default(bool4);
		c1 = default(bool4);
		c2 = default(bool4);
		c3 = default(bool4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool4x4(bool v)
	{
		c0 = default(bool4);
		c1 = default(bool4);
		c2 = default(bool4);
		c3 = default(bool4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator bool4x4(bool v)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(bool4x4 lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(bool4x4 lhs, bool rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ==(bool lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(bool4x4 lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(bool4x4 lhs, bool rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !=(bool lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator !(bool4x4 val)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator &(bool4x4 lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator &(bool4x4 lhs, bool rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator &(bool lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator |(bool4x4 lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator |(bool4x4 lhs, bool rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator |(bool lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ^(bool4x4 lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ^(bool4x4 lhs, bool rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool4x4 operator ^(bool lhs, bool4x4 rhs)
	{
		return default(bool4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(bool4x4 rhs)
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
