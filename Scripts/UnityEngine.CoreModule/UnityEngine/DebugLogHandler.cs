using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
internal sealed class DebugLogHandler : ILogHandler
{
	[ThreadAndSerializationSafe]
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj)
	{
	}

	[ThreadAndSerializationSafe]
	internal static void Internal_LogException(Exception ex, Object obj)
	{
	}

	public void LogFormat(LogType logType, Object context, string format, params object[] args)
	{
	}

	public void LogException(Exception exception, Object context)
	{
	}
}
