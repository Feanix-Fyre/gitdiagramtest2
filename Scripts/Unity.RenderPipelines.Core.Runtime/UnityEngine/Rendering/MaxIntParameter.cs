using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class MaxIntParameter : IntParameter
{
	[NonSerialized]
	public int max;

	public override int value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MaxIntParameter(int value, int max, bool overrideState = false)
		: base(0)
	{
	}
}
