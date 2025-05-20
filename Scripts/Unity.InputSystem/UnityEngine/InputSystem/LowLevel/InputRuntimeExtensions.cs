namespace UnityEngine.InputSystem.LowLevel;

internal static class InputRuntimeExtensions
{
	public static long DeviceCommand<TCommand>(this IInputRuntime runtime, int deviceId, ref TCommand command) where TCommand : struct, IInputDeviceCommandInfo
	{
		return 0L;
	}
}
