using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = true)]
public class TouchPressControl : ButtonControl
{
	protected override void FinishSetup()
	{
	}

	public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
	{
		return 0f;
	}

	public unsafe override void WriteValueIntoState(float value, void* statePtr)
	{
	}
}
