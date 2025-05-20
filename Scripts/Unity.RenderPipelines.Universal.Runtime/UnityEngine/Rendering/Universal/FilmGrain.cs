using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Film Grain", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class FilmGrain : VolumeComponent, IPostProcessComponent
{
	[Tooltip("The type of grain to use. You can select a preset or provide your own texture by selecting Custom.")]
	public FilmGrainLookupParameter type;

	[Tooltip("Use the slider to set the strength of the Film Grain effect.")]
	public ClampedFloatParameter intensity;

	[Tooltip("Controls the noisiness response curve based on scene luminance. Higher values mean less noise in light areas.")]
	public ClampedFloatParameter response;

	[Tooltip("A tileable texture to use for the grain. The neutral value is 0.5 where no grain is applied.")]
	public NoInterpTextureParameter texture;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
