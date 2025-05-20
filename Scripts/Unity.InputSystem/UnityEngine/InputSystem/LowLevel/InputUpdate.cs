using System;

namespace UnityEngine.InputSystem.LowLevel;

internal static class InputUpdate
{
	[Serializable]
	public struct UpdateStepCount
	{
		private bool m_WasUpdated;

		public uint value { get; private set; }

		public void OnBeforeUpdate()
		{
		}

		public void OnUpdate()
		{
		}
	}

	[Serializable]
	public struct SerializedState
	{
		public InputUpdateType lastUpdateType;

		public UpdateStepCount playerUpdateStepCount;
	}

	public static uint s_UpdateStepCount;

	public static InputUpdateType s_LatestUpdateType;

	public static UpdateStepCount s_PlayerUpdateStepCount;

	internal static void OnBeforeUpdate(InputUpdateType type)
	{
	}

	internal static void OnUpdate(InputUpdateType type)
	{
	}

	public static SerializedState Save()
	{
		return default(SerializedState);
	}

	public static void Restore(SerializedState state)
	{
	}

	public static InputUpdateType GetUpdateTypeForPlayer(this InputUpdateType mask)
	{
		return default(InputUpdateType);
	}

	public static bool IsPlayerUpdate(this InputUpdateType updateType)
	{
		return false;
	}
}
