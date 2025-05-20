using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class FloatParameter : VolumeParameter<float>
{
	public FloatParameter(float value, bool overrideState = false)
	{
	}

	public sealed override void Interp(float from, float to, float t)
	{
	}
}
