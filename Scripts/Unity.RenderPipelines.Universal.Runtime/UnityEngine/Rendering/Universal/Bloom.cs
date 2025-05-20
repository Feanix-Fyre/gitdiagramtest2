using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Bloom", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class Bloom : VolumeComponent, IPostProcessComponent
{
	[Tooltip("The number of final iterations to skip in the effect processing sequence.")]
	[Obsolete("This is obsolete, please use maxIterations instead.", false)]
	public ClampedIntParameter skipIterations;

	[Header("Bloom")]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public MinFloatParameter threshold;

	[Tooltip("Strength of the bloom filter.")]
	public MinFloatParameter intensity;

	[Tooltip("Set the radius of the bloom effect.")]
	public ClampedFloatParameter scatter;

	[Tooltip("Set the maximum intensity that Unity uses to calculate Bloom. If pixels in your Scene are more intense than this, URP renders them at their current intensity, but uses this intensity value for the purposes of Bloom calculations.")]
	public MinFloatParameter clamp;

	[Tooltip("Use the color picker to select a color for the Bloom effect to tint to.")]
	public ColorParameter tint;

	[Tooltip("Use bicubic sampling instead of bilinear sampling for the upsampling passes. This is slightly more expensive but helps getting smoother visuals.")]
	public BoolParameter highQualityFiltering;

	[AdditionalProperty]
	[Tooltip("The starting resolution that this effect begins processing.")]
	public DownscaleParameter downscale;

	[AdditionalProperty]
	[Tooltip("The maximum number of iterations in the effect processing sequence.")]
	public ClampedIntParameter maxIterations;

	[Tooltip("Dirtiness texture to add smudges or dust to the bloom effect.")]
	[Header("Lens Dirt")]
	public TextureParameter dirtTexture;

	[Tooltip("Amount of dirtiness.")]
	public MinFloatParameter dirtIntensity;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
