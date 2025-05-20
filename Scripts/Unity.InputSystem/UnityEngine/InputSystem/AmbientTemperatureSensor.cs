using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Ambient Temperature")]
public class AmbientTemperatureSensor : Sensor
{
	[InputControl(displayName = "Ambient Temperature", noisy = true)]
	public AxisControl ambientTemperature { get; protected set; }

	public static AmbientTemperatureSensor current { get; private set; }

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
