using System;

namespace Unity.Services.Analytics;

internal class AnalyticsServiceSystemCalls : IAnalyticsServiceSystemCalls
{
	public DateTime UtcNow => default(DateTime);
}
