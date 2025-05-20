using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
public class OculusTouchController : XRControllerWithRumble
{
	[InputControl(aliases = new string[] { "Primary2DAxis", "Joystick" })]
	public Vector2Control thumbstick { get; protected set; }

	[InputControl]
	public AxisControl trigger { get; protected set; }

	[InputControl]
	public AxisControl grip { get; protected set; }

	[InputControl(aliases = new string[] { "A", "X", "Alternate" })]
	public ButtonControl primaryButton { get; protected set; }

	[InputControl(aliases = new string[] { "B", "Y", "Primary" })]
	public ButtonControl secondaryButton { get; protected set; }

	[InputControl(aliases = new string[] { "GripButton" })]
	public ButtonControl gripPressed { get; protected set; }

	[InputControl]
	public ButtonControl start { get; protected set; }

	[InputControl(aliases = new string[] { "JoystickOrPadPressed", "thumbstickClick" })]
	public ButtonControl thumbstickClicked { get; protected set; }

	[InputControl(aliases = new string[] { "ATouched", "XTouched", "ATouch", "XTouch" })]
	public ButtonControl primaryTouched { get; protected set; }

	[InputControl(aliases = new string[] { "BTouched", "YTouched", "BTouch", "YTouch" })]
	public ButtonControl secondaryTouched { get; protected set; }

	[InputControl(aliases = new string[] { "indexTouch", "indexNearTouched" })]
	public AxisControl triggerTouched { get; protected set; }

	[InputControl(aliases = new string[] { "indexButton", "indexTouched" })]
	public ButtonControl triggerPressed { get; protected set; }

	[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[] { "controllerRotation" })]
	[InputControl(name = "isTracked", layout = "Button", aliases = new string[] { "ControllerIsTracked" })]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new string[] { "controllerTrackingState" })]
	[InputControl(aliases = new string[] { "JoystickOrPadTouched", "thumbstickTouch" })]
	[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[] { "controllerPosition" })]
	public ButtonControl thumbstickTouched { get; protected set; }

	[InputControl(noisy = true, aliases = new string[] { "controllerVelocity" })]
	public Vector3Control deviceVelocity { get; protected set; }

	[InputControl(noisy = true, aliases = new string[] { "controllerAngularVelocity" })]
	public Vector3Control deviceAngularVelocity { get; protected set; }

	[InputControl(noisy = true, aliases = new string[] { "controllerAcceleration" })]
	public Vector3Control deviceAcceleration { get; protected set; }

	[InputControl(noisy = true, aliases = new string[] { "controllerAngularAcceleration" })]
	public Vector3Control deviceAngularAcceleration { get; protected set; }

	protected override void FinishSetup()
	{
	}
}
