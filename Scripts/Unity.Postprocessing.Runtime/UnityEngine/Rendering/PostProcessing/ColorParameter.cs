using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ColorParameter : ParameterOverride<Color>
{
	public override void Interp(Color from, Color to, float t)
	{
	}

	public static implicit operator Vector4(ColorParameter prop)
	{
		return default(Vector4);
	}
}
