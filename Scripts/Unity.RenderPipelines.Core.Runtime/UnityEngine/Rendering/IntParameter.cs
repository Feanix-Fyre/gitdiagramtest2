using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class IntParameter : VolumeParameter<int>
{
	public IntParameter(int value, bool overrideState = false)
	{
	}

	public sealed override void Interp(int from, int to, float t)
	{
	}
}
