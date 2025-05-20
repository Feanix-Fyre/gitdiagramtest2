namespace System.Threading;

/// <summary>Provides support for spin-based waiting.</summary>
public struct SpinWait
{
	internal static readonly int SpinCountforSpinBeforeWait;

	private int _count;

	/// <summary>Gets the number of times <see cref="M:System.Threading.SpinWait.SpinOnce" /> has been called on this instance.</summary>
	/// <returns>Returns an integer that represents the number of times <see cref="M:System.Threading.SpinWait.SpinOnce" /> has been called on this instance.</returns>
	public int Count => 0;

	/// <summary>Gets whether the next call to <see cref="M:System.Threading.SpinWait.SpinOnce" /> will yield the processor, triggering a forced context switch.</summary>
	/// <returns>Whether the next call to <see cref="M:System.Threading.SpinWait.SpinOnce" /> will yield the processor, triggering a forced context switch.</returns>
	public bool NextSpinWillYield => false;

	/// <summary>Performs a single spin.</summary>
	public void SpinOnce()
	{
	}

	public void SpinOnce(int sleep1Threshold)
	{
	}

	private void SpinOnceCore(int sleep1Threshold)
	{
	}
}
