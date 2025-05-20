using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Motion Blur", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class MotionBlur : VolumeComponent, IPostProcessComponent
{
	[Tooltip("The motion blur technique to use. If you don't need object motion blur, CameraOnly will result in better performance.")]
	public MotionBlurModeParameter mode;

	[Tooltip("The quality of the effect. Lower presets will result in better performance at the expense of visual quality.")]
	public MotionBlurQualityParameter quality;

	[Tooltip("The strength of the motion blur filter. Acts as a multiplier for velocities.")]
	public ClampedFloatParameter intensity;

	[Tooltip("Sets the maximum length, as a fraction of the screen's full resolution, that the velocity resulting from Camera rotation can have. Lower values will improve performance.")]
	public ClampedFloatParameter clamp;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
