using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls;

public class QuaternionControl : InputControl<Quaternion>
{
	[InputControl(displayName = "X")]
	public AxisControl x { get; set; }

	[InputControl(displayName = "Y")]
	public AxisControl y { get; set; }

	[InputControl(displayName = "Z")]
	public AxisControl z { get; set; }

	[InputControl(displayName = "W")]
	public AxisControl w { get; set; }

	protected override void FinishSetup()
	{
	}

	public unsafe override Quaternion ReadUnprocessedValueFromState(void* statePtr)
	{
		return default(Quaternion);
	}

	public unsafe override void WriteValueIntoState(Quaternion value, void* statePtr)
	{
	}

	protected override FourCC CalculateOptimizedControlDataType()
	{
		return default(FourCC);
	}
}
