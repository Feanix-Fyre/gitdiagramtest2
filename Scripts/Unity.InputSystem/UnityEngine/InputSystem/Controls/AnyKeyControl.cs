using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = true)]
public class AnyKeyControl : ButtonControl
{
	public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
	{
		return 0f;
	}
}
