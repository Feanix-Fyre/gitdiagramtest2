using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Humidity")]
public class HumiditySensor : Sensor
{
	[InputControl(displayName = "Relative Humidity", noisy = true)]
	public AxisControl relativeHumidity { get; protected set; }

	public static HumiditySensor current { get; private set; }

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
