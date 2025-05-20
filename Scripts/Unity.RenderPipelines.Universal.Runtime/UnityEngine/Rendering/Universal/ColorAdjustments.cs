using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Color Adjustments", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Adjusts the overall exposure of the scene in EV100. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure;

	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public ClampedFloatParameter contrast;

	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter;

	[Tooltip("Shift the hue of all colors.")]
	public ClampedFloatParameter hueShift;

	[Tooltip("Pushes the intensity of all colors.")]
	public ClampedFloatParameter saturation;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
