using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch;

public class Finger
{
	internal readonly InputStateHistory<TouchState> m_StateHistory;

	public Touchscreen screen { get; }

	public int index { get; }

	public bool isActive => false;

	public Vector2 screenPosition => default(Vector2);

	public Touch lastTouch => default(Touch);

	public Touch currentTouch => default(Touch);

	public TouchHistory touchHistory => default(TouchHistory);

	internal Finger(Touchscreen screen, int index, InputUpdateType updateMask)
	{
	}

	private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr)
	{
		return false;
	}

	private void OnTouchRecorded(InputStateHistory.Record record)
	{
	}

	private Touch FindTouch(uint uniqueId)
	{
		return default(Touch);
	}

	internal TouchHistory GetTouchHistory(Touch touch)
	{
		return default(TouchHistory);
	}
}
