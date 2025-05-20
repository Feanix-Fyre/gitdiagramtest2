using System;

namespace UnityEngine.InputSystem;

public struct InputInteractionContext
{
	[Flags]
	internal enum Flags
	{
		TimerHasExpired = 2
	}

	internal InputActionState m_State;

	internal Flags m_Flags;

	internal InputActionState.TriggerState m_TriggerState;

	public InputAction action => null;

	public InputControl control => null;

	public InputActionPhase phase => default(InputActionPhase);

	public double time => 0.0;

	public double startTime => 0.0;

	public bool timerHasExpired
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool isWaiting => false;

	public bool isStarted => false;

	internal int mapIndex => 0;

	internal int controlIndex => 0;

	internal int bindingIndex => 0;

	internal int interactionIndex => 0;

	public float ComputeMagnitude()
	{
		return 0f;
	}

	public bool ControlIsActuated(float threshold = 0f)
	{
		return false;
	}

	public void Started()
	{
	}

	public void Performed()
	{
	}

	public void PerformedAndStayStarted()
	{
	}

	public void PerformedAndStayPerformed()
	{
	}

	public void Canceled()
	{
	}

	public void Waiting()
	{
	}

	public void SetTimeout(float seconds)
	{
	}

	public void SetTotalTimeoutCompletionTime(float seconds)
	{
	}

	public TValue ReadValue<TValue>() where TValue : struct
	{
		return default(TValue);
	}
}
