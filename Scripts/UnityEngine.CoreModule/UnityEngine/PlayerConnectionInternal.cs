using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
{
	void IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId)
	{
	}

	bool IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId)
	{
		return false;
	}

	void IPlayerEditorConnectionNative.Poll()
	{
	}

	void IPlayerEditorConnectionNative.RegisterInternal(Guid messageId)
	{
	}

	void IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId)
	{
	}

	void IPlayerEditorConnectionNative.Initialize()
	{
	}

	bool IPlayerEditorConnectionNative.IsConnected()
	{
		return false;
	}

	void IPlayerEditorConnectionNative.DisconnectAll()
	{
	}

	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	private static bool IsConnected()
	{
		return false;
	}

	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	private static void Initialize()
	{
	}

	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	private static void RegisterInternal(string messageId)
	{
	}

	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	private static void UnregisterInternal(string messageId)
	{
	}

	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	private static void SendMessage(string messageId, [Unmarshalled] byte[] data, int playerId)
	{
	}

	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	private static bool TrySendMessage(string messageId, [Unmarshalled] byte[] data, int playerId)
	{
		return false;
	}

	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	private static void PollInternal()
	{
	}

	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	private static void DisconnectAll()
	{
	}
}
