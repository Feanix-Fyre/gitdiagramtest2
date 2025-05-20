using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Beautify.Universal;

[ExecuteInEditMode]
[VolumeComponentMenu("Kronnect/Beautify")]
public class Beautify : VolumeComponent, IPostProcessComponent
{
	[AttributeUsage(AttributeTargets.Field)]
	public class SectionGroup : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SettingsGroup : Attribute
	{
		private bool? expanded;

		public bool IsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}

	public class GeneralSettings : SectionGroup
	{
	}

	public class ImageEnhancement : SectionGroup
	{
	}

	public class TonemappingAndColorGrading : SectionGroup
	{
	}

	public class LensAndLightingEffects : SectionGroup
	{
	}

	public class ArtisticChoices : SectionGroup
	{
	}

	public class OptimizeBeautifyBuild : SettingsGroup
	{
	}

	public class OptimizeUnityPostProcessingBuild : SettingsGroup
	{
	}

	public class Performance : SettingsGroup
	{
	}

	public class Dither : SettingsGroup
	{
	}

	public class Sharpen : SettingsGroup
	{
	}

	public class EdgeAntialiasing : SettingsGroup
	{
	}

	public class TonemapSettings : SettingsGroup
	{
	}

	public class WhiteBalance : SettingsGroup
	{
	}

	public class LUT : SettingsGroup
	{
	}

	public class Bloom : SettingsGroup
	{
	}

	public class AnamorphicFlares : SettingsGroup
	{
	}

	public class SunFlares : SettingsGroup
	{
	}

	public class LensDirt : SettingsGroup
	{
	}

	public class ChromaticAberration : SettingsGroup
	{
	}

	public class DepthOfField : SettingsGroup
	{
	}

	public class EyeAdaptation : SettingsGroup
	{
	}

	public class PurkinjeShift : SettingsGroup
	{
	}

	public class Vignette : SettingsGroup
	{
	}

	public class Outline : SettingsGroup
	{
	}

	public class NightVision : SettingsGroup
	{
	}

	public class ThermalVision : SettingsGroup
	{
	}

	public class FinalBlur : SettingsGroup
	{
	}

