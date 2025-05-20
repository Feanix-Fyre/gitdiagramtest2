using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Lift, Gamma, Gain", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Use this to control and apply a hue to the dark tones. This has a more exaggerated effect on shadows.")]
	public Vector4Parameter lift;

	[Tooltip("Use this to control and apply a hue to the mid-range tones with a power function.")]
	public Vector4Parameter gamma;

	[Tooltip("Use this to increase and apply a hue to the signal and make highlights brighter.")]
	public Vector4Parameter gain;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
