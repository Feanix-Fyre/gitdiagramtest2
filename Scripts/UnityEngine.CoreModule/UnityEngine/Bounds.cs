using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Geometry/AABB.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeClass("AABB")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
public struct Bounds : IEquatable<Bounds>, IFormattable
{
	private Vector3 m_Center;

	[NativeName("m_Extent")]
	private Vector3 m_Extents;

	public Vector3 center
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector3 size
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector3 extents
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector3 min
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector3 max
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Bounds(Vector3 center, Vector3 size)
	{
		m_Center = default(Vector3);
		m_Extents = default(Vector3);
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
	public bool Equals(Bounds other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Bounds lhs, Bounds rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Bounds lhs, Bounds rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetMinMax(Vector3 min, Vector3 max)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Encapsulate(Vector3 point)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Encapsulate(Bounds bounds)
	{
	}

	public void Expand(float amount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Expand(Vector3 amount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Intersects(Bounds bounds)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IntersectRay(Ray ray)
	{
		return false;
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

	[NativeMethod("IsInside", IsThreadSafe = true)]
	public bool Contains(Vector3 point)
	{
		return false;
	}

	[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = true, IsThreadSafe = true)]
	public float SqrDistance(Vector3 point)
	{
		return 0f;
	}

	[FreeFunction("IntersectRayAABB", IsThreadSafe = true)]
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
	{
		dist = default(float);
		return false;
	}

	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point)
	{
		return false;
	}

	private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point)
	{
		return 0f;
	}

	private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist)
	{
		dist = default(float);
		return false;
	}
}
