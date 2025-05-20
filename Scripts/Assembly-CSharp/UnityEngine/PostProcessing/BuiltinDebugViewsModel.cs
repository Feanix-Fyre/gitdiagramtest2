using System;

namespace UnityEngine.PostProcessing;

[Serializable]
public class BuiltinDebugViewsModel : PostProcessingModel
{
	[Serializable]
	public struct DepthSettings
	{
		[Tooltip("Scales the camera far plane before displaying the depth map.")]
		[Range(0f, 1f)]
		public float scale;

		public static DepthSettings defaultSettings => default(DepthSettings);
	}

	[Serializable]
	public struct MotionVectorsSettings
	{
		[Range(0f, 1f)]
		[Tooltip("Opacity of the source render.")]
		public float sourceOpacity;

		[Tooltip("Opacity of the per-pixel motion vector colors.")]
		[Range(0f, 1f)]
		public float motionImageOpacity;

		[Min(0f)]
		[Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
		public float motionImageAmplitude;

		[Range(0f, 1f)]
		[Tooltip("Opacity for the motion vector arrows.")]
		public float motionVectorsOpacity;

		[Range(8f, 64f)]
		[Tooltip("The arrow density on screen.")]
		public int motionVectorsResolution;

		[Tooltip("Tweaks the arrows length.")]
		[Min(0f)]
		public float motionVectorsAmplitude;

		public static MotionVectorsSettings defaultSettings => default(MotionVectorsSettings);
	}

	public enum Mode
	{
		None = 0,
		Depth = 1,
		Normals = 2,
		MotionVectors = 3,
		AmbientOcclusion = 4,
		EyeAdaptation = 5,
		FocusPlane = 6,
		PreGradingLog = 7,
		LogLut = 8,
		UserLut = 9
	}

	[Serializable]
	public struct Settings
	{
		public Mode mode;

		public DepthSettings depth;

		public MotionVectorsSettings motionVectors;

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

	public bool willInterrupt => false;

	public override void Reset()
	{
	}

	public bool IsModeActive(Mode mode)
	{
		return false;
	}
}
