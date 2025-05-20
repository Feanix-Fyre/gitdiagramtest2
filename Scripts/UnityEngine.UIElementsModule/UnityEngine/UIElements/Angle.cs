using System;

namespace UnityEngine.UIElements;

public struct Angle : IEquatable<Angle>
{
	private enum Unit
	{
		Degree = 0,
		Gradian = 1,
		Radian = 2,
		Turn = 3,
		None = 4
	}

	private float m_Value;

	private Unit m_Unit;

	public float value => 0f;

	internal static Angle None()
	{
		return default(Angle);
	}

	public Angle(float value, AngleUnit unit)
	{
		m_Value = 0f;
		m_Unit = default(Unit);
	}

	private Angle(float value, Unit unit)
	{
		m_Value = 0f;
		m_Unit = default(Unit);
	}

	public float ToDegrees()
	{
		return 0f;
	}

	public static implicit operator Angle(float value)
	{
		return default(Angle);
	}

	public static bool operator ==(Angle lhs, Angle rhs)
	{
		return false;
	}

	public bool Equals(Angle other)
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
