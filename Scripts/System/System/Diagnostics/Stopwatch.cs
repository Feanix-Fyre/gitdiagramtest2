namespace System.Diagnostics;

/// <summary>Provides a set of methods and properties that you can use to accurately measure elapsed time.</summary>
public class Stopwatch
{
	/// <summary>Gets the frequency of the timer as the number of ticks per second. This field is read-only.</summary>
	public static readonly long Frequency;

	/// <summary>Indicates whether the timer is based on a high-resolution performance counter. This field is read-only.</summary>
	public static readonly bool IsHighResolution;

	private long elapsed;

	private long started;

	private bool is_running;

	/// <summary>Gets the total elapsed time measured by the current instance.</summary>
	/// <returns>A read-only <see cref="T:System.TimeSpan" /> representing the total elapsed time measured by the current instance.</returns>
	public TimeSpan Elapsed => default(TimeSpan);

	/// <summary>Gets the total elapsed time measured by the current instance, in milliseconds.</summary>
	/// <returns>A read-only long integer representing the total number of milliseconds measured by the current instance.</returns>
	public long ElapsedMilliseconds => 0L;

	/// <summary>Gets the total elapsed time measured by the current instance, in timer ticks.</summary>
	/// <returns>A read-only long integer representing the total number of timer ticks measured by the current instance.</returns>
	public long ElapsedTicks => 0L;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Diagnostics.Stopwatch" /> timer is running.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Diagnostics.Stopwatch" /> instance is currently running and measuring elapsed time for an interval; otherwise, <see langword="false" />.</returns>
	public bool IsRunning => false;

	/// <summary>Gets the current number of ticks in the timer mechanism.</summary>
	/// <returns>A long integer representing the tick counter value of the underlying timer mechanism.</returns>
	public static long GetTimestamp()
	{
		return 0L;
	}

	/// <summary>Initializes a new <see cref="T:System.Diagnostics.Stopwatch" /> instance, sets the elapsed time property to zero, and starts measuring elapsed time.</summary>
	/// <returns>A <see cref="T:System.Diagnostics.Stopwatch" /> that has just begun measuring elapsed time.</returns>
	public static Stopwatch StartNew()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Stopwatch" /> class.</summary>
	public Stopwatch()
	{
	}

	/// <summary>Stops time interval measurement and resets the elapsed time to zero.</summary>
	public void Reset()
	{
	}

	/// <summary>Starts, or resumes, measuring elapsed time for an interval.</summary>
	public void Start()
	{
	}

	/// <summary>Stops measuring elapsed time for an interval.</summary>
	public void Stop()
	{
	}

	/// <summary>Stops time interval measurement, resets the elapsed time to zero, and starts measuring elapsed time.</summary>
	public void Restart()
	{
	}
}
