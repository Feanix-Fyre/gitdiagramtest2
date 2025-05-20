namespace System.Threading.Tasks;

internal class ParallelLoopStateFlags32 : ParallelLoopStateFlags
{
	internal int _lowestBreakIteration;

	internal int LowestBreakIteration => 0;

	internal bool ShouldExitLoop(int CallerIteration)
	{
		return false;
	}

	internal bool ShouldExitLoop()
	{
		return false;
	}
}
