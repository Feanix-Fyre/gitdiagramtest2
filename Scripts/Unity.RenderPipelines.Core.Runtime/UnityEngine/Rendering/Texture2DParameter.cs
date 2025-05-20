using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class Texture2DParameter : VolumeParameter<Texture>
{
	public Texture2DParameter(Texture value, bool overrideState = false)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
