using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Pack = 1, Size = 29)]
public struct DeltaStateEvent : IInputEventTypeInfo
{
	public const int Type = 1145852993;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public FourCC stateFormat;

	[FieldOffset(24)]
	public uint stateOffset;

	[FieldOffset(28)]
	internal unsafe fixed byte stateData[1];

	public uint deltaStateSizeInBytes => 0u;

	public unsafe void* deltaState => null;

	public FourCC typeStatic => default(FourCC);

	public InputEventPtr ToEventPtr()
	{
		return default(InputEventPtr);
	}

	public unsafe static DeltaStateEvent* From(InputEventPtr ptr)
	{
		return null;
	}

	internal unsafe static DeltaStateEvent* FromUnchecked(InputEventPtr ptr)
	{
		return null;
	}

	public static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
	{
		eventPtr = default(InputEventPtr);
		return default(NativeArray<byte>);
	}
}
