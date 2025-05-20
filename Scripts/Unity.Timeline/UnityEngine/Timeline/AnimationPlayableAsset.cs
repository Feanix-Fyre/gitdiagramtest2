using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
[NotKeyable]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
{
	public enum LoopMode
	{
		[Tooltip("Use the loop time setting from the source AnimationClip.")]
		UseSourceAsset = 0,
		[Tooltip("The source AnimationClip loops during playback.")]
		On = 1,
		[Tooltip("The source AnimationClip does not loop during playback.")]
		Off = 2
	}

	private enum Versions
	{
		Initial = 0,
		RotationAsEuler = 1
	}

	private static class AnimationPlayableAssetUpgrade
	{
		public static void ConvertRotationToEuler(AnimationPlayableAsset asset)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_outputs_003Ed__45 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PlayableBinding _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AnimationPlayableAsset _003C_003E4__this;

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
		public _003Cget_outputs_003Ed__45(int _003C_003E1__state)
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

	[SerializeField]
	private AnimationClip m_Clip;

	[SerializeField]
	private Vector3 m_Position;

	[SerializeField]
	private Vector3 m_EulerAngles;

	[SerializeField]
	private bool m_UseTrackMatchFields;

	[SerializeField]
	private MatchTargetFields m_MatchTargetFields;

	[SerializeField]
	private bool m_RemoveStartOffset;

	[SerializeField]
	private bool m_ApplyFootIK;

	[SerializeField]
	private LoopMode m_Loop;

	private static readonly int k_LatestVersion;

	[SerializeField]
	[HideInInspector]
	private int m_Version;

	[SerializeField]
	[Obsolete("Use m_RotationEuler Instead", false)]
	[HideInInspector]
	private Quaternion m_Rotation;

	public Vector3 position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 eulerAngles
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public bool useTrackMatchFields
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MatchTargetFields matchTargetFields
	{
		get
		{
			return default(MatchTargetFields);
		}
		set
		{
		}
	}

	public bool removeStartOffset
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool applyFootIK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public LoopMode loop
	{
		get
		{
			return default(LoopMode);
		}
		set
		{
		}
	}

	internal bool hasRootTransforms => false;

	internal AppliedOffsetMode appliedOffsetMode { get; set; }

	public AnimationClip clip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override double duration => 0.0;

	public override IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(_003Cget_outputs_003Ed__45))]
		get
		{
			return null;
		}
	}

	public ClipCaps clipCaps => default(ClipCaps);

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop)
	{
		return default(Playable);
	}

	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
	{
		return false;
	}

	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
	{
		return false;
	}

	public void ResetOffsets()
	{
	}

	public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	internal static bool HasRootTransforms(AnimationClip clip)
	{
		return false;
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	private void OnUpgradeFromVersion(int oldVersion)
	{
	}
}
