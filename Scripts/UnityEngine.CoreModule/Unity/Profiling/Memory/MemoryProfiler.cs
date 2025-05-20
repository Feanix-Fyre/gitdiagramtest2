using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.Memory;

[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
public static class MemoryProfiler
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<string, bool> m_SnapshotFinished;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<MemorySnapshotMetadata> CreatingMetadata;

	[RequiredByNativeCode]
	private static byte[] PrepareMetadata()
	{
		return null;
	}

	internal static int WriteIntToByteArray(byte[] array, int offset, int value)
	{
		return 0;
	}

	internal static int WriteStringToByteArray(byte[] array, int offset, string value)
	{
		return 0;
	}

	[RequiredByNativeCode]
	private static void FinalizeSnapshot(string path, bool result)
	{
	}

	[RequiredByNativeCode]
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height)
	{
	}
}
