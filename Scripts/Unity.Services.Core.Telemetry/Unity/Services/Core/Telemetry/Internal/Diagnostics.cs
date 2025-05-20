using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal;

internal class Diagnostics : IDiagnostics
{
	public void SendDiagnostic(string name, string message, IDictionary<string, string> tags = null)
	{
	}
}
