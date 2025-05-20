using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(PenState), isGenericTypeOfDevice = true)]
public class Pen : Pointer
{
	public ButtonControl tip { get; protected set; }

	public ButtonControl eraser { get; protected set; }

	public ButtonControl firstBarrelButton { get; protected set; }

	public ButtonControl secondBarrelButton { get; protected set; }

	public ButtonControl thirdBarrelButton { get; protected set; }

	public ButtonControl fourthBarrelButton { get; protected set; }

	public ButtonControl inRange { get; protected set; }

	public Vector2Control tilt { get; protected set; }

	public AxisControl twist { get; protected set; }

	public new static Pen current { get; internal set; }

	public ButtonControl this[PenButton button] => null;

	public override void MakeCurrent()
	{
	}

	protected override void OnRemoved()
	{
	}

	protected override void FinishSetup()
	{
	}
}
