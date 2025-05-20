using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(MotionBlurRenderer), "Unity/Motion Blur", false)]
public sealed class MotionBlur : PostProcessEffectSettings
{
	[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
	[Range(0f, 360f)]
	public FloatParameter shutterAngle;

	[Range(4f, 32f)]
	[Tooltip("The amount of sample points. This affects quality and performance.")]
	public IntParameter sampleCount;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}
}
