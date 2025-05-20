using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Light")]
public class LightSensor : Sensor
{
	[InputControl(displayName = "Light Level", noisy = true)]
	public AxisControl lightLevel { get; protected set; }

	public static LightSensor current { get; private set; }

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
