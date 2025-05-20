using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpMinIntParameter : VolumeParameter<int>
{
	[NonSerialized]
	public int min;

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

	public NoInterpMinIntParameter(int value, int min, bool overrideState = false)
	{
	}
}
