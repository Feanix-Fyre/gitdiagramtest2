namespace UnityEngine.InputSystem.Utilities;

internal static class InputArrayExtensions
{
	public static int IndexOfReference<TValue>(this InlinedArray<TValue> array, TValue value) where TValue : class
	{
		return 0;
	}

	public static bool Contains<TValue>(this InlinedArray<TValue> array, TValue value)
	{
		return false;
	}

	public static bool ContainsReference<TValue>(this InlinedArray<TValue> array, TValue value) where TValue : class
	{
		return false;
	}
}
