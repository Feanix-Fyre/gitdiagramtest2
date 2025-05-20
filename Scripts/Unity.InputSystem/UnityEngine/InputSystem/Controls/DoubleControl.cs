namespace UnityEngine.InputSystem.Controls;

public class DoubleControl : InputControl<double>
{
	public unsafe override double ReadUnprocessedValueFromState(void* statePtr)
	{
		return 0.0;
	}

	public unsafe override void WriteValueIntoState(double value, void* statePtr)
	{
	}
}
