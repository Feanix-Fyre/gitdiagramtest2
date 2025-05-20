using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(GrainRenderer), "Unity/Grain", true)]
public sealed class Grain : PostProcessEffectSettings
{
	[Tooltip("Enable the use of colored grain.")]
	public BoolParameter colored;

	[Range(0f, 1f)]
	[Tooltip("Grain strength. Higher values mean more visible grain.")]
	public FloatParameter intensity;

	[Range(0.3f, 3f)]
	[Tooltip("Grain particle size.")]
	public FloatParameter size;

	[Range(0f, 1f)]
	[DisplayName("Luminance Contribution")]
	[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
	public FloatParameter lumContrib;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}
}
