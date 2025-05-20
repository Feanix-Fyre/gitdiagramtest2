using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Threading;

/// <summary>Provides a mechanism for executing a method on a thread pool thread at specified intervals. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class Timer : MarshalByRefObject, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	private struct TimerComparer : IComparer, IComparer<Timer>
	{
		int IComparer.Compare(object x, object y)
		{
			return 0;
		}

		public int Compare(Timer tx, Timer ty)
		{
			return 0;
		}
	}

	private sealed class Scheduler
	{
		private static readonly Scheduler instance;

		private bool needReSort;

		private List<Timer> list;

		private long current_next_run;

		private ManualResetEvent changed;

		public static Scheduler Instance => null;

		private void InitScheduler()
		{
		}

		private void WakeupScheduler()
		{
		}

		private void SchedulerThread()
		{
		}

		private Scheduler()
		{
		}

		public void Remove(Timer timer)
		{
		}

		public void Change(Timer timer, long new_next_run)
		{
		}

		private void Add(Timer timer)
		{
		}

		private void InternalRemove(Timer timer)
		{
		}

		private static void TimerCB(object o)
		{
		}

		private void FireTimer(Timer timer)
		{
		}

		private int RunSchedulerLoop()
		{
			return 0;
		}
	}

	private TimerCallback callback;

	private object state;

	private long due_time_ms;

	private long period_ms;

	private long next_run;

	private bool disposed;

	private bool is_dead;

	private bool is_added;

	private const long MaxValue = 4294967294L;

	private static Scheduler scheduler => null;

	/// <summary>Initializes a new instance of the <see langword="Timer" /> class, using a 32-bit signed integer to specify the time interval.</summary>
	/// <param name="callback">A <see cref="T:System.Threading.TimerCallback" /> delegate representing a method to be executed.</param>
	/// <param name="state">An object containing information to be used by the callback method, or <see langword="null" />.</param>
	/// <param name="dueTime">The amount of time to delay before <paramref name="callback" /> is invoked, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to prevent the timer from starting. Specify zero (0) to start the timer immediately.</param>
	/// <param name="period">The time interval between invocations of <paramref name="callback" />, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to disable periodic signaling.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="callback" /> parameter is <see langword="null" />.</exception>
	public Timer(TimerCallback callback, object state, int dueTime, int period)
	{
	}

	/// <summary>Initializes a new instance of the <see langword="Timer" /> class, using <see cref="T:System.TimeSpan" /> values to measure time intervals.</summary>
	/// <param name="callback">A delegate representing a method to be executed.</param>
	/// <param name="state">An object containing information to be used by the callback method, or <see langword="null" />.</param>
	/// <param name="dueTime">The amount of time to delay before the <paramref name="callback" /> parameter invokes its methods. Specify negative one (-1) milliseconds to prevent the timer from starting. Specify zero (0) to start the timer immediately.</param>
	/// <param name="period">The time interval between invocations of the methods referenced by <paramref name="callback" />. Specify negative one (-1) milliseconds to disable periodic signaling.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The number of milliseconds in the value of <paramref name="dueTime" /> or <paramref name="period" /> is negative and not equal to <see cref="F:System.Threading.Timeout.Infinite" />, or is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="callback" /> parameter is <see langword="null" />.</exception>
	public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
	{
	}

	private void Init(TimerCallback callback, object state, long dueTime, long period)
	{
	}

	/// <summary>Changes the start time and the interval between method invocations for a timer, using 32-bit signed integers to measure time intervals.</summary>
	/// <param name="dueTime">The amount of time to delay before the invoking the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to prevent the timer from restarting. Specify zero (0) to restart the timer immediately.</param>
	/// <param name="period">The time interval between invocations of the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed, in milliseconds. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to disable periodic signaling.</param>
	/// <returns>
	///   <see langword="true" /> if the timer was successfully updated; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Timer" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	public bool Change(int dueTime, int period)
	{
		return false;
	}

	/// <summary>Changes the start time and the interval between method invocations for a timer, using <see cref="T:System.TimeSpan" /> values to measure time intervals.</summary>
	/// <param name="dueTime">A <see cref="T:System.TimeSpan" /> representing the amount of time to delay before invoking the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed. Specify negative one (-1) milliseconds to prevent the timer from restarting. Specify zero (0) to restart the timer immediately.</param>
	/// <param name="period">The time interval between invocations of the callback method specified when the <see cref="T:System.Threading.Timer" /> was constructed. Specify negative one (-1) milliseconds to disable periodic signaling.</param>
	/// <returns>
	///   <see langword="true" /> if the timer was successfully updated; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Timer" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter, in milliseconds, is less than -1.</exception>
	/// <exception cref="T:System.NotSupportedException">The <paramref name="dueTime" /> or <paramref name="period" /> parameter, in milliseconds, is greater than 4294967294.</exception>
	public bool Change(TimeSpan dueTime, TimeSpan period)
	{
		return false;
	}

	/// <summary>Releases all resources used by the current instance of <see cref="T:System.Threading.Timer" />.</summary>
	public void Dispose()
	{
	}

	private bool Change(long dueTime, long period, bool first)
	{
		return false;
	}

	internal void KeepRootedWhileScheduled()
	{
	}

	private static long GetTimeMonotonic()
	{
		return 0L;
	}
}
