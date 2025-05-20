using System;

namespace Internal.Runtime.Augments;

internal class RuntimeAugments
{
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks;

	internal static ReflectionExecutionDomainCallbacks Callbacks => null;

	public static void ReportUnhandledException(Exception exception)
	{
	}
}
