using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(JoystickState), isGenericTypeOfDevice = true)]
public class Joystick : InputDevice
{
	private static int s_JoystickCount;

	private static Joystick[] s_Joysticks;

	public ButtonControl trigger { get; protected set; }

	public StickControl stick { get; protected set; }

	public AxisControl twist { get; protected set; }

	public Vector2Control hatswitch { get; protected set; }

	public static Joystick current { get; private set; }

	public new static ReadOnlyArray<Joystick> all => default(ReadOnlyArray<Joystick>);

	protected override void FinishSetup()
	{
	}

	public override void MakeCurrent()
	{
	}

	protected override void OnAdded()
	{
	}

	protected override void OnRemoved()
	{
	}
}
