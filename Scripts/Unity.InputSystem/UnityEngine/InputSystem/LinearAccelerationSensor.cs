using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(LinearAccelerationState), displayName = "Linear Acceleration")]
public class LinearAccelerationSensor : Sensor
{
	public Vector3Control acceleration { get; protected set; }

	public static LinearAccelerationSensor current { get; private set; }

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
