namespace UnityEngine.InputSystem;

public static class InputExtensions
{
	public static bool IsInProgress(this InputActionPhase phase)
	{
		return false;
	}

	public static bool IsEndedOrCanceled(this TouchPhase phase)
	{
		return false;
	}

	public static bool IsActive(this TouchPhase phase)
	{
		return false;
	}

	public static bool IsModifierKey(this Key key)
	{
		return false;
	}

	public static bool IsTextInputKey(this Key key)
	{
		return false;
	}
}
