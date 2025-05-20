using System;
using System.Runtime.CompilerServices;

namespace UnityEngine;

public struct Ray : IFormattable
{
	private Vector3 m_Origin;

	private Vector3 m_Direction;

	public Vector3 origin
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

	public Vector3 direction
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
	public Ray(Vector3 origin, Vector3 direction)
	{
		m_Origin = default(Vector3);
		m_Direction = default(Vector3);
	}

	public Vector3 GetPoint(float distance)
	{
		return default(Vector3);
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
