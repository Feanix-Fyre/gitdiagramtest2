using System.Diagnostics;
using UnityEngine.Scripting;

namespace UnityEngine;

public static class StackTraceUtility
{
	private static string projectFolder;

	[RequiredByNativeCode]
	internal static void SetProjectFolder(string folder)
	{
	}

	[RequiredByNativeCode]
	public static string ExtractStackTrace()
	{
		return null;
	}

	[RequiredByNativeCode]
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace)
	{
		message = null;
		stackTrace = null;
	}

	internal static string ExtractFormattedStackTrace(StackTrace stackTrace)
	{
		return null;
	}
}
