using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector2f")]
public struct Vector2 : IEquatable<Vector2>, IFormattable
{
	public float x;

	public float y;

	private static readonly Vector2 zeroVector;

	private static readonly Vector2 oneVector;

	private static readonly Vector2 upVector;

	private static readonly Vector2 downVector;

	private static readonly Vector2 leftVector;

	private static readonly Vector2 rightVector;

	private static readonly Vector2 positiveInfinityVector;

	private static readonly Vector2 negativeInfinityVector;

	public const float kEpsilon = 1E-05f;

	public const float kEpsilonNormalSqrt = 1E-15f;

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

	public Vector2 normalized
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
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

	public float sqrMagnitude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public static Vector2 zero
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public static Vector2 one
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public static Vector2 up
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public static Vector2 down
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public static Vector2 left
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public static Vector2 right
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public static Vector2 positiveInfinity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public static Vector2 negativeInfinity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2(float x, float y)
	{
		this.x = 0f;
		this.y = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float newX, float newY)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Scale(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Normalize()
	{
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
	public bool Equals(Vector2 other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Perpendicular(Vector2 inDirection)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dot(Vector2 lhs, Vector2 rhs)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Angle(Vector2 from, Vector2 to)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SignedAngle(Vector2 from, Vector2 to)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Distance(Vector2 a, Vector2 b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SqrMagnitude(Vector2 a)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Min(Vector2 lhs, Vector2 rhs)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Max(Vector2 lhs, Vector2 rhs)
	{
		return default(Vector2);
	}

	public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator +(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator -(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator *(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator /(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator -(Vector2 a)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator *(Vector2 a, float d)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator *(float d, Vector2 a)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 operator /(Vector2 a, float d)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector2 lhs, Vector2 rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector2 lhs, Vector2 rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector2(Vector3 v)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector3(Vector2 v)
	{
		return default(Vector3);
	}
}
