using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Data;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics;

internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder, IServiceDebug
{
	private const string k_ForgetCallingId = "com.unity.services.analytics.Events.RequestDataDeletion";

	private const string k_StartUpCallingId = "com.unity.services.analytics.Events.Startup";

	private const string k_PlayerChangedCallingId = "com.unity.services.analytics.Events.PlayerChanged";

	internal const string k_InvokedByUserCallingId = "com.unity.services.analytics.Events.UserInvoked";

	private readonly TimeSpan k_BackgroundSessionRefreshPeriod;

	private readonly TransactionCurrencyConverter converter;

	private readonly IIdentityManager m_UserIdentity;

	private readonly ISessionManager m_Session;

	private readonly IDataGenerator m_DataGenerator;

	private readonly ICoreStatsHelper m_CoreStatsHelper;

	private readonly IDispatcher m_DataDispatcher;

	private readonly IAnalyticsForgetter m_AnalyticsForgetter;

	private readonly IAnalyticsServiceSystemCalls m_SystemCalls;

	private readonly IAnalyticsContainer m_Container;

	internal IBuffer m_DataBuffer;

	private int m_BufferLengthAtLastGameRunning;

	private DateTime m_ApplicationPauseTime;

	private bool m_IsActive;

	private bool m_StartUpEventsRecorded;

	public string PrivacyUrl => null;

	public string SessionID => null;

	internal bool Active
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsActive => false;

	public IIdentityManager UserIdentity => null;

	internal int AutoflushPeriodMultiplier => 0;

	public string GetAnalyticsUserID()
	{
		return null;
	}

	internal AnalyticsServiceInstance(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IIdentityManager userIdentity, string environment, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container, ISessionManager session)
	{
	}

	internal void ResumeDataDeletionIfNecessary()
	{
	}

	public void StartDataCollection()
	{
	}

	private void Activate()
	{
	}

	public void StopDataCollection()
	{
	}

	internal void DeactivateWithDataDeletionRequest()
	{
	}

	private void DataDeletionCompleted()
	{
	}

	private void Deactivate()
	{
	}

	private void RecordStartupEvents(string callingId)
	{
	}

	private void PlayerChanged()
	{
	}

	internal void ApplicationPaused(bool paused)
	{
	}

	public void Flush()
	{
	}

	public void RequestDataDeletion()
	{
	}

	internal void ApplicationQuit()
	{
	}

	internal void RecordGameRunningIfNecessary()
	{
	}

	public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
	{
		return 0L;
	}

	public void CustomData(string eventName)
	{
	}

	public void CustomData(string eventName, IDictionary<string, object> eventParams)
	{
	}

	public void CustomData(string eventName, IDictionary<string, object> eventParams, int? eventVersion, bool isStandardEvent, string callingMethodIdentifier)
	{
	}

	public void RecordEvent(string name)
	{
	}

	public void RecordEvent(Event e)
	{
	}

	internal void RecordEvent(Event e, string callingMethodIdentifier)
	{
	}
}
