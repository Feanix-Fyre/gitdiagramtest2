using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR;

public class EyesControl : InputControl<Eyes>
{
	[InputControl(offset = 0u, displayName = "LeftEyePosition")]
	public Vector3Control leftEyePosition { get; set; }

	[InputControl(offset = 12u, displayName = "LeftEyeRotation")]
	public QuaternionControl leftEyeRotation { get; set; }

	[InputControl(offset = 28u, displayName = "RightEyePosition")]
	public Vector3Control rightEyePosition { get; set; }

	[InputControl(offset = 40u, displayName = "RightEyeRotation")]
	public QuaternionControl rightEyeRotation { get; set; }

	[InputControl(offset = 56u, displayName = "FixationPoint")]
	public Vector3Control fixationPoint { get; set; }

	[InputControl(offset = 68u, displayName = "LeftEyeOpenAmount")]
	public AxisControl leftEyeOpenAmount { get; set; }

	[InputControl(offset = 72u, displayName = "RightEyeOpenAmount")]
	public AxisControl rightEyeOpenAmount { get; set; }

	protected override void FinishSetup()
	{
	}

	public unsafe override Eyes ReadUnprocessedValueFromState(void* statePtr)
	{
		return default(Eyes);
	}

	public unsafe override void WriteValueIntoState(Eyes value, void* statePtr)
	{
	}
}
