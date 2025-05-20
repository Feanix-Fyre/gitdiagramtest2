using System.Diagnostics.Tracing;

namespace System.Threading.Tasks;

[EventSource(Name = "System.Threading.Tasks.Parallel.EventSource")]
internal sealed class ParallelEtwProvider : EventSource
{
	public enum ForkJoinOperationType
	{
		ParallelInvoke = 1,
		ParallelFor = 2,
		ParallelForEach = 3
	}

	public class Tasks
	{
		public const EventTask Loop = (EventTask)1;

		public const EventTask Invoke = (EventTask)2;

		public const EventTask ForkJoin = (EventTask)5;
	}

	public static readonly ParallelEtwProvider Log;

	private ParallelEtwProvider()
	{
	}

	[Event(1, Level = EventLevel.Informational, Task = (EventTask)1, Opcode = EventOpcode.Start)]
	public void ParallelLoopBegin(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID, ForkJoinOperationType OperationType, long InclusiveFrom, long ExclusiveTo)
	{
	}

	[Event(2, Level = EventLevel.Informational, Task = (EventTask)1, Opcode = EventOpcode.Stop)]
	public void ParallelLoopEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID, long TotalIterations)
	{
	}

	[Event(5, Level = EventLevel.Verbose, Task = (EventTask)5, Opcode = EventOpcode.Start)]
	public void ParallelFork(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID)
	{
	}

	[Event(6, Level = EventLevel.Verbose, Task = (EventTask)5, Opcode = EventOpcode.Stop)]
	public void ParallelJoin(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID)
	{
	}
}
