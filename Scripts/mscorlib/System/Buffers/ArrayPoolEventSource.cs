using System.Diagnostics.Tracing;

namespace System.Buffers;

[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
internal sealed class ArrayPoolEventSource : EventSource
{
	internal enum BufferAllocatedReason
	{
		Pooled = 0,
		OverMaximumSize = 1,
		PoolExhausted = 2
	}

	internal static readonly ArrayPoolEventSource Log;

	private ArrayPoolEventSource()
	{
	}

	[Event(1, Level = EventLevel.Verbose)]
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId)
	{
	}

	[Event(2, Level = EventLevel.Informational)]
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, BufferAllocatedReason reason)
	{
	}

	[Event(3, Level = EventLevel.Verbose)]
	internal void BufferReturned(int bufferId, int bufferSize, int poolId)
	{
	}

	[Event(4, Level = EventLevel.Informational)]
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId)
	{
	}

	[Event(5, Level = EventLevel.Informational)]
	internal void BufferTrimPoll(int milliseconds, int pressure)
	{
	}
}
