using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class MinFloatParameter : FloatParameter
{
	[NonSerialized]
	public float min;

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

	public MinFloatParameter(float value, float min, bool overrideState = false)
		: base(0f)
	{
	}
}
