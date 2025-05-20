using System.Collections.Generic;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Analytics.Internal;

internal class StandardEventServiceComponent : IAnalyticsStandardEventComponent, IServiceComponent
{
	private readonly IProjectConfiguration m_Configuration;

	private readonly IUnstructuredEventRecorder m_AnalyticsService;

	public StandardEventServiceComponent(IProjectConfiguration configuration, IUnstructuredEventRecorder analyticsService)
	{
	}

	public void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName)
	{
	}
}
