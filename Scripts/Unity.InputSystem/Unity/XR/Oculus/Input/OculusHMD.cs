using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Headset", hideInUI = true)]
public class OculusHMD : XRHMD
{
	[InputControl]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new string[] { "devicetrackingstate" })]
	[InputControl(name = "isTracked", layout = "Button", aliases = new string[] { "deviceistracked" })]
	public ButtonControl userPresence { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAngularVelocity { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAcceleration { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAngularAcceleration { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeAngularVelocity { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeAcceleration { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeAngularAcceleration { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeAngularVelocity { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeAcceleration { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeAngularAcceleration { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeAngularVelocity { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeAcceleration { get; protected set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeAngularAcceleration { get; protected set; }

	protected override void FinishSetup()
	{
	}
}
