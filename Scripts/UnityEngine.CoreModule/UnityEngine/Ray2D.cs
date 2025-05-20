using System;
using System.Runtime.CompilerServices;

namespace UnityEngine;

public struct Ray2D : IFormattable
{
	private Vector2 m_Origin;

	private Vector2 m_Direction;

	public Vector2 origin
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	public Vector2 direction
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector2);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Ray2D(Vector2 origin, Vector2 direction)
	{
		m_Origin = default(Vector2);
		m_Direction = default(Vector2);
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
