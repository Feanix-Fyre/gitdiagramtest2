using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeType("Runtime/Math/Vector2Int.h")]
[DefaultMember("Item")]
[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
	private int m_X;

	private int m_Y;

	private static readonly Vector2Int s_Zero;

	private static readonly Vector2Int s_One;

	private static readonly Vector2Int s_Up;

	private static readonly Vector2Int s_Down;

	private static readonly Vector2Int s_Left;

	private static readonly Vector2Int s_Right;

	public int x
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public int y
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public float magnitude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public static Vector2Int zero
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2Int);
		}
	}

	public static Vector2Int one
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2Int);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2Int(int x, int y)
	{
		m_X = 0;
		m_Y = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs)
	{
		return default(Vector2Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector2(Vector2Int v)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2Int FloorToInt(Vector2 v)
	{
		return default(Vector2Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2Int operator *(Vector2Int a, int b)
	{
		return default(Vector2Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector2Int lhs, Vector2Int rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector2Int lhs, Vector2Int rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector2Int other)
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
