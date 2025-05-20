namespace System.Threading.Tasks;

/// <summary>Provides completion status on the execution of a <see cref="T:System.Threading.Tasks.Parallel" /> loop.</summary>
public struct ParallelLoopResult
{
	internal bool _completed;

	internal long? _lowestBreakIteration;
}
