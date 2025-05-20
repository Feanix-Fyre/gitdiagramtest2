using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine.Networking.PlayerConnection;

[Serializable]
public class PlayerConnection : ScriptableObject, IEditorPlayerConnection
{
	internal static IPlayerEditorConnectionNative connectionNative;

	[SerializeField]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;

	[SerializeField]
	private List<int> m_connectedPlayers;

	private bool m_IsInitilized;

	private static PlayerConnection s_Instance;

	public static PlayerConnection instance => null;

	public bool isConnected => false;

	private static PlayerConnection CreateInstance()
	{
		return null;
	}

	public void OnEnable()
	{
	}

	private IPlayerEditorConnectionNative GetConnectionNativeApi()
	{
		return null;
	}

	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback)
	{
	}

	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback)
	{
	}

	public void RegisterConnection(UnityAction<int> callback)
	{
	}

	public void RegisterDisconnection(UnityAction<int> callback)
	{
	}

	public void UnregisterConnection(UnityAction<int> callback)
	{
	}

	public void UnregisterDisconnection(UnityAction<int> callback)
	{
	}

	public void Send(Guid messageId, byte[] data)
	{
	}

	public bool TrySend(Guid messageId, byte[] data)
	{
		return false;
	}

	public bool BlockUntilRecvMsg(Guid messageId, int timeout)
	{
		return false;
	}

	public void DisconnectAll()
	{
	}

	[RequiredByNativeCode]
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
	{
	}

	[RequiredByNativeCode]
	private static void ConnectedCallbackInternal(int playerId)
	{
	}

	[RequiredByNativeCode]
	private static void DisconnectedCallback(int playerId)
	{
	}
}
