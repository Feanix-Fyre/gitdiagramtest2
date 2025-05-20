using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Panini Projection", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Panini projection distance.")]
	public ClampedFloatParameter distance;

	[Tooltip("Panini projection crop to fit.")]
	public ClampedFloatParameter cropToFit;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
