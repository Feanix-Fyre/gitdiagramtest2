using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class SignalReceiver : MonoBehaviour, INotificationReceiver
{
	[Serializable]
	private class EventKeyValue
	{
		[SerializeField]
		private List<SignalAsset> m_Signals;

		[SerializeField]
		[CustomSignalEventDrawer]
		private List<UnityEvent> m_Events;

		public List<SignalAsset> signals => null;

		public List<UnityEvent> events => null;

		public bool TryGetValue(SignalAsset key, out UnityEvent value)
		{
			value = null;
			return false;
		}

		public void Append(SignalAsset key, UnityEvent value)
		{
		}

		public void Remove(int idx)
		{
		}

		public void Remove(SignalAsset key)
		{
		}
	}

	[SerializeField]
	private EventKeyValue m_Events;

	public void OnNotify(Playable origin, INotification notification, object context)
	{
	}

	public void AddReaction(SignalAsset asset, UnityEvent reaction)
	{
	}

	public int AddEmptyReaction(UnityEvent reaction)
	{
		return 0;
	}

	public void Remove(SignalAsset asset)
	{
	}

	public IEnumerable<SignalAsset> GetRegisteredSignals()
	{
		return null;
	}

	public UnityEvent GetReaction(SignalAsset key)
	{
		return null;
	}

	public int Count()
	{
		return 0;
	}

	public void ChangeSignalAtIndex(int idx, SignalAsset newKey)
	{
	}

	public void RemoveAtIndex(int idx)
	{
	}

	public void ChangeReactionAtIndex(int idx, UnityEvent reaction)
	{
	}

	public UnityEvent GetReactionAtIndex(int idx)
	{
		return null;
	}

	public SignalAsset GetSignalAssetAtIndex(int idx)
	{
		return null;
	}

	private void OnEnable()
	{
	}
}
