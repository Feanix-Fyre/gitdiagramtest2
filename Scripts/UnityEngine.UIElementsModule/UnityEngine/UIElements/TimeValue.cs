using System;

namespace UnityEngine.UIElements;

public struct TimeValue : IEquatable<TimeValue>
{
	private float m_Value;

	private TimeUnit m_Unit;

	public float value => 0f;

	public TimeUnit unit => default(TimeUnit);

	public TimeValue(float value)
	{
		m_Value = 0f;
		m_Unit = default(TimeUnit);
	}

	public TimeValue(float value, TimeUnit unit)
	{
		m_Value = 0f;
		m_Unit = default(TimeUnit);
	}

	public static implicit operator TimeValue(float value)
	{
		return default(TimeValue);
	}

	public static bool operator ==(TimeValue lhs, TimeValue rhs)
	{
		return false;
	}

	public static bool operator !=(TimeValue lhs, TimeValue rhs)
	{
		return false;
	}

	public bool Equals(TimeValue other)
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
