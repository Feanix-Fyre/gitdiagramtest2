using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Math/Rect.h")]
[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
public struct Rect : IEquatable<Rect>, IFormattable
{
	[NativeName("x")]
	private float m_XMin;

	[NativeName("y")]
	private float m_YMin;

	[NativeName("width")]
	private float m_Width;

	[NativeName("height")]
	private float m_Height;

	public static Rect zero => default(Rect);

	public float x
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

	public float y
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

	public Vector2 position
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector2 center
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector2 min
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector2 max
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public float width
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

	public float height
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

	public Vector2 size
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public float xMin
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

	public float yMin
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

	public float xMax
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

	public float yMax
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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Rect(float x, float y, float width, float height)
	{
		m_XMin = 0f;
		m_YMin = 0f;
		m_Width = 0f;
		m_Height = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Rect(Vector2 position, Vector2 size)
	{
		m_XMin = 0f;
		m_YMin = 0f;
		m_Width = 0f;
		m_Height = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Rect(Rect source)
	{
		m_XMin = 0f;
		m_YMin = 0f;
		m_Width = 0f;
		m_Height = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
	{
		return default(Rect);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float x, float y, float width, float height)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Contains(Vector2 point)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Contains(Vector3 point)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static Rect OrderMinMax(Rect rect)
	{
		return default(Rect);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Overlaps(Rect other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Overlaps(Rect other, bool allowInverse)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Rect lhs, Rect rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Rect lhs, Rect rhs)
	{
		return false;
	}

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
	public bool Equals(Rect other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}
}
