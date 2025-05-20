using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(LensDistortionRenderer), "Unity/Lens Distortion", true)]
public sealed class LensDistortion : PostProcessEffectSettings
{
	[Range(-100f, 100f)]
	[Tooltip("Total distortion amount.")]
	public FloatParameter intensity;

	[DisplayName("X Multiplier")]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	[Range(0f, 1f)]
	public FloatParameter intensityX;

	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	[DisplayName("Y Multiplier")]
	[Range(0f, 1f)]
	public FloatParameter intensityY;

	[Space]
	[Tooltip("Distortion center point (x-axis).")]
	[Range(-1f, 1f)]
	public FloatParameter centerX;

	[Range(-1f, 1f)]
	[Tooltip("Distortion center point (y-axis).")]
	public FloatParameter centerY;

	[Space]
	[Range(0.01f, 5f)]
	[Tooltip("Global screen scaling.")]
	public FloatParameter scale;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}
}
