using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class ClampedIntParameter : IntParameter
{
	[NonSerialized]
	public int min;

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

	public ClampedIntParameter(int value, int min, int max, bool overrideState = false)
		: base(0)
	{
	}
}
