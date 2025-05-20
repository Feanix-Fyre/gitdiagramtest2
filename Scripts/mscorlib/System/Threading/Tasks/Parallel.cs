using System.Collections;

namespace System.Threading.Tasks;

/// <summary>Provides support for parallel loops and regions.</summary>
public static class Parallel
{
	internal static int s_forkJoinContextID;

	internal static readonly ParallelOptions s_defaultParallelOptions;

	/// <summary>Executes a <see langword="for" /> (<see langword="For" /> in Visual Basic) loop in which iterations may run in parallel.</summary>
	/// <param name="fromInclusive">The start index, inclusive.</param>
	/// <param name="toExclusive">The end index, exclusive.</param>
	/// <param name="body">The delegate that is invoked once per iteration.</param>
	/// <returns>A structure that contains information about which portion of the loop completed.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="body" /> argument is <see langword="null" />.</exception>
	/// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
	public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int> body)
	{
		return default(ParallelLoopResult);
	}

	/// <summary>Executes a <see langword="for" /> (<see langword="For" /> in Visual Basic) loop in which iterations may run in parallel and loop options can be configured.</summary>
	/// <param name="fromInclusive">The start index, inclusive.</param>
	/// <param name="toExclusive">The end index, exclusive.</param>
	/// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
	/// <param name="body">The delegate that is invoked once per iteration.</param>
	/// <returns>A  structure that contains information about which portion of the loop completed.</returns>
	/// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> argument is canceled.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="body" /> argument is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="parallelOptions" /> argument is <see langword="null" />.</exception>
	/// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
	public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body)
	{
		return default(ParallelLoopResult);
	}

	private static bool CheckTimeoutReached(int timeoutOccursAt)
	{
		return false;
	}

	private static int ComputeTimeoutPoint(int timeoutLength)
	{
		return 0;
	}

	private static ParallelLoopResult ForWorker<TLocal>(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body, Action<int, ParallelLoopState> bodyWithState, Func<int, ParallelLoopState, TLocal, TLocal> bodyWithLocal, Func<TLocal> localInit, Action<TLocal> localFinally)
	{
		return default(ParallelLoopResult);
	}

	private static OperationCanceledException ReduceToSingleCancellationException(ICollection exceptions, CancellationToken cancelToken)
	{
		return null;
	}

	private static void ThrowSingleCancellationExceptionOrOtherException(ICollection exceptions, CancellationToken cancelToken, Exception otherException)
	{
	}
}
