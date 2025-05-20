using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Scripting;

namespace UnityEngine.InputSystem.XR;

[InputControlLayout(stateType = typeof(PoseState))]
[Preserve]
public class PoseControl : InputControl<PoseState>
{
	public ButtonControl isTracked { get; set; }

	public IntegerControl trackingState { get; set; }

	public Vector3Control position { get; set; }

	public QuaternionControl rotation { get; set; }

	public Vector3Control velocity { get; set; }

	public Vector3Control angularVelocity { get; set; }

	protected override void FinishSetup()
	{
	}

	public unsafe override PoseState ReadUnprocessedValueFromState(void* statePtr)
	{
		return default(PoseState);
	}

	public unsafe override void WriteValueIntoState(PoseState value, void* statePtr)
	{
	}

	protected override FourCC CalculateOptimizedControlDataType()
	{
		return default(FourCC);
	}
}
