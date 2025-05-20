using System;

namespace UnityEngine;

public sealed class WaitWhile : CustomYieldInstruction
{
	private Func<bool> m_Predicate;

	public override bool keepWaiting => false;

	public WaitWhile(Func<bool> predicate)
	{
	}
}
