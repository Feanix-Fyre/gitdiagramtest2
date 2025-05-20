using System;

namespace UnityEngine.UIElements.UIR;

internal class GradientRemapPool : LinkedPool<GradientRemap>
{
	public GradientRemapPool()
		: base((Func<GradientRemap>)null, (Action<GradientRemap>)null, 0)
	{
	}
}
