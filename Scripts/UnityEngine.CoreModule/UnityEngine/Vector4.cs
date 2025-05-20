using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeClass("Vector4f")]
[NativeHeader("Runtime/Math/Vector4.h")]
[Il2CppEagerStaticClassConstruction]
public struct Vector4 : IEquatable<Vector4>, IFormattable
{
	public const float kEpsilon = 1E-05f;

	public float x;

	public float y;

	public float z;

	public float w;

	private static readonly Vector4 zeroVector;

	private static readonly Vector4 oneVector;

	private static readonly Vector4 positiveInfinityVector;

	private static readonly Vector4 negativeInfinityVector;

	public float this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector4 normalized
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector4);
		}
	}

	public float sqrMagnitude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public static Vector4 zero
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector4);
		}
	}

	public static Vector4 one
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector4);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector4(float x, float y, float z, float w)
	{
		this.x = 0f;
		this.y = 0f;
		this.z = 0f;
		this.w = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector4(float x, float y, float z)
	{
		this.x = 0f;
		this.y = 0f;
		this.z = 0f;
		w = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector4(float x, float y)
	{
		this.x = 0f;
		this.y = 0f;
		z = 0f;
		w = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float newX, float newY, float newZ, float newW)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Scale(Vector4 scale)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector4 other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Normalize(Vector4 a)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dot(Vector4 a, Vector4 b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Magnitude(Vector4 a)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator +(Vector4 a, Vector4 b)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator -(Vector4 a, Vector4 b)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator -(Vector4 a)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator *(Vector4 a, float d)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator *(float d, Vector4 a)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 operator /(Vector4 a, float d)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector4 lhs, Vector4 rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector4 lhs, Vector4 rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector4(Vector3 v)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector3(Vector4 v)
	{
		return default(Vector3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector4(Vector2 v)
	{
		return default(Vector4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector2(Vector4 v)
	{
		return default(Vector2);
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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SqrMagnitude(Vector4 a)
	{
		return 0f;
	}
}
