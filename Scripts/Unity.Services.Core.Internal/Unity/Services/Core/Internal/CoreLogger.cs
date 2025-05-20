using System;
using System.Diagnostics;

namespace Unity.Services.Core.Internal;

internal static class CoreLogger
{
	internal const string Tag = "[ServicesCore]";

	internal const string VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING";

	private const string k_TelemetryLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING";

	public static void Log(object message)
	{
	}

	public static void LogWarning(object message)
	{
	}

	public static void LogError(object message)
	{
	}

	public static void LogException(Exception exception)
	{
	}

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertion(object message)
	{
	}

	[Conditional("ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING")]
	public static void LogVerbose(object message)
	{
	}

	[Conditional("ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING")]
	public static void LogTelemetry(object message)
	{
	}
}
