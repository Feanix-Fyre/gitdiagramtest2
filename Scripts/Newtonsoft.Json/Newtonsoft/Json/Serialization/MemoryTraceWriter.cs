using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Newtonsoft.Json.Serialization;

public class MemoryTraceWriter : ITraceWriter
{
	private readonly Queue<string> _traceMessages;

	private readonly object _lock;

	public TraceLevel LevelFilter { get; set; }

	public void Trace(TraceLevel level, string message, Exception? ex)
	{
	}

	public IEnumerable<string> GetTraceMessages()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
