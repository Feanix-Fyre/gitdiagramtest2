using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/White Balance", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Sets the white balance to a custom color temperature.")]
	public ClampedFloatParameter temperature;

	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public ClampedFloatParameter tint;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
