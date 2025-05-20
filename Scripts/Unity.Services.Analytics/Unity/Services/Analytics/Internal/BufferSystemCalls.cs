using System;

namespace Unity.Services.Analytics.Internal;

internal class BufferSystemCalls : IBufferSystemCalls
{
	public string GenerateGuid()
	{
		return null;
	}

	public DateTime Now()
	{
		return default(DateTime);
	}

	public TimeSpan GetTimeZoneUtcOffset(DateTime dateTime)
	{
		return default(TimeSpan);
	}
}
