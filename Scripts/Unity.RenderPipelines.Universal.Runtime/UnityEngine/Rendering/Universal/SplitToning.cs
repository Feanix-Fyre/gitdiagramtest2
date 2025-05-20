using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Split Toning", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class SplitToning : VolumeComponent, IPostProcessComponent
{
	[Tooltip("The color to use for shadows.")]
	public ColorParameter shadows;

	[Tooltip("The color to use for highlights.")]
	public ColorParameter highlights;

	[Tooltip("Balance between the colors in the highlights and shadows.")]
	public ClampedFloatParameter balance;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
