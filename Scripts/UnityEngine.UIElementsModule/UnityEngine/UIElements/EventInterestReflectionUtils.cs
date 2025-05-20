using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal static class EventInterestReflectionUtils
{
	private struct DefaultEventInterests
	{
		public int DefaultActionCategories;

		public int DefaultActionAtTargetCategories;
	}

	private static readonly Dictionary<Type, DefaultEventInterests> s_DefaultEventInterests;

	private static readonly Dictionary<Type, EventCategory> s_EventCategories;

	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories)
	{
		defaultActionCategories = default(int);
		defaultActionAtTargetCategories = default(int);
	}

	private static int ComputeDefaultEventInterests(Type elementType, string methodName)
	{
		return 0;
	}

	internal static EventCategory GetEventCategory(Type eventType)
	{
		return default(EventCategory);
	}
}
