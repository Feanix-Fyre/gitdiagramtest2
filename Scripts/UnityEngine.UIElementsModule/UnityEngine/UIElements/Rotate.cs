using System;

namespace UnityEngine.UIElements;

public struct Rotate : IEquatable<Rotate>
{
	private Angle m_Angle;

	private Vector3 m_Axis;

	private bool m_IsNone;

	public Angle angle
	{
		get
		{
			return default(Angle);
		}
		set
		{
		}
	}

	internal Vector3 axis => default(Vector3);

	public Rotate(Angle angle)
	{
		m_Angle = default(Angle);
		m_Axis = default(Vector3);
		m_IsNone = false;
	}

	internal static Rotate Initial()
	{
		return default(Rotate);
	}

	public static Rotate None()
	{
		return default(Rotate);
	}

	public static bool operator ==(Rotate lhs, Rotate rhs)
	{
		return false;
	}

	public static bool operator !=(Rotate lhs, Rotate rhs)
	{
		return false;
	}

	public bool Equals(Rotate other)
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

	internal Quaternion ToQuaternion()
	{
		return default(Quaternion);
	}
}
