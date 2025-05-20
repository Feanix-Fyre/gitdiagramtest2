using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Pressure")]
public class PressureSensor : Sensor
{
	[InputControl(displayName = "Atmospheric Pressure", noisy = true)]
	public AxisControl atmosphericPressure { get; protected set; }

	public static PressureSensor current { get; private set; }

	public override void MakeCurrent()
	{
	}

	protected override void OnRemoved()
	{
	}

	protected override void FinishSetup()
	{
	}
}
