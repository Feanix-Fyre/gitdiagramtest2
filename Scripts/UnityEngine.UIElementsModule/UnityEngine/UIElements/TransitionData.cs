using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData>
{
	public List<TimeValue> transitionDelay;

	public List<TimeValue> transitionDuration;

	public List<StylePropertyName> transitionProperty;

	public List<EasingFunction> transitionTimingFunction;

	public TransitionData Copy()
	{
		return default(TransitionData);
	}

	public void CopyFrom(ref TransitionData other)
	{
	}

	public static bool operator ==(TransitionData lhs, TransitionData rhs)
	{
		return false;
	}

	public bool Equals(TransitionData other)
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
}
