using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = true)]
public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
{
	internal static float s_TapTime;

	internal static float s_TapDelayTime;

	internal static float s_TapRadiusSquared;

	public TouchControl primaryTouch { get; protected set; }

	public ReadOnlyArray<TouchControl> touches { get; protected set; }

	protected TouchControl[] touchControlArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public new static Touchscreen current { get; internal set; }

	public override void MakeCurrent()
	{
	}

	protected override void OnRemoved()
	{
	}

	protected override void FinishSetup()
	{
	}

	protected new void OnNextUpdate()
	{
	}

	protected new void OnStateEvent(InputEventPtr eventPtr)
	{
	}

	void IInputStateCallbackReceiver.OnNextUpdate()
	{
	}

	void IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr)
	{
	}

	bool IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
	{
		return false;
	}

	void ICustomDeviceReset.Reset()
	{
	}

	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		return false;
	}

	bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		return false;
	}

	private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr)
	{
	}
}
