using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(VignetteRenderer), "Unity/Vignette", true)]
public sealed class Vignette : PostProcessEffectSettings
{
	[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
	public VignetteModeParameter mode;

	[Tooltip("Vignette color.")]
	public ColorParameter color;

	[Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center;

	[Range(0f, 1f)]
	[Tooltip("Amount of vignetting on screen.")]
	public FloatParameter intensity;

	[Range(0.01f, 1f)]
	[Tooltip("Smoothness of the vignette borders.")]
	public FloatParameter smoothness;

	[Tooltip("Lower values will make a square-ish vignette.")]
	[Range(0f, 1f)]
	public FloatParameter roundness;

	[Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
	public BoolParameter rounded;

	[Tooltip("A black and white mask to use as a vignette.")]
	public TextureParameter mask;

	[Tooltip("Mask opacity.")]
	[Range(0f, 1f)]
	public FloatParameter opacity;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}
}
