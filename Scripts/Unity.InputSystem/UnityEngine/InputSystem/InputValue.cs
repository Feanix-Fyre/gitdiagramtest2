using System.Diagnostics;

namespace UnityEngine.InputSystem;

[DebuggerDisplay("Value = {Get()}")]
public class InputValue
{
	internal InputAction.CallbackContext? m_Context;

	public bool isPressed => false;

	public object Get()
	{
		return null;
	}

	public TValue Get<TValue>() where TValue : struct
	{
		return default(TValue);
	}
}
