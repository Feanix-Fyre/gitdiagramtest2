using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(AmbientOcclusionRenderer), "Unity/Ambient Occlusion", true)]
public sealed class AmbientOcclusion : PostProcessEffectSettings
{
	[Tooltip("The ambient occlusion method to use. \"Multi Scale Volumetric Obscurance\" is higher quality and faster on desktop & console platforms but requires compute shader support.")]
	public AmbientOcclusionModeParameter mode;

	[Range(0f, 4f)]
	[Tooltip("The degree of darkness added by ambient occlusion. Higher values produce darker areas.")]
	public FloatParameter intensity;

	[Tooltip("The custom color to use for the ambient occlusion. The default is black.")]
	[ColorUsage(false)]
	public ColorParameter color;

	[Tooltip("Check this box to mark this Volume as to only affect ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering. Objects rendered with the Forward rendering path won't get any ambient occlusion.")]
	public BoolParameter ambientOnly;

	[Range(-8f, 0f)]
	public FloatParameter noiseFilterTolerance;

	[Range(-8f, -1f)]
	public FloatParameter blurTolerance;

	[Range(-12f, -1f)]
	public FloatParameter upsampleTolerance;

	[Tooltip("This modifies the thickness of occluders. It increases the size of dark areas and also introduces a dark halo around objects.")]
	[Range(1f, 10f)]
	public FloatParameter thicknessModifier;

	[Range(0f, 0.001f)]
	[Tooltip("Add a bias distance to sampled depth in AO to reduce self-shadowing aliasing artifacts. ")]
	public FloatParameter zBias;

	[Range(0f, 1f)]
	[Tooltip("Modifies the influence of direct lighting on ambient occlusion.")]
	public FloatParameter directLightingStrength;

	[Tooltip("The radius of sample points. This affects the size of darkened areas.")]
	public FloatParameter radius;

	[Tooltip("The number of sample points. This affects both quality and performance. For \"Lowest\", \"Low\", and \"Medium\", passes are downsampled. For \"High\" and \"Ultra\", they are not and therefore you should only \"High\" and \"Ultra\" on high-end hardware.")]
	public AmbientOcclusionQualityParameter quality;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}
}
