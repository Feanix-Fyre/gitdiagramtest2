using System;

namespace UnityEngine.PostProcessing;

[Serializable]
public class EyeAdaptationModel : PostProcessingModel
{
	public enum EyeAdaptationType
	{
		Progressive = 0,
		Fixed = 1
	}

	[Serializable]
	public struct Settings
	{
		[Tooltip("Filters the dark part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
		[Range(1f, 99f)]
		public float lowPercent;

		[Tooltip("Filters the bright part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
		[Range(1f, 99f)]
		public float highPercent;

		[Tooltip("Minimum average luminance to consider for auto exposure (in EV).")]
		public float minLuminance;

		[Tooltip("Maximum average luminance to consider for auto exposure (in EV).")]
		public float maxLuminance;

		[Min(0f)]
		[Tooltip("Exposure bias. Use this to offset the global exposure of the scene.")]
		public float keyValue;

		[Tooltip("Set this to true to let Unity handle the key value automatically based on average luminance.")]
		public bool dynamicKeyValue;

		[Tooltip("Use \"Progressive\" if you want the auto exposure to be animated. Use \"Fixed\" otherwise.")]
		public EyeAdaptationType adaptationType;

		[Tooltip("Adaptation speed from a dark to a light environment.")]
		[Min(0f)]
		public float speedUp;

		[Min(0f)]
		[Tooltip("Adaptation speed from a light to a dark environment.")]
		public float speedDown;

		[Tooltip("Lower bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
		[Range(-16f, -1f)]
		public int logMin;

		[Range(1f, 16f)]
		[Tooltip("Upper bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
		public int logMax;

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
