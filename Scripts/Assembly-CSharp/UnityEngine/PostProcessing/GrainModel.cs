using System;

namespace UnityEngine.PostProcessing;

[Serializable]
public class GrainModel : PostProcessingModel
{
	[Serializable]
	public struct Settings
	{
		[Tooltip("Enable the use of colored grain.")]
		public bool colored;

		[Tooltip("Grain strength. Higher means more visible grain.")]
		[Range(0f, 1f)]
		public float intensity;

		[Tooltip("Grain particle size.")]
		[Range(0.3f, 3f)]
		public float size;

		[Range(0f, 1f)]
		[Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
		public float luminanceContribution;

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
