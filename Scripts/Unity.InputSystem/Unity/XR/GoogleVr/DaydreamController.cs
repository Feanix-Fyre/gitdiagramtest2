using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.GoogleVr;

[InputControlLayout(displayName = "Daydream Controller", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
public class DaydreamController : XRController
{
	[InputControl]
	public Vector2Control touchpad { get; protected set; }

	[InputControl]
	public ButtonControl volumeUp { get; protected set; }

	[InputControl]
	public ButtonControl recentered { get; protected set; }

	[InputControl]
	public ButtonControl volumeDown { get; protected set; }

	[InputControl]
	public ButtonControl recentering { get; protected set; }

	[InputControl]
	public ButtonControl app { get; protected set; }

	[InputControl]
	public ButtonControl home { get; protected set; }

	[InputControl]
	public ButtonControl touchpadClicked { get; protected set; }

	[InputControl]
	public ButtonControl touchpadTouched { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceVelocity { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAcceleration { get; protected set; }

	protected override void FinishSetup()
	{
	}
}
