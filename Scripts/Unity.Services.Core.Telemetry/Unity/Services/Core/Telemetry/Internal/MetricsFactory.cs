using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal;

internal class MetricsFactory : IMetricsFactory, IServiceComponent
{
	public IReadOnlyDictionary<string, string> CommonTags { get; }

	public IMetrics Create(string packageName)
	{
		return null;
	}
}
