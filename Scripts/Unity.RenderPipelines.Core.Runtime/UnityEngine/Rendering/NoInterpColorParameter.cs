using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpColorParameter : VolumeParameter<Color>
{
	public bool hdr;

	[NonSerialized]
	public bool showAlpha;

	[NonSerialized]
	public bool showEyeDropper;

	public NoInterpColorParameter(Color value, bool overrideState = false)
	{
	}

	public NoInterpColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
	{
	}
}
