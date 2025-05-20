using System;

namespace Unity.Services.Analytics.Internal;

internal class AnalyticsForgetter : IAnalyticsForgetter
{
	private enum DataDeletionStatus
	{
		DataAllowed = 0,
		DeletionInProgress = 1,
		SuccessfullyDeleted = 2
	}

	private const string k_ForgottenStatusKey = "unity.services.analytics.data_deletion_status";

	private readonly string m_CollectUrl;

	private readonly IPersistence m_Persistence;

	private readonly IWebRequestHelper m_WebRequestHelper;

	private Action m_Callback;

	private DataDeletionStatus m_DeletionStatus;

	private IWebRequest m_Request;

	public bool DeletionInProgress => false;

	internal AnalyticsForgetter(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper)
	{
	}

	public void ResetDataDeletionStatus()
	{
	}

	private void SetForgettingStatus(DataDeletionStatus state)
	{
	}

	public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback)
	{
	}

	private void UploadComplete(long code)
	{
	}
}
