using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Proximity")]
public class ProximitySensor : Sensor
{
	[InputControl(displayName = "Distance", noisy = true)]
	public AxisControl distance { get; protected set; }

	public static ProximitySensor current { get; private set; }

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
