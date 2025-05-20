using System;
using System.Runtime.CompilerServices;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device.Internal;

namespace Unity.Services.Analytics.Internal;

internal class IdentityManager : IIdentityManager
{
	internal const string k_UnityAnalyticsInstallationIdKey = "UnityAnalyticsInstallationId";

	internal const string k_UnityAnalyticsUserIdKey = "UnityAnalyticsUserId";

	private readonly IPlayerId m_PlayerId;

	private readonly IExternalUserId m_ExternalIdProvider;

	private readonly IPersistence m_Persistence;

	private bool m_Initialized;

	public string UserId { get; private set; }

	public string InstallId { get; private set; }

	public string PlayerId => null;

	public string ExternalId { get; private set; }

	public bool IsNewPlayer { get; private set; }

	public event Action OnPlayerChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public IdentityManager(IInstallationId installId, IPlayerId playerId, IExternalUserId externalId, IPersistence persistence)
	{
	}

	public void Initialize()
	{
	}

	private void ExternalUserIdChanged(string newName)
	{
	}
}
