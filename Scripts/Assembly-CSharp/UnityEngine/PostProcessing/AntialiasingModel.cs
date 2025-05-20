using System;

namespace UnityEngine.PostProcessing;

[Serializable]
public class AntialiasingModel : PostProcessingModel
{
	public enum Method
	{
		Fxaa = 0,
		Taa = 1
	}

	public enum FxaaPreset
	{
		ExtremePerformance = 0,
		Performance = 1,
		Default = 2,
		Quality = 3,
		ExtremeQuality = 4
	}

	[Serializable]
	public struct FxaaQualitySettings
	{
		[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
		[Range(0f, 1f)]
		public float subpixelAliasingRemovalAmount;

		[Range(0.063f, 0.333f)]
		[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
		public float edgeDetectionThreshold;

		[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
		[Range(0f, 0.0833f)]
		public float minimumRequiredLuminance;

		public static FxaaQualitySettings[] presets;
	}

	[Serializable]
	public struct FxaaConsoleSettings
	{
		[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
		[Range(0.33f, 0.5f)]
		public float subpixelSpreadAmount;

		[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
		[Range(2f, 8f)]
		public float edgeSharpnessAmount;

		[Range(0.125f, 0.25f)]
		[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
		public float edgeDetectionThreshold;

		[Range(0.04f, 0.06f)]
		[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
		public float minimumRequiredLuminance;

		public static FxaaConsoleSettings[] presets;
	}

	[Serializable]
	public struct FxaaSettings
	{
		public FxaaPreset preset;

		public static FxaaSettings defaultSettings => default(FxaaSettings);
	}

	[Serializable]
	public struct TaaSettings
	{
		[Range(0.1f, 1f)]
		[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
		public float jitterSpread;

		[Range(0f, 3f)]
		[Tooltip("Controls the amount of sharpening applied to the color buffer.")]
		public float sharpen;

		[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
		[Range(0f, 0.99f)]
		public float stationaryBlending;

		[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
		[Range(0f, 0.99f)]
		public float motionBlending;

		public static TaaSettings defaultSettings => default(TaaSettings);
	}

	[Serializable]
	public struct Settings
	{
		public Method method;

		public FxaaSettings fxaaSettings;

		public TaaSettings taaSettings;

		public static Settings defaultSettings => default(Settings);
	}

	[SerializeField]
	private Settings m_Settings;

	public Settings settings
	{
		get
		{
			return default(Settings);
		}
		set
		{
		}
	}

	public override void Reset()
	{
	}
}
