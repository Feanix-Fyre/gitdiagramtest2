using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpMaxIntParameter : VolumeParameter<int>
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

	public NoInterpMaxIntParameter(int value, int max, bool overrideState = false)
	{
	}
}
