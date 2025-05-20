using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpMaxFloatParameter : VolumeParameter<float>
{
	[NonSerialized]
	public float max;

	public override float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public NoInterpMaxFloatParameter(float value, float max, bool overrideState = false)
	{
	}
}
