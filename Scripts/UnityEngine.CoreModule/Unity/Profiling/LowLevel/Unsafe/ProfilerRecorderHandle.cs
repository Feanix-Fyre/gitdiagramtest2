using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe;

[StructLayout((LayoutKind)2, Size = 8)]
[UsedByNativeCode]
public readonly struct ProfilerRecorderHandle
{
	[FieldOffset(0)]
	internal readonly ulong handle;

	public bool Valid => false;

	internal ProfilerRecorderHandle(ulong handle)
	{
		this.handle = 0uL;
	}

	public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle)
	{
		return default(ProfilerRecorderDescription);
	}

	[NativeMethod(IsThreadSafe = true)]
	internal unsafe static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, byte* name, int nameLen)
	{
		return default(ProfilerRecorderHandle);
	}

	[NativeMethod(IsThreadSafe = true)]
	private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle)
	{
		return default(ProfilerRecorderDescription);
	}

	private unsafe static void GetByName__Unmanaged_Injected(ref ProfilerCategory category, byte* name, int nameLen, out ProfilerRecorderHandle ret)
	{
		ret = default(ProfilerRecorderHandle);
	}

	private static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret)
	{
		ret = default(ProfilerRecorderDescription);
	}
}
