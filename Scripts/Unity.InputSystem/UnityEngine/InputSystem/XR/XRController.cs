using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR;

[InputControlLayout(commonUsages = new string[] { "LeftHand", "RightHand" }, isGenericTypeOfDevice = true, displayName = "XR Controller")]
public class XRController : TrackedDevice
{
	public static XRController leftHand => null;

	public static XRController rightHand => null;

	protected override void FinishSetup()
	{
	}
}
