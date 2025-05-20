using System;

namespace UnityEngine.UIElements;

public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter>
{
	public MouseButton button { get; set; }

	public EventModifiers modifiers { get; set; }

	public int clickCount { get; }

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ManipulatorActivationFilter other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool Matches(IMouseEvent e)
	{
		return false;
	}

	private bool HasModifiers(IMouseEvent e)
	{
		return false;
	}

	public bool Matches(IPointerEvent e)
	{
		return false;
	}

	private bool HasModifiers(IPointerEvent e)
	{
		return false;
	}

	private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command)
	{
		return false;
	}
}
