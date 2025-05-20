using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class ClampedFloatParameter : FloatParameter
{
	[NonSerialized]
	public float min;

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

	public ClampedFloatParameter(float value, float min, float max, bool overrideState = false)
		: base(0f)
	{
	}
}
