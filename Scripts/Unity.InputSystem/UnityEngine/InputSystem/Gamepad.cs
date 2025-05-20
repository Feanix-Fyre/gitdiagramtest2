using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Haptics;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(GamepadState), isGenericTypeOfDevice = true)]
public class Gamepad : InputDevice, IDualMotorRumble, IHaptics
{
	private DualMotorRumble m_Rumble;

	private static int s_GamepadCount;

	private static Gamepad[] s_Gamepads;

	public ButtonControl buttonWest { get; protected set; }

	public ButtonControl buttonNorth { get; protected set; }

	public ButtonControl buttonSouth { get; protected set; }

	public ButtonControl buttonEast { get; protected set; }

	public ButtonControl leftStickButton { get; protected set; }

	public ButtonControl rightStickButton { get; protected set; }

	public ButtonControl startButton { get; protected set; }

	public ButtonControl selectButton { get; protected set; }

	public DpadControl dpad { get; protected set; }

	public ButtonControl leftShoulder { get; protected set; }

	public ButtonControl rightShoulder { get; protected set; }

	public StickControl leftStick { get; protected set; }

	public StickControl rightStick { get; protected set; }

	public ButtonControl leftTrigger { get; protected set; }

	public ButtonControl rightTrigger { get; protected set; }

	public ButtonControl aButton => null;

	public ButtonControl bButton => null;

	public ButtonControl xButton => null;

	public ButtonControl yButton => null;

	public ButtonControl triangleButton => null;

	public ButtonControl squareButton => null;

	public ButtonControl circleButton => null;

	public ButtonControl crossButton => null;

	public ButtonControl this[GamepadButton button] => null;

	public static Gamepad current { get; private set; }

	public new static ReadOnlyArray<Gamepad> all => default(ReadOnlyArray<Gamepad>);

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

	public virtual void PauseHaptics()
	{
	}

	public virtual void ResumeHaptics()
	{
	}

	public virtual void ResetHaptics()
	{
	}

	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency)
	{
	}
}
