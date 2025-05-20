using System;

namespace UnityEngine;

public sealed class WaitUntil : CustomYieldInstruction
{
	private Func<bool> m_Predicate;

	public override bool keepWaiting => false;

	public WaitUntil(Func<bool> predicate)
	{
	}
}
