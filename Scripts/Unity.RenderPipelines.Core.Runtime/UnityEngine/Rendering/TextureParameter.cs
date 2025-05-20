using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class TextureParameter : VolumeParameter<Texture>
{
	public TextureDimension dimension;

	public TextureParameter(Texture value, bool overrideState = false)
	{
	}

	public TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
