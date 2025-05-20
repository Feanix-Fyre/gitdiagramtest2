using System;
using System.Diagnostics;

namespace Newtonsoft.Json.Serialization;

public class DiagnosticsTraceWriter : ITraceWriter
{
	public TraceLevel LevelFilter { get; set; }

	private TraceEventType GetTraceEventType(TraceLevel level)
	{
		return default(TraceEventType);
	}

	public void Trace(TraceLevel level, string message, Exception? ex)
	{
	}
}
