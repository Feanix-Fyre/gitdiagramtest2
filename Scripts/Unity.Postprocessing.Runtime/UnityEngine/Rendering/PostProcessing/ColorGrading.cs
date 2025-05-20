using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(ColorGradingRenderer), "Unity/Color Grading", true)]
public sealed class ColorGrading : PostProcessEffectSettings
{
	[DisplayName("Mode")]
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	public GradingModeParameter gradingMode;

	[DisplayName("Lookup Texture")]
	[Tooltip("A custom 3D log-encoded texture.")]
	public TextureParameter externalLut;

	[DisplayName("Mode")]
	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	public TonemapperParameter tonemapper;

	[DisplayName("Toe Strength")]
	[Range(0f, 1f)]
	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveToeStrength;

	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	[Range(0f, 1f)]
	[DisplayName("Toe Length")]
	public FloatParameter toneCurveToeLength;

	[DisplayName("Shoulder Strength")]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	[Range(0f, 1f)]
	public FloatParameter toneCurveShoulderStrength;

	[DisplayName("Shoulder Length")]
	[Min(0f)]
	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	public FloatParameter toneCurveShoulderLength;

	[DisplayName("Shoulder Angle")]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	[Range(0f, 1f)]
	public FloatParameter toneCurveShoulderAngle;

	[Min(0.001f)]
	[DisplayName("Gamma")]
	[Tooltip("Applies a gamma function to the curve.")]
	public FloatParameter toneCurveGamma;

	[DisplayName("Lookup Texture")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	public TextureParameter ldrLut;

	[Range(0f, 1f)]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	[DisplayName("Contribution")]
	public FloatParameter ldrLutContribution;

	[DisplayName("Temperature")]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	[Range(-100f, 100f)]
	public FloatParameter temperature;

	[DisplayName("Tint")]
	[Range(-100f, 100f)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public FloatParameter tint;

	[ColorUsage(false, true)]
	[DisplayName("Color Filter")]
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter;

	[DisplayName("Hue Shift")]
	[Range(-180f, 180f)]
	[Tooltip("Shift the hue of all colors.")]
	public FloatParameter hueShift;

	[DisplayName("Saturation")]
	[Range(-100f, 100f)]
	[Tooltip("Pushes the intensity of all colors.")]
	public FloatParameter saturation;

	[Tooltip("Makes the image brighter or darker.")]
	[Range(-100f, 100f)]
	[DisplayName("Brightness")]
	public FloatParameter brightness;

	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure;

	[Range(-100f, 100f)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	[DisplayName("Contrast")]
	public FloatParameter contrast;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerRedOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerRedOutGreenIn;

	[DisplayName("Blue")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200f, 200f)]
	public FloatParameter mixerRedOutBlueIn;

	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[DisplayName("Red")]
	[Range(-200f, 200f)]
	public FloatParameter mixerGreenOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerGreenOutGreenIn;

	[DisplayName("Blue")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200f, 200f)]
	public FloatParameter mixerGreenOutBlueIn;

	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Range(-200f, 200f)]
	[DisplayName("Red")]
	public FloatParameter mixerBlueOutRedIn;

	[Range(-200f, 200f)]
	[DisplayName("Green")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerBlueOutGreenIn;

	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Range(-200f, 200f)]
	[DisplayName("Blue")]
	public FloatParameter mixerBlueOutBlueIn;

	[DisplayName("Lift")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Lift)]
	public Vector4Parameter lift;

	[Trackball(TrackballAttribute.Mode.Gamma)]
	[DisplayName("Gamma")]
	[Tooltip("Power function that controls mid-range tones.")]
	public Vector4Parameter gamma;

	[DisplayName("Gain")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Gain)]
	public Vector4Parameter gain;

	public SplineParameter masterCurve;

	public SplineParameter redCurve;

	public SplineParameter greenCurve;

	public SplineParameter blueCurve;

	public SplineParameter hueVsHueCurve;

	public SplineParameter hueVsSatCurve;

	public SplineParameter satVsSatCurve;

	public SplineParameter lumVsSatCurve;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}
}
