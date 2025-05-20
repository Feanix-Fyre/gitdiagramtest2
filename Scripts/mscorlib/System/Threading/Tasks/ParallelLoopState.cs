using System.Diagnostics;

namespace System.Threading.Tasks;

/// <summary>Enables iterations of parallel loops to interact with other iterations. An instance of this class is provided by the <see cref="T:System.Threading.Tasks.Parallel" /> class to each loop; you can not create instances in your code.</summary>
[DebuggerDisplay("ShouldExitCurrentIteration = {ShouldExitCurrentIteration}")]
public class ParallelLoopState
{
	private readonly ParallelLoopStateFlags _flagsBase;

	internal ParallelLoopState(ParallelLoopStateFlags fbase)
	{
	}
}
