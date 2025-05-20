using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 20)]
public struct DeviceConfigurationEvent : IInputEventTypeInfo
{
	public const int Type = 1145259591;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	public FourCC typeStatic => default(FourCC);

	public InputEventPtr ToEventPtr()
	{
		return default(InputEventPtr);
	}

	public static DeviceConfigurationEvent Create(int deviceId, double time)
	{
		return default(DeviceConfigurationEvent);
	}
}
