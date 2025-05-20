using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Vignette", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class Vignette : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Vignette color.")]
	public ColorParameter color;

	[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
	public Vector2Parameter center;

	[Tooltip("Amount of vignetting on screen.")]
	public ClampedFloatParameter intensity;

	[Tooltip("Smoothness of the vignette borders.")]
	public ClampedFloatParameter smoothness;

	[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
	public BoolParameter rounded;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
