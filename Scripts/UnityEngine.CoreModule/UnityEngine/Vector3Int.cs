using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
[DefaultMember("Item")]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
{
	private int m_X;

	private int m_Y;

	private int m_Z;

	private static readonly Vector3Int s_Zero;

	private static readonly Vector3Int s_One;

	private static readonly Vector3Int s_Up;

	private static readonly Vector3Int s_Down;

	private static readonly Vector3Int s_Left;

	private static readonly Vector3Int s_Right;

	private static readonly Vector3Int s_Forward;

	private static readonly Vector3Int s_Back;

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

	public int z
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

	public static Vector3Int zero
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3Int);
		}
	}

	public static Vector3Int one
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3Int);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3Int(int x, int y, int z)
	{
		m_X = 0;
		m_Y = 0;
		m_Z = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs)
	{
		return default(Vector3Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs)
	{
		return default(Vector3Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector3(Vector3Int v)
	{
		return default(Vector3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Int operator +(Vector3Int a, Vector3Int b)
	{
		return default(Vector3Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Int operator -(Vector3Int a, Vector3Int b)
	{
		return default(Vector3Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Int operator *(Vector3Int a, int b)
	{
		return default(Vector3Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Int operator /(Vector3Int a, int b)
	{
		return default(Vector3Int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector3Int lhs, Vector3Int rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector3Int lhs, Vector3Int rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector3Int other)
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
