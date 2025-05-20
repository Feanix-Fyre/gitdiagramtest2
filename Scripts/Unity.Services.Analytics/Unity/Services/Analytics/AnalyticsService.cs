using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Analytics;

public static class AnalyticsService
{
	private const string k_CollectUrlPattern = "https://collect.analytics.unity3d.com/api/analytics/collect/v2/projects/{0}/environments/{1}";

	private static AnalyticsServiceInstance m_Instance;

	private static IDispatcherDebug m_DispatcherDebug;

	private static IBufferDebug m_BufferDebug;

	private static Action<string, string, DateTime, byte[]> m_EventRecordedCallback;

	private static Action<HashSet<string>> m_EventsClearingCallback;

	private static Action<byte[]> m_FlushStartedCallback;

	private static Action<int, bool, bool, bool, bool, byte[]> m_FlushCompletedCallback;

	internal static bool IsInitialized => false;

	internal static IServiceDebug ServiceDebug => null;

	internal static IDispatcherDebug DispatcherDebug => null;

	public static IAnalyticsService Instance => null;

	internal static void Initialize(CoreRegistry registry)
	{
	}

	internal static void SubscribeDebugEvents(Action<string, string, DateTime, byte[]> eventRecordedCallback, Action<HashSet<string>> eventsUploadingCallback, Action<byte[]> flushStarted, Action<int, bool, bool, bool, bool, byte[]> flushCompleted)
	{
	}

	internal static void UnsubscribeDebugEvents()
	{
	}

	internal static void TearDown()
	{
	}
}
