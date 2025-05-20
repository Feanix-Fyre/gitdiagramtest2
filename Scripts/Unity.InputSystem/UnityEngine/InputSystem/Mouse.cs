using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(MouseState), isGenericTypeOfDevice = true)]
public class Mouse : Pointer, IInputStateCallbackReceiver
{
	internal static Mouse s_PlatformMouseDevice;

	public DeltaControl scroll { get; protected set; }

	public ButtonControl leftButton { get; protected set; }

	public ButtonControl middleButton { get; protected set; }

	public ButtonControl rightButton { get; protected set; }

	public ButtonControl backButton { get; protected set; }

	public ButtonControl forwardButton { get; protected set; }

	public IntegerControl clickCount { get; protected set; }

	public new static Mouse current { get; private set; }

	public override void MakeCurrent()
	{
	}

	protected override void OnAdded()
	{
	}

	protected override void OnRemoved()
	{
	}

	public void WarpCursorPosition(Vector2 position)
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
}
