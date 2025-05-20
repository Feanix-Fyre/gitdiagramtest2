using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	[CompilerGenerated]
	private sealed class _003Cget_outputs_003Ed__16 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PlayableBinding _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AudioPlayableAsset _003C_003E4__this;

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
		public _003Cget_outputs_003Ed__16(int _003C_003E1__state)
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
	private AudioClip m_Clip;

	[SerializeField]
	private bool m_Loop;

	[SerializeField]
	[HideInInspector]
	private float m_bufferingTime;

	[SerializeField]
	private AudioClipProperties m_ClipProperties;

	internal float bufferingTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AudioClip clip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool loop
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override double duration => 0.0;

	public override IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(_003Cget_outputs_003Ed__16))]
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
}
