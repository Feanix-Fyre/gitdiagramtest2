using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
[ExcludeFromPreset]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
{
	private enum Versions
	{
		Initial = 0
	}

	private static class TimelineAssetUpgrade
	{
	}

	[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
	public enum MediaType
	{
		Animation = 0,
		Audio = 1,
		Texture = 2,
		[Obsolete("Use Texture MediaType instead. (UnityUpgradable) -> UnityEngine.Timeline.TimelineAsset/MediaType.Texture", false)]
		Video = 2,
		Script = 3,
		Hybrid = 4,
		Group = 5
	}

	public enum DurationMode
	{
		BasedOnClips = 0,
		FixedLength = 1
	}

	[Serializable]
	public class EditorSettings
	{
		internal static readonly double kMinFrameRate;

		internal static readonly double kMaxFrameRate;

		internal static readonly double kDefaultFrameRate;

		[FrameRateField]
		[SerializeField]
		[HideInInspector]
		private double m_Framerate;

		[HideInInspector]
		[SerializeField]
		private bool m_ScenePreview;

		[Obsolete("EditorSettings.fps has been deprecated. Use editorSettings.frameRate instead.", false)]
		public float fps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public double frameRate
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public bool scenePreview
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void SetStandardFrameRate(StandardFrameRates enumValue)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_outputs_003Ed__27 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PlayableBinding _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public TimelineAsset _003C_003E4__this;

		private IEnumerator<TrackAsset> _003C_003E7__wrap1;

		private IEnumerator<PlayableBinding> _003C_003E7__wrap2;

		PlayableBinding IEnumerator<PlayableBinding>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(PlayableBinding);
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003Cget_outputs_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private const int k_LatestVersion = 0;

	[HideInInspector]
	[SerializeField]
	private int m_Version;

	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Tracks;

	[HideInInspector]
	[SerializeField]
	private double m_FixedDuration;

	[NonSerialized]
	[HideInInspector]
	private TrackAsset[] m_CacheOutputTracks;

	[NonSerialized]
	[HideInInspector]
	private List<TrackAsset> m_CacheRootTracks;

	[NonSerialized]
	[HideInInspector]
	private TrackAsset[] m_CacheFlattenedTracks;

	[HideInInspector]
	[SerializeField]
	private EditorSettings m_EditorSettings;

	[SerializeField]
	private DurationMode m_DurationMode;

	[HideInInspector]
	[SerializeField]
	private MarkerTrack m_MarkerTrack;

	public EditorSettings editorSettings => null;

	public override double duration => 0.0;

	public double fixedDuration
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public DurationMode durationMode
	{
		get
		{
			return default(DurationMode);
		}
		set
		{
		}
	}

	public override IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(_003Cget_outputs_003Ed__27))]
		get
		{
			return null;
		}
	}

	public ClipCaps clipCaps => default(ClipCaps);

	public int outputTrackCount => 0;

	public int rootTrackCount => 0;

	internal TrackAsset[] flattenedTracks => null;

	public MarkerTrack markerTrack => null;

	internal List<ScriptableObject> trackObjects => null;

	private void UpgradeToLatestVersion()
	{
	}

	private void OnValidate()
	{
	}

	public TrackAsset GetRootTrack(int index)
	{
		return null;
	}

	public IEnumerable<TrackAsset> GetRootTracks()
	{
		return null;
	}

	public TrackAsset GetOutputTrack(int index)
	{
		return null;
	}

	public IEnumerable<TrackAsset> GetOutputTracks()
	{
		return null;
	}

	private static double GetValidFrameRate(double frameRate)
	{
		return 0.0;
	}

	private void UpdateRootTrackCache()
	{
	}

	private void UpdateOutputTrackCache()
	{
	}

	internal void AddTrackInternal(TrackAsset track)
	{
	}

	internal void RemoveTrack(TrackAsset track)
	{
	}

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	private void __internalAwake()
	{
	}

	public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	public void CreateMarkerTrack()
	{
	}

	internal void Invalidate()
	{
	}

	internal void UpdateFixedDurationWithItemsDuration()
	{
	}

	private DiscreteTime CalculateItemsDuration()
	{
		return default(DiscreteTime);
	}

	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks)
	{
	}

	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name)
	{
		return null;
	}

	public T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new()
	{
		return null;
	}

	public T CreateTrack<T>(string trackName) where T : TrackAsset, new()
	{
		return null;
	}

	public T CreateTrack<T>() where T : TrackAsset, new()
	{
		return null;
	}

	public bool DeleteClip(TimelineClip clip)
	{
		return false;
	}

	public bool DeleteTrack(TrackAsset track)
	{
		return false;
	}

	internal void MoveLastTrackBefore(TrackAsset asset)
	{
	}

	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType)
	{
		return null;
	}

	private void DeleteRecordedAnimation(TrackAsset track)
	{
	}

	private void DeleteRecordedAnimation(TimelineClip clip)
	{
	}
}
