using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpTextureParameter : VolumeParameter<Texture>
{
	public NoInterpTextureParameter(Texture value, bool overrideState = false)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
