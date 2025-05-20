using System;

namespace UnityEngine.UIElements;

public struct TimerState : IEquatable<TimerState>
{
	public long start { get; set; }

	public long now { get; set; }

	public long deltaTime => 0L;

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(TimerState other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
