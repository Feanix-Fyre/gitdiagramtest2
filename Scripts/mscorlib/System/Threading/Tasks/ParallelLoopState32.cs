namespace System.Threading.Tasks;

internal class ParallelLoopState32 : ParallelLoopState
{
	private readonly ParallelLoopStateFlags32 _sharedParallelStateFlags;

	private int _currentIteration;

	internal int CurrentIteration
	{
		set
		{
		}
	}

	internal ParallelLoopState32(ParallelLoopStateFlags32 sharedParallelStateFlags)
		: base(null)
	{
	}
}
