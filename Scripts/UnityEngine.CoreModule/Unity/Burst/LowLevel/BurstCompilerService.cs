using System.Reflection;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/Burst.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType.Arrow)]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
internal static class BurstCompilerService
{
	public enum BurstLogType
	{
		Info = 0,
		Warning = 1,
		Error = 2
	}

	[ThreadSafe]
	public static string GetDisassembly(MethodInfo m, string compilerOptions)
	{
		return null;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions)
	{
		return 0;
	}

	[FreeFunction(IsThreadSafe = true)]
	public unsafe static void* GetAsyncCompiledAsyncDelegateMethod(int userID)
	{
		return null;
	}

	[ThreadSafe]
	public unsafe static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment)
	{
		return null;
	}

	[ThreadSafe]
	public static void SetCurrentExecutionMode(uint environment)
	{
	}

	[ThreadSafe]
	public static uint GetCurrentExecutionMode()
	{
		return 0u;
	}

	[FreeFunction("DefaultBurstLogCallback", true)]
	public unsafe static void Log(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber)
	{
	}

	[FreeFunction("DefaultBurstRuntimeLogCallback", true)]
	public unsafe static void RuntimeLog(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber)
	{
	}

	public static bool LoadBurstLibrary(string fullPathToLibBurstGenerated)
	{
		return false;
	}
}
