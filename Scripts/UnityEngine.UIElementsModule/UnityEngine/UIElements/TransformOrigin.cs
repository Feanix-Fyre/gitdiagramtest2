using System;

namespace UnityEngine.UIElements;

public struct TransformOrigin : IEquatable<TransformOrigin>
{
	private Length m_X;

	private Length m_Y;

	private float m_Z;

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

	public TransformOrigin(Length x, Length y, float z)
	{
		m_X = default(Length);
		m_Y = default(Length);
		m_Z = 0f;
	}

	public static TransformOrigin Initial()
	{
		return default(TransformOrigin);
	}

	public static bool operator ==(TransformOrigin lhs, TransformOrigin rhs)
	{
		return false;
	}

	public static bool operator !=(TransformOrigin lhs, TransformOrigin rhs)
	{
		return false;
	}

	public bool Equals(TransformOrigin other)
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
