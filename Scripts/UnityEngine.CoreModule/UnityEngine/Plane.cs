using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public struct Plane : IFormattable
{
	internal const int size = 16;

	private Vector3 m_Normal;

	private float m_Distance;

	public Vector3 normal
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Vector3);
		}
	}

	public float distance
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
	public Plane(Vector3 inNormal, Vector3 inPoint)
	{
		m_Normal = default(Vector3);
		m_Distance = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Plane(Vector3 inNormal, float d)
	{
		m_Normal = default(Vector3);
		m_Distance = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Plane(Vector3 a, Vector3 b, Vector3 c)
	{
		m_Normal = default(Vector3);
		m_Distance = 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float GetDistanceToPoint(Vector3 point)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Raycast(Ray ray, out float enter)
	{
		enter = default(float);
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
}
