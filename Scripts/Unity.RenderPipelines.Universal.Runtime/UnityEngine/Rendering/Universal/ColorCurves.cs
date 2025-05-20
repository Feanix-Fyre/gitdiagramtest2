using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Color Curves", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class ColorCurves : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Affects the luminance across the whole image.")]
	public TextureCurveParameter master;

	[Tooltip("Affects the red channel intensity across the whole image.")]
	public TextureCurveParameter red;

	[Tooltip("Affects the green channel intensity across the whole image.")]
	public TextureCurveParameter green;

	[Tooltip("Affects the blue channel intensity across the whole image.")]
	public TextureCurveParameter blue;

	[Tooltip("Shifts the input hue (x-axis) according to the output hue (y-axis).")]
	public TextureCurveParameter hueVsHue;

	[Tooltip("Adjusts saturation (y-axis) according to the input hue (x-axis).")]
	public TextureCurveParameter hueVsSat;

	[Tooltip("Adjusts saturation (y-axis) according to the input saturation (x-axis).")]
	public TextureCurveParameter satVsSat;

	[Tooltip("Adjusts saturation (y-axis) according to the input luminance (x-axis).")]
	public TextureCurveParameter lumVsSat;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
