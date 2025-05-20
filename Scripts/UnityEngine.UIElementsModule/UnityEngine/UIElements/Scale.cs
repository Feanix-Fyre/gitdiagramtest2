using System;

namespace UnityEngine.UIElements;

public struct Scale : IEquatable<Scale>
{
	private Vector3 m_Scale;

	private bool m_IsNone;

	public Vector3 value => default(Vector3);

	public Scale(Vector3 scale)
	{
		m_Scale = default(Vector3);
		m_IsNone = false;
	}

	internal static Scale Initial()
	{
		return default(Scale);
	}

	public static Scale None()
	{
		return default(Scale);
	}

	public static bool operator ==(Scale lhs, Scale rhs)
	{
		return false;
	}

	public static bool operator !=(Scale lhs, Scale rhs)
	{
		return false;
	}

	public bool Equals(Scale other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
