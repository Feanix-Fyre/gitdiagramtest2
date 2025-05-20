using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Pack = 1, Size = 25)]
public struct StateEvent : IInputEventTypeInfo
{
	public const int Type = 1398030676;

	internal const int kStateDataSizeToSubtract = 1;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public FourCC stateFormat;

	[FieldOffset(24)]
	internal unsafe fixed byte stateData[1];

	public uint stateSizeInBytes => 0u;

	public unsafe void* state => null;

	public FourCC typeStatic => default(FourCC);

	public InputEventPtr ToEventPtr()
	{
		return default(InputEventPtr);
	}

	public TState GetState<TState>() where TState : struct, IInputStateTypeInfo
	{
		return default(TState);
	}

	public static TState GetState<TState>(InputEventPtr ptr) where TState : struct, IInputStateTypeInfo
	{
		return default(TState);
	}

	public static int GetEventSizeWithPayload<TState>() where TState : struct
	{
		return 0;
	}

	public unsafe static StateEvent* From(InputEventPtr ptr)
	{
		return null;
	}

	internal unsafe static StateEvent* FromUnchecked(InputEventPtr ptr)
	{
		return null;
	}

	public static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
	{
		eventPtr = default(InputEventPtr);
		return default(NativeArray<byte>);
	}

	public static NativeArray<byte> FromDefaultStateFor(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
	{
		eventPtr = default(InputEventPtr);
		return default(NativeArray<byte>);
	}

	private static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator, bool useDefaultState)
	{
		eventPtr = default(InputEventPtr);
		return default(NativeArray<byte>);
	}
}
