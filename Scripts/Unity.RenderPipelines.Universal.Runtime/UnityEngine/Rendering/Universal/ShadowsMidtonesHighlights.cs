using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Shadows, Midtones, Highlights", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Use this to control and apply a hue to the shadows.")]
	public Vector4Parameter shadows;

	[Tooltip("Use this to control and apply a hue to the midtones.")]
	public Vector4Parameter midtones;

	[Tooltip("Use this to control and apply a hue to the highlights.")]
	public Vector4Parameter highlights;

	[Tooltip("Start point of the transition between shadows and midtones.")]
	[Header("Shadow Limits")]
	public MinFloatParameter shadowsStart;

	[Tooltip("End point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsEnd;

	[Header("Highlight Limits")]
	[Tooltip("Start point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsStart;

	[Tooltip("End point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsEnd;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
