using System;

namespace UnityEngine.UIElements;

public struct EasingFunction : IEquatable<EasingFunction>
{
	private EasingMode m_Mode;

	public EasingMode mode => default(EasingMode);

	public EasingFunction(EasingMode mode)
	{
		m_Mode = default(EasingMode);
	}

	public static implicit operator EasingFunction(EasingMode easingMode)
	{
		return default(EasingFunction);
	}

	public static bool operator ==(EasingFunction lhs, EasingFunction rhs)
	{
		return false;
	}

	public bool Equals(EasingFunction other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
