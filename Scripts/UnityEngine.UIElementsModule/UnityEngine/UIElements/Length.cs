using System;

namespace UnityEngine.UIElements;

[Serializable]
public struct Length : IEquatable<Length>
{
	private enum Unit
	{
		Pixel = 0,
		Percent = 1,
		Auto = 2,
		None = 3
	}

	internal const float k_MaxValue = 8388608f;

	[SerializeField]
	private float m_Value;

	[SerializeField]
	private Unit m_Unit;

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public LengthUnit unit => default(LengthUnit);

	public static Length Percent(float value)
	{
		return default(Length);
	}

	public static Length Auto()
	{
		return default(Length);
	}

	public static Length None()
	{
		return default(Length);
	}

	public bool IsAuto()
	{
		return false;
	}

	public bool IsNone()
	{
		return false;
	}

	public Length(float value)
	{
		m_Value = 0f;
		m_Unit = default(Unit);
	}

	public Length(float value, LengthUnit unit)
	{
		m_Value = 0f;
		m_Unit = default(Unit);
	}

	private Length(float value, Unit unit)
	{
		m_Value = 0f;
		m_Unit = default(Unit);
	}

	public static implicit operator Length(float value)
	{
		return default(Length);
	}

	public static bool operator ==(Length lhs, Length rhs)
	{
		return false;
	}

	public static bool operator !=(Length lhs, Length rhs)
	{
		return false;
	}

	public bool Equals(Length other)
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
