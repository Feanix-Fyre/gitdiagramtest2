using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Analytics.Internal;

internal class AnalyticsUserIdServiceComponent : IAnalyticsUserId, IServiceComponent
{
	private readonly IAnalyticsService m_AnalyticsService;

	public AnalyticsUserIdServiceComponent(IAnalyticsService analyticsService)
	{
	}

	public string GetAnalyticsUserId()
	{
		return null;
	}
}
