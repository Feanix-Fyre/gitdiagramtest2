using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngineInternal.Input;

[NativeHeader("Modules/Input/Private/InputInternal.h")]
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
internal class NativeInputSystem
{
	public static NativeUpdateCallback onUpdate;

	public static Action<NativeInputUpdateType> onBeforeUpdate;

	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate;

	private static Action<int, string> s_OnDeviceDiscoveredCallback;

	public static Action<int, string> onDeviceDiscovered
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal static bool hasDeviceDiscoveredCallback
	{
		set
		{
		}
	}

	[NativeProperty(IsThreadSafe = true)]
	public static double currentTime => 0.0;

	[NativeProperty(IsThreadSafe = true)]
	public static double currentTimeOffsetToRealtimeSinceStartup => 0.0;

	static NativeInputSystem()
	{
	}

	[RequiredByNativeCode]
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType)
	{
	}

	[RequiredByNativeCode]
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer)
	{
	}

	[RequiredByNativeCode]
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
	{
	}

	[RequiredByNativeCode]
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval)
	{
		retval = default(bool);
	}

	[FreeFunction("AllocateInputDeviceId")]
	public static int AllocateDeviceId()
	{
		return 0;
	}

	[NativeMethod(IsThreadSafe = true)]
	public static void QueueInputEvent(IntPtr inputEvent)
	{
	}

	public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes)
	{
		return 0L;
	}

	public static void SetPollingFrequency(float hertz)
	{
	}

	public static void Update(NativeInputUpdateType updateType)
	{
	}
}
