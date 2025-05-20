using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/Depth Of Field", new Type[] { typeof(UniversalRenderPipeline) })]
public sealed class DepthOfField : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Use \"Gaussian\" for a faster but non physical depth of field; \"Bokeh\" for a more realistic but slower depth of field.")]
	public DepthOfFieldModeParameter mode;

	[Tooltip("The distance at which the blurring will start.")]
	public MinFloatParameter gaussianStart;

	[Tooltip("The distance at which the blurring will reach its maximum radius.")]
	public MinFloatParameter gaussianEnd;

	[Tooltip("The maximum radius of the gaussian blur. Values above 1 may show under-sampling artifacts.")]
	public ClampedFloatParameter gaussianMaxRadius;

	[Tooltip("Use higher quality sampling to reduce flickering and improve the overall blur smoothness.")]
	public BoolParameter highQualitySampling;

	[Tooltip("The distance to the point of focus.")]
	public MinFloatParameter focusDistance;

	[Tooltip("The ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	public ClampedFloatParameter aperture;

	[Tooltip("The distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	public ClampedFloatParameter focalLength;

	[Tooltip("The number of aperture blades.")]
	public ClampedIntParameter bladeCount;

	[Tooltip("The curvature of aperture blades. The smaller the value is, the more visible aperture blades are. A value of 1 will make the bokeh perfectly circular.")]
	public ClampedFloatParameter bladeCurvature;

	[Tooltip("The rotation of aperture blades in degrees.")]
	public ClampedFloatParameter bladeRotation;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}
}
