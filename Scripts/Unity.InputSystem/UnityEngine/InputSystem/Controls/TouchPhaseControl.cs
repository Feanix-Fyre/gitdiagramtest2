using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = true)]
public class TouchPhaseControl : InputControl<TouchPhase>
{
	public unsafe override TouchPhase ReadUnprocessedValueFromState(void* statePtr)
	{
		return default(TouchPhase);
	}

	public unsafe override void WriteValueIntoState(TouchPhase value, void* statePtr)
	{
	}
}
