using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class Texture3DParameter : VolumeParameter<Texture>
{
	public Texture3DParameter(Texture value, bool overrideState = false)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
