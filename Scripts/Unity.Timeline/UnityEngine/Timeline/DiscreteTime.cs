using System;

namespace UnityEngine.Timeline;

internal struct DiscreteTime : IComparable
{
	private const double k_Tick = 1E-12;

	public static readonly DiscreteTime kMaxTime;

	private readonly long m_DiscreteTime;

	public static double tickValue => 0.0;

	public DiscreteTime(DiscreteTime time)
	{
		m_DiscreteTime = 0L;
	}

	private DiscreteTime(long time)
	{
		m_DiscreteTime = 0L;
	}

	public DiscreteTime(double time)
	{
		m_DiscreteTime = 0L;
	}

	public DiscreteTime(float time)
	{
		m_DiscreteTime = 0L;
	}

	public DiscreteTime(int time)
	{
		m_DiscreteTime = 0L;
	}

	public DiscreteTime(int frame, double fps)
	{
		m_DiscreteTime = 0L;
	}

	public DiscreteTime OneTickBefore()
	{
		return default(DiscreteTime);
	}

	public DiscreteTime OneTickAfter()
	{
		return default(DiscreteTime);
	}

	public long GetTick()
	{
		return 0L;
	}

	public static DiscreteTime FromTicks(long ticks)
	{
		return default(DiscreteTime);
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public bool Equals(DiscreteTime other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	private static long DoubleToDiscreteTime(double time)
	{
		return 0L;
	}

	private static long FloatToDiscreteTime(float time)
	{
		return 0L;
	}

	private static long IntToDiscreteTime(int time)
	{
		return 0L;
	}

	private static double ToDouble(long time)
	{
		return 0.0;
	}

	private static float ToFloat(long time)
	{
		return 0f;
	}

	public static explicit operator double(DiscreteTime b)
	{
		return 0.0;
	}

	public static explicit operator float(DiscreteTime b)
	{
		return 0f;
	}

	public static explicit operator long(DiscreteTime b)
	{
		return 0L;
	}

	public static explicit operator DiscreteTime(double time)
	{
		return default(DiscreteTime);
	}

	public static explicit operator DiscreteTime(float time)
	{
		return default(DiscreteTime);
	}

	public static implicit operator DiscreteTime(int time)
	{
		return default(DiscreteTime);
	}

	public static explicit operator DiscreteTime(long time)
	{
		return default(DiscreteTime);
	}

	public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs)
	{
		return false;
	}

	public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
	{
		return false;
	}

	public static bool operator >(DiscreteTime lhs, DiscreteTime rhs)
	{
		return false;
	}

	public static bool operator <(DiscreteTime lhs, DiscreteTime rhs)
	{
		return false;
	}

	public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs)
	{
		return false;
	}

	public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
	{
		return false;
	}

	public static DiscreteTime operator +(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
	{
		return default(DiscreteTime);
	}

	public static double SnapToNearestTick(double time)
	{
		return 0.0;
	}

	public static float SnapToNearestTick(float time)
	{
		return 0f;
	}

	public static long GetNearestTick(double time)
	{
		return 0L;
	}
}
