using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection;

[Serializable]
internal class PlayerEditorConnectionEvents
{
	[Serializable]
	public class MessageEvent : UnityEvent<MessageEventArgs>
	{
	}

	[Serializable]
	public class ConnectionChangeEvent : UnityEvent<int>
	{
	}

	[Serializable]
	public class MessageTypeSubscribers
	{
		[SerializeField]
		private string m_messageTypeId;

		public int subscriberCount;

		public MessageEvent messageCallback;

		public Guid MessageTypeId
		{
			get
			{
				return default(Guid);
			}
			set
			{
			}
		}
	}

	[SerializeField]
	public List<MessageTypeSubscribers> messageTypeSubscribers;

	[SerializeField]
	public ConnectionChangeEvent connectionEvent;

	[SerializeField]
	public ConnectionChangeEvent disconnectionEvent;

	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId)
	{
	}

	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
	{
		return null;
	}

	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback)
	{
	}
}
