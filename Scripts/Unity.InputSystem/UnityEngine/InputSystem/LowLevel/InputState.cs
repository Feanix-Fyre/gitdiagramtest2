using System;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

public static class InputState
{
	private class StateChangeMonitorDelegate : IInputStateChangeMonitor
	{
		public Action<InputControl, double, InputEventPtr, long> valueChangeCallback;

		public Action<InputControl, double, long, int> timerExpiredCallback;

		public void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
		{
		}

		public void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
		{
		}
	}

	public static InputUpdateType currentUpdateType => default(InputUpdateType);

	public static uint updateCount => 0u;

	public static double currentTime => 0.0;

	public static event Action<InputDevice, InputEventPtr> onChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = InputUpdateType.None)
	{
	}

	public static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = InputUpdateType.None, InputEventPtr eventPtr = default(InputEventPtr)) where TState : struct
	{
	}

	public static void Change<TState>(InputControl control, ref TState state, InputUpdateType updateType = InputUpdateType.None, InputEventPtr eventPtr = default(InputEventPtr)) where TState : struct
	{
	}

	public static bool IsIntegerFormat(this FourCC format)
	{
		return false;
	}

	public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1L, uint groupIndex = 0u)
	{
	}

	public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1, Action<InputControl, double, long, int> timerExpiredCallback = null)
	{
		return null;
	}

	public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1L)
	{
	}

	public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1L, int timerIndex = -1)
	{
	}

	public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1L, int timerIndex = -1)
	{
	}
}
