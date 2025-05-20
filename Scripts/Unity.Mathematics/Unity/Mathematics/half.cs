using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics;

[Serializable]
[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
public struct half : IEquatable<half>, IFormattable
{
	public ushort value;

	public static readonly half zero;

	public static float MaxValue => 0f;

	public static float MinValue => 0f;

	public static half MaxValueAsHalf => default(half);

	public static half MinValueAsHalf => default(half);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public half(half x)
	{
		value = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public half(float v)
	{
		value = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public half(double v)
	{
		value = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator half(float v)
	{
		return default(half);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator half(double v)
	{
		return default(half);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator float(half d)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator double(half d)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(half lhs, half rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(half lhs, half rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(half rhs)
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