	public class Frame : SettingsGroup
	{
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DisplayName : Attribute
	{
		public string name;

		public DisplayName(string name)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DisplayConditionEnum : Attribute
	{
		public string field;

		public int enumValueIndex;

		public bool isEqual;

		public DisplayConditionEnum(string field, int enumValueIndex, bool isEqual = true)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DisplayConditionBool : Attribute
	{
		public string field;

		public bool value;

		public string field2;

		public bool value2;

		public DisplayConditionBool(string field, bool value = true, string field2 = null, bool value2 = true)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ToggleAllFields : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class GlobalOverride : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class BuildToggle : Attribute
	{
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowStrippedLabel : Attribute
	{
	}

	public enum CompareStyle
	{
		FreeAngle = 0,
		VerticalLine = 1,
		SameSide = 2
	}

	public enum TonemapOperator
	{
		Linear = 0,
		ACES = 1
	}

	public enum DoFFocusMode
	{
		FixedDistance = 0,
		AutoFocus = 1,
		FollowTarget = 2
	}

	public enum DoFTargetFallback
	{
		KeepCurrentFocalDistance = 0,
		SwitchToAutofocus = 1,
		FixedDistanceFocus = 2
	}

	public enum DoFBokehComposition
	{
		Integrated = 0,
		Separated = 1
	}

	public enum DoFCameraSettings
	{
		Classic = 0,
		Real = 1
	}

	public enum VignetteFitMode
	{
		FitToWidth = 0,
		FitToHeight = 1
	}

	public enum DebugOutput
	{
		Nothing = 0,
		BloomAndFlares = 10,
		BloomExclusionPass = 11,
		AnamorphicFlaresExclusionPass = 12,
		DepthOfFieldCoC = 20,
		DepthOfFieldTransparentPass = 21
	}

	public enum BlinkStyle
	{
		Cutscene = 0,
		Human = 1
	}

	public enum OutlineStage
	{
		BeforeBloom = 0,
		AfterBloom = 10
	}

	public enum DownsamplingMode
	{
		BeautifyEffectsOnly = 0,
		FullFrame = 10
	}

	public enum SunFlaresDepthOcclusionMode
	{
		None = 0,
		Simple = 1,
		Smooth = 2
	}

	[Serializable]
	public sealed class BeautifyCompareStyleParameter : VolumeParameter<CompareStyle>
	{
	}

	[Serializable]
	public sealed class BeautifyDownsamplingModeParameter : VolumeParameter<DownsamplingMode>
	{
	}

	[Serializable]
	public sealed class BeautifyTonemapOperatorParameter : VolumeParameter<TonemapOperator>
	{
	}

	[Serializable]
	public sealed class BeautifyDoFFocusModeParameter : VolumeParameter<DoFFocusMode>
	{
	}

	[Serializable]
	public sealed class DoFTargetFallbackParameter : VolumeParameter<DoFTargetFallback>
	{
	}

	[Serializable]
	public sealed class BeautifyDoFFilterModeParameter : VolumeParameter<FilterMode>
	{
	}

	[Serializable]
	public sealed class BeautifyDoFBokehCompositionParameter : VolumeParameter<DoFBokehComposition>
	{
	}

	[Serializable]
	public sealed class BeautifyDoFCameraSettingsParameter : VolumeParameter<DoFCameraSettings>
	{
	}

	[Serializable]
	public sealed class BeautifyLayerMaskParameter : VolumeParameter<LayerMask>
	{
	}

	[Serializable]
	public sealed class BeautifyDebugOutputParameter : VolumeParameter<DebugOutput>
	{
		public BeautifyDebugOutputParameter(DebugOutput debugOutput = DebugOutput.Nothing, bool overrideState = false)
		{
		}
	}

	[Serializable]
	public sealed class BeautifyBlinkStyleParameter : VolumeParameter<BlinkStyle>
	{
	}

	[Serializable]
	public sealed class BeautifyVignetteFitMode : VolumeParameter<VignetteFitMode>
	{
	}

	[Serializable]
	public sealed class BeautifySunFlaresDepthOcclusionMode : VolumeParameter<SunFlaresDepthOcclusionMode>
	{
	}

	[Serializable]
	public sealed class MinMaxFloatParameter : VolumeParameter<Vector2>
	{
		public float min;

		public float max;

		public MinMaxFloatParameter(Vector2 value, float min, float max, bool overrideState = false)
		{
		}
	}

	[Serializable]
	public sealed class BeautifyOutlineStageParameter : VolumeParameter<OutlineStage>
	{
	}

	public enum FrameStyle
	{
		Border = 0,
		CinematicBands = 1
	}

	[Serializable]
	public sealed class BeautifyFrameStyleParameter : VolumeParameter<FrameStyle>
	{
	}

	[DisplayName("Disable Beautify Effects")]
	[GlobalOverride]
	[Tooltip("Ignore all Beautify effects. This option overrides any existing profile.")]
	[GeneralSettings]
	public BoolParameter disabled;

	[GeneralSettings]
	[DisplayName("Enable Compare Mode")]
	[ToggleAllFields]
	[GlobalOverride]
	public BoolParameter compareMode;

	[GeneralSettings]
	[DisplayName("Style")]
	[DisplayConditionBool("compareMode", true, null, true)]
	public BeautifyCompareStyleParameter compareStyle;

	[GeneralSettings]
	[DisplayName("Panning")]
	[DisplayConditionEnum("compareStyle", 0, false)]
	public ClampedFloatParameter comparePanning;

	[GeneralSettings]
	[DisplayName("Angle")]
	[DisplayConditionBool("compareMode", true, "compareSameSide", false)]
	public FloatParameter compareLineAngle;

	[GeneralSettings]
	[DisplayName("Line Width")]
	[DisplayConditionBool("compareMode", true, null, true)]
	public FloatParameter compareLineWidth;

	[GlobalOverride]
	[GeneralSettings]
	[Tooltip("Inverts vertical orientation of image when blitting. This option can be used to overcome an issue in certain versions of URP.")]
	[DisplayName("Flip Vertically")]
	public BoolParameter flipY;

	[GeneralSettings]
	[DisplayName("Hide In SceneView")]
	[GlobalOverride]
	public BoolParameter hideInSceneView;

	[DisplayConditionBool("compareMode", false, null, true)]
	[DisplayName("Debug Output")]
	[GlobalOverride]
	[GeneralSettings]
	public BeautifyDebugOutputParameter debugOutput;

	[Performance]
	[DisplayName("Prioritize Shader Performance")]
	[GlobalOverride]
	[Tooltip("Sharpen, bloom and anamorphic flares will reduce quality a bit to improve performance. This option can be useful on less powerful platforms or devices.")]
	[GeneralSettings]
	public BoolParameter turboMode;

	[GeneralSettings]
	[Performance]
	[DisplayName("Direct Write To Camera")]
	[GlobalOverride]
	[Tooltip("Writes result directly to camera target saving intermediate blits. This option will overwrite any previous post-processing effects so make sure there's no other effects being executed besides Beautify.")]
	public BoolParameter directWrite;

	[GeneralSettings]
	[Performance]
	[DisplayName("Downsampling")]
	[GlobalOverride]
	[Tooltip("Reduces camera target before applying Beautify effects This option can contribute to compensate render scale if it's set to greater than 1 or to improve performance.")]
	public BoolParameter downsampling;

	[GeneralSettings]
	[Performance]
	[DisplayName("Mode")]
	[GlobalOverride]
	[Tooltip("How downsampling is applied.")]
	[DisplayConditionBool("downsampling", true, null, true)]
	public BeautifyDownsamplingModeParameter downsamplingMode;

	[GeneralSettings]
	[DisplayName("Multiplier")]
	[GlobalOverride]
	[Tooltip("Downsampling multiplier.")]
	[DisplayConditionBool("downsampling", true, null, true)]
	[Performance]
	public ClampedFloatParameter downsamplingMultiplier;

	[GeneralSettings]
	[Performance]
	[DisplayName("Bilinear Filtering")]
	[GlobalOverride]
	[Tooltip("Enables bilinear filtering when using downsampling.")]
	[DisplayConditionBool("downsampling", true, null, true)]
	public BoolParameter downsamplingBilinear;

	[DisplayName("Automatically Strip Unused Features")]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile any shader features not active in the inspector, reducing build time.")]
	public BoolParameter optimizeBuildBeautifyAuto;

	[GeneralSettings]
	[BuildToggle]
	[GlobalOverride]
	[Tooltip("Do not compile tonemapping shader feature, reducing build time.")]
	[DisplayName("Strip Tonemapping")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[OptimizeBeautifyBuild]
	public BoolParameter stripBeautifyTonemapping;

	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Sharpen")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile sharpen shader feature, reducing build time.")]
	public BoolParameter stripBeautifySharpen;

	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Dithering")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile dithering shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	public BoolParameter stripBeautifyDithering;

	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Edge Antialiasing")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile edge antialiasing shader feature, reducing build time.")]
	public BoolParameter stripBeautifyEdgeAA;

	[BuildToggle]
	[Tooltip("Do not compile LUT shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[GlobalOverride]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	[DisplayName("Strip LUT")]
	public BoolParameter stripBeautifyLUT;

	[Tooltip("Do not compile LUT 3D shader feature, reducing build time.")]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[GlobalOverride]
	[DisplayName("Strip LUT 3D")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	public BoolParameter stripBeautifyLUT3D;

	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile White Balance shader feature, reducing build time.")]
	[BuildToggle]
	[DisplayName("Strip Sepia, Daltonize & White Balance")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	[GlobalOverride]
	public BoolParameter stripBeautifyColorTweaks;

	[BuildToggle]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Bloom, Anamorphic & Sun Flares")]
	[GlobalOverride]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile Bloom, Anamorphic & Sun Flares shader features, reducing build time.")]
	public BoolParameter stripBeautifyBloom;

	[Tooltip("Do not compile Lens Dirt shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[BuildToggle]
	[GlobalOverride]
	[DisplayName("Strip Lens Dirt")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	public BoolParameter stripBeautifyLensDirt;

	[GeneralSettings]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile Chromatic Aberration shader feature, reducing build time.")]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Chromatic Aberration")]
	public BoolParameter stripBeautifyChromaticAberration;

	[OptimizeBeautifyBuild]
	[DisplayName("Strip Depth of Field")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile Depth Of Field shader feature, reducing build time.")]
	[GeneralSettings]
	public BoolParameter stripBeautifyDoF;

	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Depth of Field Transparent Support")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile Depth Of Field transparency support shader feature, reducing build time.")]
	public BoolParameter stripBeautifyDoFTransparentSupport;

	[GlobalOverride]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Eye Adaptation")]
	[Tooltip("Do not compile Purkinje Shift shader feature, reducing build time.")]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	public BoolParameter stripBeautifyEyeAdaptation;

	[Tooltip("Do not compile Purkinje Shift shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[GlobalOverride]
	[DisplayName("Strip Purkinje Shift")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	[BuildToggle]
	public BoolParameter stripBeautifyPurkinje;

	[OptimizeBeautifyBuild]
	[DisplayName("Strip Vignetting")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile Vignetting shader features, reducing build time.")]
	[GeneralSettings]
	public BoolParameter stripBeautifyVignetting;

	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile Outline shader feature, reducing build time.")]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Outline")]
	[GlobalOverride]
	[BuildToggle]
	public BoolParameter stripBeautifyOutline;

	[OptimizeBeautifyBuild]
	[DisplayName("Strip Night Vision")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Night Vision shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[GeneralSettings]
	public BoolParameter stripBeautifyNightVision;

	[OptimizeBeautifyBuild]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[Tooltip("Do not compile Thermal Vision shader feature, reducing build time.")]
	[GeneralSettings]
	[DisplayName("Strip Thermal Vision")]
	public BoolParameter stripBeautifyThermalVision;

	[DisplayConditionBool("optimizeBuildBeautifyAuto", false, null, true)]
	[GeneralSettings]
	[DisplayName("Strip Frame")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Frame shader features, reducing build time.")]
	[OptimizeBeautifyBuild]
	public BoolParameter stripBeautifyFrame;

	[DisplayName("Strip All")]
	[GeneralSettings]
	[OptimizeUnityPostProcessingBuild]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Unity Post Processing shader features, reducing build time.")]
	public BoolParameter optimizeBuildUnityPPSAuto;

	[BuildToggle]
	[GeneralSettings]
	[OptimizeUnityPostProcessingBuild]
	[DisplayName("Strip Film Grain")]
	[GlobalOverride]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", false, null, true)]
	[Tooltip("Do not compile Unity Post Processing's Film Grain shader feature, reducing build time.")]
	public BoolParameter stripUnityFilmGrain;

	[Tooltip("Do not compile Unity Post Processing's Dithering shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", false, null, true)]
	[BuildToggle]
	[GlobalOverride]
	[OptimizeUnityPostProcessingBuild]
	[GeneralSettings]
	[DisplayName("Strip Dithering")]
	public BoolParameter stripUnityDithering;

	[Tooltip("Do not compile Unity Post Processing's Tonemapping shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", false, null, true)]
	[BuildToggle]
	[GlobalOverride]
	[OptimizeUnityPostProcessingBuild]
	[GeneralSettings]
	[DisplayName("Strip Tonemapping")]
	public BoolParameter stripUnityTonemapping;

	[DisplayConditionBool("optimizeBuildUnityPPSAuto", false, null, true)]
	[GeneralSettings]
	[OptimizeUnityPostProcessingBuild]
	[DisplayName("Strip Bloom")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Unity Post Processing's Bloom shader feature, reducing build time.")]
	public BoolParameter stripUnityBloom;

	[GeneralSettings]
	[DisplayName("Strip Chromatic Aberration")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", false, null, true)]
	[OptimizeUnityPostProcessingBuild]
	[Tooltip("Do not compile Unity Post Processing's Chromatic Aberration shader feature, reducing build time.")]
	public BoolParameter stripUnityChromaticAberration;

	[GeneralSettings]
	[DisplayName("Strip Distortion")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", false, null, true)]
	[Tooltip("Do not compile Unity Post Processing's Screen Distortion features, reducing build time.")]
	[OptimizeUnityPostProcessingBuild]
	public BoolParameter stripUnityDistortion;

	[GeneralSettings]
	[DisplayName("Strip Debug Variants")]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", false, null, true)]
	[Tooltip("Do not compile Unity Post Processing's debug variants, reducing build time.")]
	[GlobalOverride]
	[OptimizeUnityPostProcessingBuild]
	public BoolParameter stripUnityDebugVariants;

	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Intensity")]
	[DisplayConditionBool("stripBeautifySharpen", false, null, true)]
	[ShowStrippedLabel]
	public ClampedFloatParameter sharpenIntensity;

	[Tooltip("By default, sharpen ignores edges to avoid aliasing. Increase this property to also include edges. Edge detection is based on scene depth.")]
	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Depth Threshold")]
	[DisplayConditionBool("turboMode", false, null, true)]
	public ClampedFloatParameter sharpenDepthThreshold;

	[Sharpen]
	[DisplayName("Depth Range")]
	[DisplayConditionBool("turboMode", false, null, true)]
	[ImageEnhancement]
	[Tooltip("Restricts sharpen to a scene depth range.")]
	public MinMaxFloatParameter sharpenMinMaxDepth;

	[DisplayName("Depth Range FallOff")]
	[ImageEnhancement]
	[DisplayConditionBool("turboMode", false, null, true)]
	[Sharpen]
	public ClampedFloatParameter sharpenMinMaxDepthFallOff;

	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Relaxation")]
	[Tooltip("Reduces sharpen intensity based on area brightness.")]
	public ClampedFloatParameter sharpenRelaxation;

	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Clamp")]
	[Tooltip("Reduces final sharpen modifier.")]
	public ClampedFloatParameter sharpenClamp;

	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Motion Sensibility")]
	[Tooltip("Reduces sharpen gracefully when camera moves or rotates. This setting reduces flickering while contributes to a motion blur sense.")]
	public ClampedFloatParameter sharpenMotionSensibility;

	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Motion Restore Speed")]
	[Tooltip("The speed at which the sharpen intensity restores when camera stops moving.")]
	public ClampedFloatParameter sharpenMotionRestoreSpeed;

	[ImageEnhancement]
	[EdgeAntialiasing]
	[DisplayName("Strength")]
	[DisplayConditionBool("stripBeautifyEdgeAA", false, null, true)]
	[Tooltip("Strength of the integrated edge antialiasing. A value of 0 disables this feature.")]
	[ShowStrippedLabel]
	public ClampedFloatParameter antialiasStrength;

	[ImageEnhancement]
	[EdgeAntialiasing]
	[DisplayName("Edge Threshold")]
	[Tooltip("Minimum difference in depth between neighbour pixels to determine if edge antialiasing should be applied.")]
	public ClampedFloatParameter antialiasDepthThreshold;

	[EdgeAntialiasing]
	[ImageEnhancement]
	[DisplayName("Max Spread")]
	[Tooltip("The maximum extent of antialiasing.")]
	public ClampedFloatParameter antialiasSpread;

	[ImageEnhancement]
	[EdgeAntialiasing]
	[DisplayName("Depth Attenuation")]
	[Tooltip("Reduces antialias effect on the distance.")]
	public FloatParameter antialiasDepthAttenuation;

	[TonemappingAndColorGrading]
	[DisplayConditionBool("stripBeautifyTonemapping", false, null, true)]
	[ShowStrippedLabel]
	public BeautifyTonemapOperatorParameter tonemap;

	[TonemappingAndColorGrading]
	[Min(0f)]
	[DisplayName("Max Input Brightness")]
	[Tooltip("Clamps input image brightness to avoid artifacts due to NaN or out of range pixel values.")]
	[DisplayConditionEnum("tonemap", 1, true)]
	public FloatParameter tonemapMaxInputBrightness;

	[TonemappingAndColorGrading]
	[Min(0f)]
	[DisplayName("Pre Exposure")]
	[Tooltip("Brightness multiplier before applying tonemap operator.")]
	[DisplayConditionEnum("tonemap", 1, true)]
	public FloatParameter tonemapExposurePre;

	[TonemappingAndColorGrading]
	[Min(0f)]
	[DisplayName("Post Brightness")]
	[Tooltip("Brightness multiplier after applying tonemap operator.")]
	[DisplayConditionEnum("tonemap", 1, true)]
	public FloatParameter tonemapBrightnessPost;

	[TonemappingAndColorGrading]
	public ClampedFloatParameter saturate;

	[TonemappingAndColorGrading]
	public ClampedFloatParameter brightness;

	[TonemappingAndColorGrading]
	public ClampedFloatParameter contrast;

	[ShowStrippedLabel]
	[TonemappingAndColorGrading]
	[DisplayConditionBool("stripBeautifyColorTweaks", false, null, true)]
	public ClampedFloatParameter daltonize;

	[TonemappingAndColorGrading]
	[DisplayConditionBool("stripBeautifyColorTweaks", false, null, true)]
	[ShowStrippedLabel]
	public ClampedFloatParameter sepia;

	[TonemappingAndColorGrading]
	public ColorParameter tintColor;

	[TonemappingAndColorGrading]
	[WhiteBalance]
	[DisplayName("Temperature")]
	[DisplayConditionBool("stripBeautifyColorTweaks", false, null, true)]
	[ShowStrippedLabel]
	public ClampedFloatParameter colorTemp;

	[DisplayConditionBool("stripBeautifyColorTweaks", false, null, true)]
	[TonemappingAndColorGrading]
	[WhiteBalance]
	[DisplayName("Blend")]
	public ClampedFloatParameter colorTempBlend;

	[ToggleAllFields]
	[TonemappingAndColorGrading]
	[LUT]
	[DisplayName("Enable LUT")]
	[DisplayConditionBool("stripBeautifyLUT", false, null, true)]
	[ShowStrippedLabel]
	public BoolParameter lut;

	[TonemappingAndColorGrading]
	[LUT]
	[DisplayName("Intensity")]
	public ClampedFloatParameter lutIntensity;

	[TonemappingAndColorGrading]
	[LUT]
	[DisplayName("LUT Texture")]
	public TextureParameter lutTexture;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Intensity")]
	[ShowStrippedLabel]
	[DisplayConditionBool("stripBeautifyBloom", false, null, true)]
	public FloatParameter bloomIntensity;

	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Threshold")]
	public FloatParameter bloomThreshold;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Conservative Threshold")]
	[Tooltip("A convervative threshold keeps the ratio of the rgb values after applying the thresholding")]
	public BoolParameter bloomConservativeThreshold;

	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Spread")]
	public ClampedFloatParameter bloomSpread;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Max Brightness")]
	public FloatParameter bloomMaxBrightness;

	[Bloom]
	[Tooltip("Use Alpha channel to blend original bloom color with the tinted color.")]
	[DisplayName("Tint Color")]
	[LensAndLightingEffects]
	public ColorParameter bloomTint;

	[DisplayName("Depth Attenuation")]
	[Bloom]
	[LensAndLightingEffects]
	public FloatParameter bloomDepthAtten;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Near Attenuation")]
	[Min(0f)]
	public FloatParameter bloomNearAtten;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Exclude Layers")]
	public BoolParameter bloomExcludeLayers;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Exclusion Layer Mask")]
	[DisplayConditionBool("bloomExcludeLayers", true, null, true)]
	public BeautifyLayerMaskParameter bloomExclusionLayerMask;

	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Antiflicker")]
	public BoolParameter bloomAntiflicker;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Resolution")]
	public ClampedIntParameter bloomResolution;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Quicker Blur")]
	public BoolParameter bloomQuickerBlur;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Customize")]
	[ToggleAllFields]
	public BoolParameter bloomCustomize;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 1 Weight")]
	public ClampedFloatParameter bloomWeight0;

	[DisplayName("Layer 1 Boost")]
	[Bloom]
	[LensAndLightingEffects]
	public ClampedFloatParameter bloomBoost0;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 1 Tint Color")]
	public ColorParameter bloomTint0;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 2 Weight")]
	public ClampedFloatParameter bloomWeight1;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 2 Boost")]
	public ClampedFloatParameter bloomBoost1;

	[LensAndLightingEffects]
	[DisplayName("Layer 2 Tint Color")]
	[Bloom]
	public ColorParameter bloomTint1;

	[LensAndLightingEffects]
	[DisplayName("Layer 3 Weight")]
	[Bloom]
	public ClampedFloatParameter bloomWeight2;

	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Layer 3 Boost")]
	public ClampedFloatParameter bloomBoost2;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 3 Tint Color")]
	public ColorParameter bloomTint2;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 4 Weight")]
	public ClampedFloatParameter bloomWeight3;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 4 Boost")]
	public ClampedFloatParameter bloomBoost3;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 4 Tint Color")]
	public ColorParameter bloomTint3;

	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Layer 5 Weight")]
	public ClampedFloatParameter bloomWeight4;

	[Bloom]
	[DisplayName("Layer 5 Boost")]
	[LensAndLightingEffects]
	public ClampedFloatParameter bloomBoost4;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 5 Tint Color")]
	public ColorParameter bloomTint4;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 6 Weight")]
	public ClampedFloatParameter bloomWeight5;

	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 6 Boost")]
	public ClampedFloatParameter bloomBoost5;

	[DisplayName("Layer 6 Tint Color")]
	[LensAndLightingEffects]
	[Bloom]
	public ColorParameter bloomTint5;

	[DisplayName("Intensity")]
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayConditionBool("stripBeautifyBloom", false, null, true)]
	[ShowStrippedLabel]
	public FloatParameter anamorphicFlaresIntensity;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Threshold")]
	public FloatParameter anamorphicFlaresThreshold;

	[AnamorphicFlares]
	[LensAndLightingEffects]
	[DisplayName("Conservative Threshold")]
	[Tooltip("A convervative threshold keeps the ratio of the rgb values after applying the thresholding")]
	public BoolParameter anamorphicFlaresConservativeThreshold;

	[Tooltip("Ignore all Beautify effects. This option overrides any existing profile.")]
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Tint Color")]
	public ColorParameter anamorphicFlaresTint;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Vertical")]
	public BoolParameter anamorphicFlaresVertical;

	[AnamorphicFlares]
	[DisplayName("Spread")]
	[LensAndLightingEffects]
	public ClampedFloatParameter anamorphicFlaresSpread;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Max Brightness")]
	public FloatParameter anamorphicFlaresMaxBrightness;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Depth Attenuation")]
	public FloatParameter anamorphicFlaresDepthAtten;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Near Attenuation")]
	[Min(0f)]
	public FloatParameter anamorphicFlaresNearAtten;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Exclude Layers")]
	public BoolParameter anamorphicFlaresExcludeLayers;

	[AnamorphicFlares]
	[DisplayName("Exclusion Layer Mask")]
	[DisplayConditionBool("anamorphicFlaresExcludeLayers", true, null, true)]
	[LensAndLightingEffects]
	public BeautifyLayerMaskParameter anamorphicFlaresExclusionLayerMask;

	[LensAndLightingEffects]
	[DisplayName("Antiflicker")]
	[AnamorphicFlares]
	public BoolParameter anamorphicFlaresAntiflicker;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Resolution")]
	public ClampedIntParameter anamorphicFlaresResolution;

	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Quicker Blur")]
	public BoolParameter anamorphicFlaresQuickerBlur;

	[LensAndLightingEffects]
	[DisplayName("Global Intensity")]
	[ShowStrippedLabel]
	[DisplayConditionBool("stripBeautifyBloom", false, null, true)]
	[SunFlares]
	public ClampedFloatParameter sunFlaresIntensity;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Tint Color")]
	public ColorParameter sunFlaresTint;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Solar Wind Speed")]
	public ClampedFloatParameter sunFlaresSolarWindSpeed;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Rotation Dead Zone")]
	public BoolParameter sunFlaresRotationDeadZone;

	[DisplayName("Downsampling")]
	[LensAndLightingEffects]
	[SunFlares]
	public ClampedIntParameter sunFlaresDownsampling;

	[DisplayName("Depth Occlusion Mode")]
	[SunFlares]
	[Tooltip("None = no depth buffer checking. Simple = sample depth buffer at Sun position. Smooth = sample 4 positions around Sun position and interpolate value across frames.")]
	[LensAndLightingEffects]
	public BeautifySunFlaresDepthOcclusionMode sunFlaresDepthOcclusionMode;

	[SunFlares]
	[DisplayName("Occlusion Threshold")]
	[DisplayConditionEnum("sunFlaresDepthOcclusionMode", 2, true)]
	[LensAndLightingEffects]
	public ClampedFloatParameter sunFlaresDepthOcclusionThreshold;

	[LensAndLightingEffects]
	[DisplayName("Use Layer Mask")]
	[Tooltip("Specifies if occluding objects will be detected by raycasting.")]
	[SunFlares]
	public BoolParameter sunFlaresUseLayerMask;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Occluding Layer Mask")]
	[DisplayConditionBool("sunFlaresUseLayerMask", true, null, true)]
	public BeautifyLayerMaskParameter sunFlaresLayerMask;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayConditionBool("sunFlaresUseLayerMask", true, null, true)]
	[DisplayName("Occlusion Speed")]
	[DisplayConditionEnum("sunFlaresDepthOcclusionMode", 2, true)]
	public FloatParameter sunFlaresAttenSpeed;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Intensity")]
	[Header("Sun")]
	public ClampedFloatParameter sunFlaresSunIntensity;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Disk Size")]
	public ClampedFloatParameter sunFlaresSunDiskSize;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Diffraction Intensity")]
	public ClampedFloatParameter sunFlaresSunRayDiffractionIntensity;

	[DisplayName("Diffraction Threshold")]
	[LensAndLightingEffects]
	[SunFlares]
	public ClampedFloatParameter sunFlaresSunRayDiffractionThreshold;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Length")]
	[Header("Corona Rays Group 1")]
	public ClampedFloatParameter sunFlaresCoronaRays1Length;

	[SunFlares]
	[DisplayName("Streaks")]
	[LensAndLightingEffects]
	public ClampedIntParameter sunFlaresCoronaRays1Streaks;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Spread")]
	public ClampedFloatParameter sunFlaresCoronaRays1Spread;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Angle Offset")]
	public ClampedFloatParameter sunFlaresCoronaRays1AngleOffset;

	[Header("Corona Rays Group 2")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Length")]
	public ClampedFloatParameter sunFlaresCoronaRays2Length;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Streaks")]
	public ClampedIntParameter sunFlaresCoronaRays2Streaks;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Spread")]
	public ClampedFloatParameter sunFlaresCoronaRays2Spread;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Angle Offset")]
	public ClampedFloatParameter sunFlaresCoronaRays2AngleOffset;

	[Header("Ghost 1")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	public ClampedFloatParameter sunFlaresGhosts1Size;

	[SunFlares]
	[DisplayName("Offset")]
	[LensAndLightingEffects]
	public ClampedFloatParameter sunFlaresGhosts1Offset;

	[DisplayName("Brightness")]
	[SunFlares]
	[LensAndLightingEffects]
	public ClampedFloatParameter sunFlaresGhosts1Brightness;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	[Header("Ghost 2")]
	public ClampedFloatParameter sunFlaresGhosts2Size;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Offset")]
	public ClampedFloatParameter sunFlaresGhosts2Offset;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Brightness")]
	public ClampedFloatParameter sunFlaresGhosts2Brightness;

	[Header("Ghost 3")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	public ClampedFloatParameter sunFlaresGhosts3Size;

	[LensAndLightingEffects]
	[DisplayName("Offset")]
	[SunFlares]
	public ClampedFloatParameter sunFlaresGhosts3Offset;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Brightness")]
	public ClampedFloatParameter sunFlaresGhosts3Brightness;

	[Header("Ghost 4")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	public ClampedFloatParameter sunFlaresGhosts4Size;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Offset")]
	public ClampedFloatParameter sunFlaresGhosts4Offset;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Brightness")]
	public ClampedFloatParameter sunFlaresGhosts4Brightness;

	[SunFlares]
	[Header("Halo")]
	[LensAndLightingEffects]
	[DisplayName("Offset")]
	public ClampedFloatParameter sunFlaresHaloOffset;

	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Amplitude")]
	public ClampedFloatParameter sunFlaresHaloAmplitude;

	[SunFlares]
	[LensAndLightingEffects]
	[DisplayName("Intensity")]
	public ClampedFloatParameter sunFlaresHaloIntensity;

	[DisplayConditionBool("stripBeautifyLensDirt", false, null, true)]
	[Min(0f)]
	[DisplayName("Intensity")]
	[ShowStrippedLabel]
	[LensAndLightingEffects]
	[LensDirt]
	public FloatParameter lensDirtIntensity;

	[LensDirt]
	[DisplayName("Threshold")]
	[LensAndLightingEffects]
	public ClampedFloatParameter lensDirtThreshold;

	[LensAndLightingEffects]
	[LensDirt]
	[DisplayName("Dirt Texture")]
	public TextureParameter lensDirtTexture;

	[LensAndLightingEffects]
	[LensDirt]
	[DisplayName("Spread")]
	public ClampedIntParameter lensDirtSpread;

	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayName("Intensity")]
	[Min(0f)]
	[DisplayConditionBool("stripBeautifyChromaticAberration", false, null, true)]
	[ShowStrippedLabel]
	public FloatParameter chromaticAberrationIntensity;

	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayConditionBool("turboMode", false, null, true)]
	[DisplayName("Hue Shift")]
	[Min(0f)]
	public ClampedFloatParameter chromaticAberrationShift;

	[DisplayConditionBool("turboMode", false, null, true)]
	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayName("Smoothing")]
	public FloatParameter chromaticAberrationSmoothing;

	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayName("Separate Pass")]
	public BoolParameter chromaticAberrationSeparatePass;

	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Enable")]
	[ToggleAllFields]
	[DisplayConditionBool("stripBeautifyDoF", false, null, true)]
	[ShowStrippedLabel]
	public BoolParameter depthOfField;

	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Focus Mode")]
	[Header("Focus")]
	public BeautifyDoFFocusModeParameter depthOfFieldFocusMode;

	[DisplayName("Min Distance")]
	[DepthOfField]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, false)]
	[LensAndLightingEffects]
	public FloatParameter depthOfFieldAutofocusMinDistance;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Max Distance")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, false)]
	public FloatParameter depthOfFieldAutofocusMaxDistance;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Fallback")]
	[Tooltip("Focus behaviour if object is not visible on the screen")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 2, true)]
	public DoFTargetFallbackParameter depthOfFieldTargetFallback;

	[DisplayName("Distance")]
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayConditionEnum("depthOfFieldTargetFallback", 2, true)]
	public FloatParameter depthOfFieldTargetFallbackFixedDistance;

	[LensAndLightingEffects]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, true)]
	[DisplayName("Viewport Point")]
	[DepthOfField]
	public Vector2Parameter depthOfFieldAutofocusViewportPoint;

	[Tooltip("Custom distance adjustment (positive or negative)")]
	[DisplayName("Distance Shift")]
	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, true)]
	public FloatParameter depthOfFieldAutofocusDistanceShift;

	[DepthOfField]
	[DisplayName("Layer Mask")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, true)]
	[LensAndLightingEffects]
	public BeautifyLayerMaskParameter depthOfFieldAutofocusLayerMask;

	[DisplayName("Distance")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 0, true)]
	[Min(0f)]
	[DepthOfField]
	[LensAndLightingEffects]
	public FloatParameter depthOfFieldDistance;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Camera Lens Settings")]
	public BeautifyDoFCameraSettingsParameter depthOfFieldCameraSettings;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Focal Length")]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 0, true)]
	public ClampedFloatParameter depthOfFieldFocalLength;

