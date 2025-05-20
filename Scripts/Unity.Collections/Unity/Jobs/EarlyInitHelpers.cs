using System;
using System.Collections.Generic;

namespace Unity.Jobs;

public class EarlyInitHelpers
{
	public delegate void EarlyInitFunction();

	private static List<EarlyInitFunction> s_PendingDelegates;

	public static void FlushEarlyInits()
	{
	}

	public static void AddEarlyInitFunction(EarlyInitFunction f)
	{
	}

	public static void JobReflectionDataCreationFailed(Exception ex, Type jobType)
	{
	}
}
