using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
[TrackClipType(typeof(AudioPlayableAsset), false)]
[TrackBindingType(typeof(AudioSource))]
[ExcludeFromPreset]
public class AudioTrack : TrackAsset
{
	[CompilerGenerated]
	private sealed class _003Cget_outputs_003Ed__4 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PlayableBinding _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AudioTrack _003C_003E4__this;

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
		public _003Cget_outputs_003Ed__4(int _003C_003E1__state)
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
	private AudioMixerProperties m_TrackProperties;

	public override IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(_003Cget_outputs_003Ed__4))]
		get
		{
			return null;
		}
	}

	public TimelineClip CreateClip(AudioClip clip)
	{
		return null;
	}

	internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
	{
		return default(Playable);
	}

	private void OnValidate()
	{
	}
}
