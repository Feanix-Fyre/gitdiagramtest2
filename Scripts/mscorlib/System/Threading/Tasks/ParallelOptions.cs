namespace System.Threading.Tasks;

/// <summary>Stores options that configure the operation of methods on the <see cref="T:System.Threading.Tasks.Parallel" /> class.</summary>
public class ParallelOptions
{
	private TaskScheduler _scheduler;

	private int _maxDegreeOfParallelism;

	private CancellationToken _cancellationToken;

	/// <summary>Gets or sets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with this <see cref="T:System.Threading.Tasks.ParallelOptions" /> instance. Setting this property to null indicates that the current scheduler should be used.</summary>
	/// <returns>The task scheduler that is associated with this instance.</returns>
	public TaskScheduler TaskScheduler => null;

	internal TaskScheduler EffectiveTaskScheduler => null;

	/// <summary>Gets or sets the maximum number of concurrent tasks enabled by this <see cref="T:System.Threading.Tasks.ParallelOptions" /> instance.</summary>
	/// <returns>An integer that represents the maximum degree of parallelism.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to zero or to a value that is less than -1.</exception>
	public int MaxDegreeOfParallelism
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.Tasks.ParallelOptions" /> instance.</summary>
	/// <returns>The token that is associated with this instance.</returns>
	public CancellationToken CancellationToken => default(CancellationToken);

	internal int EffectiveMaxConcurrencyLevel => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.ParallelOptions" /> class.</summary>
	public ParallelOptions()
	{
	}
}
