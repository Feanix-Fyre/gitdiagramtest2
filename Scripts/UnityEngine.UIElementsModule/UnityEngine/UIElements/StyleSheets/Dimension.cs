using System;

namespace UnityEngine.UIElements.StyleSheets;

[Serializable]
internal struct Dimension : IEquatable<Dimension>
{
	public enum Unit
	{
		Unitless = 0,
		Pixel = 1,
		Percent = 2,
		Second = 3,
		Millisecond = 4,
		Degree = 5,
		Gradian = 6,
		Radian = 7,
		Turn = 8
	}

	public Unit unit;

	public float value;

	public Dimension(float value, Unit unit)
	{
		this.unit = default(Unit);
		this.value = 0f;
	}

	public Length ToLength()
	{
		return default(Length);
	}

	public TimeValue ToTime()
	{
		return default(TimeValue);
	}

	public Angle ToAngle()
	{
		return default(Angle);
	}

	public static bool operator ==(Dimension lhs, Dimension rhs)
	{
		return false;
	}

	public bool Equals(Dimension other)
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
