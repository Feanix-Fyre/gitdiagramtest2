namespace UnityEngine.UIElements;

public static class PointerType
{
	public static readonly string mouse;

	public static readonly string touch;

	public static readonly string pen;

	public static readonly string unknown;

	internal static string GetPointerType(int pointerId)
	{
		return null;
	}

	internal static bool IsDirectManipulationDevice(string pointerType)
	{
		return false;
	}
}
