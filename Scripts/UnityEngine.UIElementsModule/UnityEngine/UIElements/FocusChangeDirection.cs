using System;

namespace UnityEngine.UIElements;

public class FocusChangeDirection : IDisposable
{
	private readonly int m_Value;

	public static FocusChangeDirection unspecified { get; }

	public static FocusChangeDirection none { get; }

	protected static FocusChangeDirection lastValue { get; }

	protected FocusChangeDirection(int value)
	{
	}

	public static implicit operator int(FocusChangeDirection fcd)
	{
		return 0;
	}

	void IDisposable.Dispose()
	{
	}

	protected virtual void Dispose()
	{
	}

	internal virtual void ApplyTo(FocusController focusController, Focusable f)
	{
	}
}
