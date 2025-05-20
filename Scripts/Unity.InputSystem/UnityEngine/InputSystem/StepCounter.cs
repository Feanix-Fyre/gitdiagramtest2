using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Step Counter")]
public class StepCounter : Sensor
{
	[InputControl(displayName = "Step Counter", noisy = true)]
	public IntegerControl stepCounter { get; protected set; }

	public static StepCounter current { get; private set; }

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
