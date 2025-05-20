using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 152)]
public struct IMECompositionEvent : IInputEventTypeInfo
{
	internal const int kIMECharBufferSize = 64;

	public const int Type = 1229800787;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public IMECompositionString compositionString;

	public FourCC typeStatic => default(FourCC);

	public static IMECompositionEvent Create(int deviceId, string compositionString, double time)
	{
		return default(IMECompositionEvent);
	}
}
