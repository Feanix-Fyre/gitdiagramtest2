using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline;

[Serializable]
public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
{
	private enum Versions
	{
		Initial = 0,
		ClipInFromGlobalToLocal = 1
	}

	private static class TimelineClipUpgrade
	{
		public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
		{
		}
	}

	public enum ClipExtrapolation
	{
		None = 0,
		Hold = 1,
		Loop = 2,
		PingPong = 3,
		Continue = 4
	}

	public enum BlendCurveMode
	{
		Auto = 0,
		Manual = 1
	}

	private const int k_LatestVersion = 1;

	[HideInInspector]
	[SerializeField]
	private int m_Version;

	public static readonly ClipCaps kDefaultClipCaps;

	public static readonly float kDefaultClipDurationInSeconds;

	public static readonly double kTimeScaleMin;

	public static readonly double kTimeScaleMax;

	internal static readonly string kDefaultCurvesName;

	internal static readonly double kMinDuration;

	internal static readonly double kMaxTimeValue;

	[SerializeField]
	private double m_Start;

	[SerializeField]
	private double m_ClipIn;

	[SerializeField]
	private Object m_Asset;

	[FormerlySerializedAs("m_HackDuration")]
	[SerializeField]
	private double m_Duration;

	[SerializeField]
	private double m_TimeScale;

	[SerializeField]
	private TrackAsset m_ParentTrack;

	[SerializeField]
	private double m_EaseInDuration;

	[SerializeField]
	private double m_EaseOutDuration;

	[SerializeField]
	private double m_BlendInDuration;

	[SerializeField]
	private double m_BlendOutDuration;

	[SerializeField]
	private AnimationCurve m_MixInCurve;

	[SerializeField]
	private AnimationCurve m_MixOutCurve;

	[SerializeField]
	private BlendCurveMode m_BlendInCurveMode;

	[SerializeField]
	private BlendCurveMode m_BlendOutCurveMode;

	[SerializeField]
	private List<string> m_ExposedParameterNames;

	[SerializeField]
	private AnimationClip m_AnimationCurves;

	[SerializeField]
	private bool m_Recordable;

	[SerializeField]
	private ClipExtrapolation m_PostExtrapolationMode;

	[SerializeField]
	private ClipExtrapolation m_PreExtrapolationMode;

	[SerializeField]
	private double m_PostExtrapolationTime;

	[SerializeField]
	private double m_PreExtrapolationTime;

	[SerializeField]
	private string m_DisplayName;

	public bool hasPreExtrapolation => false;

	public bool hasPostExtrapolation => false;

	public double timeScale
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public double start
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public double duration
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public double end => 0.0;

	public double clipIn
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public string displayName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public double clipAssetDuration => 0.0;

	public AnimationClip curves
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	string ICurvesOwner.defaultCurvesName => null;

	public bool hasCurves => false;

	public Object asset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Object ICurvesOwner.assetOwner => null;

	TrackAsset ICurvesOwner.targetTrack => null;

	[Obsolete("underlyingAsset property is obsolete. Use asset property instead", true)]
	public Object underlyingAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", false)]
	public TrackAsset parentTrack
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public double easeInDuration
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public double easeOutDuration
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	[Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", true)]
	public double eastOutTime => 0.0;

	public double easeOutTime => 0.0;

	public double blendInDuration
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public double blendOutDuration
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public BlendCurveMode blendInCurveMode
	{
		get
		{
			return default(BlendCurveMode);
		}
		set
		{
		}
	}

	public BlendCurveMode blendOutCurveMode
	{
		get
		{
			return default(BlendCurveMode);
		}
		set
		{
		}
	}

	public bool hasBlendIn => false;

	public bool hasBlendOut => false;

	public AnimationCurve mixInCurve
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float mixInPercentage => 0f;

	public double mixInDuration => 0.0;

	public AnimationCurve mixOutCurve
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public double mixOutTime => 0.0;

	public double mixOutDuration => 0.0;

	public float mixOutPercentage => 0f;

	public bool recordable
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	[Obsolete("exposedParameter is deprecated and will be removed in a future release", true)]
	public List<string> exposedParameters => null;

	public ClipCaps clipCaps => default(ClipCaps);

	public AnimationClip animationClip => null;

	public ClipExtrapolation postExtrapolationMode
	{
		get
		{
			return default(ClipExtrapolation);
		}
		internal set
		{
		}
	}

	public ClipExtrapolation preExtrapolationMode
	{
		get
		{
			return default(ClipExtrapolation);
		}
		internal set
		{
		}
	}

	public double extrapolatedStart => 0.0;

	public double extrapolatedDuration => 0.0;

	private void UpgradeToLatestVersion()
	{
	}

	internal TimelineClip(TrackAsset parent)
	{
	}

	public TrackAsset GetParentTrack()
	{
		return null;
	}

	internal void SetParentTrack_Internal(TrackAsset newParentTrack)
	{
	}

	internal int Hash()
	{
		return 0;
	}

	public float EvaluateMixOut(double time)
	{
		return 0f;
	}

	public float EvaluateMixIn(double time)
	{
		return 0f;
	}

	private static AnimationCurve GetDefaultMixInCurve()
	{
		return null;
	}

	private static AnimationCurve GetDefaultMixOutCurve()
	{
		return null;
	}

	public double ToLocalTime(double time)
	{
		return 0.0;
	}

	public double ToLocalTimeUnbound(double time)
	{
		return 0.0;
	}

	internal double FromLocalTimeUnbound(double time)
	{
		return 0.0;
	}

	private static double SanitizeTimeValue(double value, double defaultValue)
	{
		return 0.0;
	}

	internal void SetPostExtrapolationTime(double time)
	{
	}

	internal void SetPreExtrapolationTime(double time)
	{
	}

	public bool IsExtrapolatedTime(double sequenceTime)
	{
		return false;
	}

	public bool IsPreExtrapolatedTime(double sequenceTime)
	{
		return false;
	}

	public bool IsPostExtrapolatedTime(double sequenceTime)
	{
		return false;
	}

	private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration)
	{
		return 0.0;
	}

	public void CreateCurves(string curvesClipName)
	{
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void ConformEaseValues()
	{
	}

	private static double CalculateEasingRatio(double easeIn, double easeOut)
	{
		return 0.0;
	}

	private void UpdateDirty(double oldValue, double newValue)
	{
	}
}
