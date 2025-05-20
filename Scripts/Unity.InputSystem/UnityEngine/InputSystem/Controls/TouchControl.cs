using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(stateType = typeof(TouchState))]
public class TouchControl : InputControl<TouchState>
{
	public TouchPressControl press { get; set; }

	public IntegerControl displayIndex { get; set; }

	public IntegerControl touchId { get; set; }

	public Vector2Control position { get; set; }

	public DeltaControl delta { get; set; }

	public AxisControl pressure { get; set; }

	public Vector2Control radius { get; set; }

	public TouchPhaseControl phase { get; set; }

	public ButtonControl indirectTouch { get; set; }

	public ButtonControl tap { get; set; }

	public IntegerControl tapCount { get; set; }

	public DoubleControl startTime { get; set; }

	public Vector2Control startPosition { get; set; }

	public bool isInProgress => false;

	protected override void FinishSetup()
	{
	}

	public unsafe override TouchState ReadUnprocessedValueFromState(void* statePtr)
	{
		return default(TouchState);
	}

	public unsafe override void WriteValueIntoState(TouchState value, void* statePtr)
	{
	}
}