	[DepthOfField]
	[DisplayName("Aperture")]
	[Min(0f)]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 0, true)]
	[LensAndLightingEffects]
	public FloatParameter depthOfFieldAperture;

	[DisplayName("Focal Length")]
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 1, true)]
	[Tooltip("The distance between the lens center and the camera's sensor in mm.")]
	public ClampedFloatParameter depthOfFieldFocalLengthReal;

	[Tooltip("The F-stop or F-number is the relation between the focal length and the diameter of the aperture")]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 1, true)]
	[DisplayName("F-Stop")]
	[DepthOfField]
	[LensAndLightingEffects]
	public ClampedFloatParameter depthOfFieldFStop;

	[DepthOfField]
	[DisplayName("Image Sensor Height")]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 1, true)]
	[Tooltip("Represents the height of the virtual image sensor. By default, it uses a 24mm image sensor of a classic full-frame camera")]
	[LensAndLightingEffects]
	public ClampedFloatParameter depthOfFieldImageSensorHeight;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Focus Speed")]
	public ClampedFloatParameter depthOfFieldFocusSpeed;

	[DisplayConditionBool("stripBeautifyDoFTransparentSupport", false, null, true)]
	[DepthOfField]
	[Header("Extra Features")]
	[ShowStrippedLabel]
	[LensAndLightingEffects]
	[DisplayName("Transparency Support")]
	public BoolParameter depthOfFieldTransparentSupport;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Layer Mask")]
	[DisplayConditionBool("depthOfFieldTransparentSupport", true, null, true)]
	public BeautifyLayerMaskParameter depthOfFieldTransparentLayerMask;

	[LensAndLightingEffects]
	[DisplayConditionBool("depthOfFieldTransparentSupport", true, null, true)]
	[Tooltip("When enabled, transparent geometry is rendered with cull off.")]
	[DisplayName("Double Sided")]
	[DepthOfField]
	public BoolParameter depthOfFieldTransparentDoubleSided;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Transparency Alpha Test Support")]
	[DisplayConditionBool("stripBeautifyDoFTransparentSupport", false, null, true)]
	[ShowStrippedLabel]
	[Tooltip("When enabled, transparent materials using alpha clipping will be included in the transparent mask")]
	public BoolParameter depthOfFieldAlphaTestSupport;

	[DisplayName("Layer Mask")]
	[DepthOfField]
	[DisplayConditionBool("depthOfFieldAlphaTestSupport", true, null, true)]
	[LensAndLightingEffects]
	public BeautifyLayerMaskParameter depthOfFieldAlphaTestLayerMask;

	[Tooltip("When enabled, transparent geometry is rendered with cull off.")]
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Double Sided")]
	[DisplayConditionBool("depthOfFieldAlphaTestSupport", true, null, true)]
	public BoolParameter depthOfFieldAlphaTestDoubleSided;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Foreground Blur")]
	public BoolParameter depthOfFieldForegroundBlur;

	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Blur HQ")]
	[DisplayConditionBool("depthOfFieldForegroundBlur", true, null, true)]
	public BoolParameter depthOfFieldForegroundBlurHQ;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Blur Spread")]
	[DisplayConditionBool("depthOfFieldForegroundBlurHQ", true, null, true)]
	public ClampedFloatParameter depthOfFieldForegroundBlurHQSpread;

	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Distance")]
	[DisplayConditionBool("depthOfFieldForegroundBlur", true, null, true)]
	public FloatParameter depthOfFieldForegroundDistance;

	[DisplayName("Bokeh Effect")]
	[DepthOfField]
	[LensAndLightingEffects]
	public BoolParameter depthOfFieldBokeh;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Composition")]
	[DisplayConditionBool("depthOfFieldBokeh", true, null, true)]
	[Tooltip("Specifies if the pass to compute bokeh is integrated (faster) or separated (stronger)")]
	public BeautifyDoFBokehCompositionParameter depthOfFieldBokehComposition;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Threshold")]
	[DisplayConditionBool("depthOfFieldBokeh", true, null, true)]
	public ClampedFloatParameter depthOfFieldBokehThreshold;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Intensity")]
	[DisplayConditionBool("depthOfFieldBokeh", true, null, true)]
	public ClampedFloatParameter depthOfFieldBokehIntensity;

	[Header("Quality")]
	[DepthOfField]
	[DisplayName("Downsampling")]
	[LensAndLightingEffects]
	public ClampedIntParameter depthOfFieldDownsampling;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Sample Count")]
	public ClampedIntParameter depthOfFieldMaxSamples;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Max Brightness")]
	public FloatParameter depthOfFieldMaxBrightness;

	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Max Depth")]
	public ClampedFloatParameter depthOfFieldMaxDistance;

	[DepthOfField]
	[DisplayName("Filter Mode")]
	[LensAndLightingEffects]
	public BeautifyDoFFilterModeParameter depthOfFieldFilterMode;

	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Enable")]
	[ToggleAllFields]
	[DisplayConditionBool("stripBeautifyEyeAdaptation", false, null, true)]
	[ShowStrippedLabel]
	public BoolParameter eyeAdaptation;

	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Min Exposure")]
	public ClampedFloatParameter eyeAdaptationMinExposure;

	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Max Exposure")]
	public ClampedFloatParameter eyeAdaptationMaxExposure;

	[DisplayName("Light Adapt Speed")]
	[EyeAdaptation]
	[LensAndLightingEffects]
	public ClampedFloatParameter eyeAdaptationSpeedToLight;

	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Dark Adapt Speed")]
	public ClampedFloatParameter eyeAdaptationSpeedToDark;

	[DisplayName("Enable")]
	[DisplayConditionBool("stripBeautifyPurkinje", false, null, true)]
	[LensAndLightingEffects]
	[ShowStrippedLabel]
	[PurkinjeShift]
	[ToggleAllFields]
	public BoolParameter purkinje;

	[LensAndLightingEffects]
	[PurkinjeShift]
	[DisplayName("Shift Amount")]
	public ClampedFloatParameter purkinjeAmount;

	[DisplayName("Threshold")]
	[LensAndLightingEffects]
	[PurkinjeShift]
	public ClampedFloatParameter purkinjeLuminanceThreshold;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Outer Ring")]
	[DisplayConditionBool("stripBeautifyVignetting", false, null, true)]
	[ShowStrippedLabel]
	public ClampedFloatParameter vignettingOuterRing;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Inner Ring")]
	public ClampedFloatParameter vignettingInnerRing;

	[DisplayName("Fade")]
	[ArtisticChoices]
	[Vignette]
	public ClampedFloatParameter vignettingFade;

	[Vignette]
	[DisplayName("Circular Shape")]
	[ArtisticChoices]
	public BoolParameter vignettingCircularShape;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Fit Mode")]
	[DisplayConditionBool("vignettingCircularShape", true, null, true)]
	public BeautifyVignetteFitMode vignettingCircularShapeFitMode;

	[DisplayConditionBool("vignettingCircularShape", false, null, true)]
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Aspect Ratio")]
	public ClampedFloatParameter vignettingAspectRatio;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Blink")]
	public ClampedFloatParameter vignettingBlink;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Blink Style")]
	public BeautifyBlinkStyleParameter vignettingBlinkStyle;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Center")]
	public Vector2Parameter vignettingCenter;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Tint Color")]
	public ColorParameter vignettingColor;

	[ArtisticChoices]
	[Vignette]
	[DisplayName("Texture Mask")]
	public TextureParameter vignettingMask;

	[ArtisticChoices]
	[Outline]
	[DisplayConditionBool("stripBeautifyOutline", false, null, true)]
	[ShowStrippedLabel]
	public BoolParameter outline;

	[ArtisticChoices]
	[DisplayName("Color")]
	[Outline]
	public ColorParameter outlineColor;

	[DisplayName("Threshold")]
	[ArtisticChoices]
	[Outline]
	public ClampedFloatParameter outlineThreshold;

	[ArtisticChoices]
	[Outline]
	[DisplayName("Customize")]
	public BoolParameter outlineCustomize;

	[DisplayName("Render Stage")]
	[ArtisticChoices]
	[Outline]
	[DisplayConditionBool("outlineCustomize", true, null, true)]
	public BeautifyOutlineStageParameter outlineStageParameter;

	[Outline]
	[DisplayName("Spread")]
	[DisplayConditionBool("outlineCustomize", true, null, true)]
	[ArtisticChoices]
	public ClampedFloatParameter outlineSpread;

	[DisplayConditionBool("outlineCustomize", true, null, true)]
	[DisplayName("Blur Count")]
	[Outline]
	[ArtisticChoices]
	public ClampedIntParameter outlineBlurPassCount;

	[Outline]
	[ArtisticChoices]
	[DisplayName("Downscale Blur")]
	[DisplayConditionBool("outlineCustomize", true, null, true)]
	public BoolParameter outlineBlurDownscale;

	[ArtisticChoices]
	[Outline]
	[DisplayName("Intensity Multiplier")]
	[DisplayConditionBool("outlineCustomize", true, null, true)]
	public ClampedFloatParameter outlineIntensityMultiplier;

	[Tooltip("Maximum distance in meters from the camera")]
	[ArtisticChoices]
	[Outline]
	[DisplayConditionBool("outlineCustomize", true, null, true)]
	[DisplayName("Distance Fade")]
	public FloatParameter outlineDistanceFade;

	[NightVision]
	[ArtisticChoices]
	[DisplayName("Enable")]
	[DisplayConditionBool("stripBeautifyNightVision", false, null, true)]
	[ShowStrippedLabel]
	public BoolParameter nightVision;

	[DisplayConditionBool("stripBeautifyNightVision", false, null, true)]
	[ArtisticChoices]
	[NightVision]
	[DisplayName("Scan Lines Color")]
	public ColorParameter nightVisionColor;

	[ArtisticChoices]
	[NightVision]
	[DisplayName("Max Visible Depth")]
	[DisplayConditionBool("stripBeautifyNightVision", false, null, true)]
	public FloatParameter nightVisionDepth;

	[DisplayName("Max Visible Depth Fall Off")]
	[NightVision]
	[DisplayConditionBool("stripBeautifyNightVision", false, null, true)]
	[ArtisticChoices]
	public ClampedFloatParameter nightVisionDepthFallOff;

	[ShowStrippedLabel]
	[DisplayConditionBool("stripBeautifyThermalVision", false, null, true)]
	[ThermalVision]
	[ArtisticChoices]
	[DisplayName("Enable")]
	public BoolParameter thermalVision;

	[ArtisticChoices]
	[ThermalVision]
	[DisplayName("Scan Lines")]
	[DisplayConditionBool("stripBeautifyThermalVision", false, null, true)]
	public BoolParameter thermalVisionScanLines;

	[ArtisticChoices]
	[ThermalVision]
	[DisplayName("Distortion Amount")]
	[DisplayConditionBool("stripBeautifyThermalVision", false, null, true)]
	public ClampedFloatParameter thermalVisionDistortionAmount;

	[DisplayName("Intensity")]
	[ImageEnhancement]
	[Dither]
	[DisplayConditionBool("stripBeautifyDithering", false, null, true)]
	[ShowStrippedLabel]
	public ClampedFloatParameter ditherIntensity;

	[ArtisticChoices]
	[Frame]
	[DisplayName("Enable")]
	[DisplayConditionBool("stripBeautifyFrame", false, null, true)]
	public BoolParameter frame;

	[ArtisticChoices]
	[Frame]
	[DisplayName("Style")]
	public BeautifyFrameStyleParameter frameStyle;

	[DisplayName("Horizontal Bands Size")]
	[ArtisticChoices]
	[Frame]
	[DisplayConditionEnum("frameStyle", 1, true)]
	public ClampedFloatParameter frameBandHorizontalSize;

	[DisplayName("Horizontal Bands Smoothness")]
	[Frame]
	[DisplayConditionEnum("frameStyle", 1, true)]
	[ArtisticChoices]
	public ClampedFloatParameter frameBandHorizontalSmoothness;

	[DisplayName("Vertical Bands Size")]
	[DisplayConditionEnum("frameStyle", 1, true)]
	[ArtisticChoices]
	[Frame]
	public ClampedFloatParameter frameBandVerticalSize;

	[DisplayName("Vertical Bands Smoothness")]
	[DisplayConditionEnum("frameStyle", 1, true)]
	[Frame]
	[ArtisticChoices]
	public ClampedFloatParameter frameBandVerticalSmoothness;

	[DisplayConditionEnum("frameStyle", 0, true)]
	[DisplayName("Color")]
	[Frame]
	[ArtisticChoices]
	public ColorParameter frameColor;

	[Frame]
	[DisplayName("Texture Mask")]
	[ArtisticChoices]
	public TextureParameter frameMask;

	[DisplayName("Intensity")]
	[ArtisticChoices]
	[FinalBlur]
	public ClampedFloatParameter blurIntensity;

	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Mask")]
	public TextureParameter blurMask;

	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Keep Source On Top")]
	public BoolParameter blurKeepSourceOnTop;

	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Rect")]
	[DisplayConditionBool("blurKeepSourceOnTop", true, null, true)]
	public Vector4Parameter blurSourceRect;

	[DisplayName("Edge Blending Width")]
	[ArtisticChoices]
	[FinalBlur]
	[DisplayConditionBool("blurKeepSourceOnTop", true, null, true)]
	public ClampedFloatParameter blurSourceEdgeBlendWidth;

	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Edge Blending Strength")]
	[DisplayConditionBool("blurKeepSourceOnTop", true, null, true)]
	public FloatParameter blurSourceEdgeBlendStrength;

	private int downsamplingUsed;

	public bool IsActive()
	{
		return false;
	}

	public bool IsTileCompatible()
	{
		return false;
	}

	public bool RequiresDepthTexture()
	{
		return false;
	}

	private void OnValidate()
	{
	}
}
