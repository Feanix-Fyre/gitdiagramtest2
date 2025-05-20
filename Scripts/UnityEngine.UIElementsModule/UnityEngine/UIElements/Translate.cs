using System;

namespace UnityEngine.UIElements;

public struct Translate : IEquatable<Translate>
{
	private Length m_X;

	private Length m_Y;

	private float m_Z;

	private bool m_isNone;

	public Length x
	{
		get
		{
			return default(Length);
		}
		set
		{
		}
	}

	public Length y
	{
		get
		{
			return default(Length);
		}
		set
		{
		}
	}

	public float z => 0f;

	public Translate(Length x, Length y, float z)
	{
		m_X = default(Length);
		m_Y = default(Length);
		m_Z = 0f;
		m_isNone = false;
	}

	public static Translate None()
	{
		return default(Translate);
	}

	public static bool operator ==(Translate lhs, Translate rhs)
	{
		return false;
	}

	public static bool operator !=(Translate lhs, Translate rhs)
	{
		return false;
	}

	public bool Equals(Translate other)
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
