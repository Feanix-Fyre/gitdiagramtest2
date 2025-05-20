using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = true)]
public class Pointer : InputDevice, IInputStateCallbackReceiver
{
	public Vector2Control position { get; protected set; }

	public DeltaControl delta { get; protected set; }

	public Vector2Control radius { get; protected set; }

	public AxisControl pressure { get; protected set; }

	public ButtonControl press { get; protected set; }

	public IntegerControl displayIndex { get; protected set; }

	public static Pointer current { get; internal set; }

	public override void MakeCurrent()
	{
	}

	protected override void OnRemoved()
	{
	}

	protected override void FinishSetup()
	{
	}

	protected void OnNextUpdate()
	{
	}

	protected void OnStateEvent(InputEventPtr eventPtr)
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
}
