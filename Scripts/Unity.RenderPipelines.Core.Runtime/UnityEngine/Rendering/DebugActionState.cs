using UnityEngine.InputSystem;

namespace UnityEngine.Rendering;

internal class DebugActionState
{
	private enum DebugActionKeyType
	{
		Button = 0,
		Axis = 1,
		Key = 2
	}

	private DebugActionKeyType m_Type;

	private InputAction inputAction;

	private bool[] m_TriggerPressedUp;

	private float m_Timer;

	internal bool runningAction { get; private set; }

	internal float actionState { get; private set; }

	private void Trigger(int triggerCount, float state)
	{
	}

	public void TriggerWithButton(InputAction action, float state)
	{
	}

	private void Reset()
	{
	}

	public void Update(DebugActionDesc desc)
	{
	}
}
