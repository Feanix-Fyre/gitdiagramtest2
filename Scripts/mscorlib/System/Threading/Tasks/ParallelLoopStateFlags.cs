namespace System.Threading.Tasks;

internal class ParallelLoopStateFlags
{
	private int _loopStateFlags;

	internal int LoopStateFlags => 0;

	internal bool AtomicLoopStateUpdate(int newState, int illegalStates)
	{
		return false;
	}

	internal bool AtomicLoopStateUpdate(int newState, int illegalStates, ref int oldState)
	{
		return false;
	}

	internal void SetExceptional()
	{
	}

	internal bool Cancel()
	{
		return false;
	}
}
