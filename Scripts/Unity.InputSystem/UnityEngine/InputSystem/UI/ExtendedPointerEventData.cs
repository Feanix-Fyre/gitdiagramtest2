using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

namespace UnityEngine.InputSystem.UI;

public class ExtendedPointerEventData : PointerEventData
{
	public InputControl control { get; set; }

	public InputDevice device { get; set; }

	public int touchId { get; set; }

	public UIPointerType pointerType { get; set; }

	public int uiToolkitPointerId { get; set; }

	public Vector3 trackedDevicePosition { get; set; }

	public Quaternion trackedDeviceOrientation { get; set; }

	public ExtendedPointerEventData(EventSystem eventSystem)
		: base(null)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static int MakePointerIdForTouch(int deviceId, int touchId)
	{
		return 0;
	}

	internal static int TouchIdFromPointerId(int pointerId)
	{
		return 0;
	}

	internal void ReadDeviceState()
	{
	}

	private static int GetPenPointerId(Pen pen)
	{
		return 0;
	}

	private static int GetTouchPointerId(TouchControl touchControl)
	{
		return 0;
	}
}
