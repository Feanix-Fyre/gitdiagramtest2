using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.Net;

internal static class TimerThread
{
	internal abstract class Queue
	{
		private readonly int m_DurationMilliseconds;

		internal int Duration => 0;

		internal Queue(int durationMilliseconds)
		{
		}

		internal abstract Timer CreateTimer(Callback callback, object context);
	}

	internal abstract class Timer : IDisposable
	{
		private readonly int m_StartTimeMilliseconds;

		private readonly int m_DurationMilliseconds;

		internal int StartTime => 0;

		internal int Expiration => 0;

		internal abstract bool HasExpired { get; }

		internal Timer(int durationMilliseconds)
		{
		}

		internal abstract bool Cancel();

		public void Dispose()
		{
		}
	}

	internal delegate void Callback(Timer timer, int timeNoticed, object context);

	private class TimerQueue : Queue
	{
		private IntPtr m_ThisHandle;

		private readonly TimerNode m_Timers;

		internal TimerQueue(int durationMilliseconds)
			: base(0)
		{
		}

		internal override Timer CreateTimer(Callback callback, object context)
		{
			return null;
		}

		internal bool Fire(out int nextExpiration)
		{
			nextExpiration = default(int);
			return false;
		}
	}

	private class InfiniteTimerQueue : Queue
	{
		internal InfiniteTimerQueue()
			: base(0)
		{
		}

		internal override Timer CreateTimer(Callback callback, object context)
		{
			return null;
		}
	}

	private class TimerNode : Timer
	{
		private enum TimerState
		{
			Ready = 0,
			Fired = 1,
			Cancelled = 2,
			Sentinel = 3
		}

		private TimerState m_TimerState;

		private Callback m_Callback;

		private object m_Context;

		private object m_QueueLock;

		private TimerNode next;

		private TimerNode prev;

		internal override bool HasExpired => false;

		internal TimerNode Next
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal TimerNode Prev
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal TimerNode(Callback callback, object context, int durationMilliseconds, object queueLock)
			: base(0)
		{
		}

		internal TimerNode()
			: base(0)
		{
		}

		internal override bool Cancel()
		{
			return false;
		}

		internal bool Fire()
		{
			return false;
		}
	}

	private class InfiniteTimer : Timer
	{
		private int cancelled;

		internal override bool HasExpired => false;

		internal InfiniteTimer()
			: base(0)
		{
		}

		internal override bool Cancel()
		{
			return false;
		}
	}

	private static LinkedList<WeakReference> s_Queues;

	private static LinkedList<WeakReference> s_NewQueues;

	private static int s_ThreadState;

	private static AutoResetEvent s_ThreadReadyEvent;

	private static ManualResetEvent s_ThreadShutdownEvent;

	private static WaitHandle[] s_ThreadEvents;

	private static int s_CacheScanIteration;

	private static Hashtable s_QueuesCache;

	static TimerThread()
	{
	}

	internal static Queue CreateQueue(int durationMilliseconds)
	{
		return null;
	}

	internal static Queue GetOrCreateQueue(int durationMilliseconds)
	{
		return null;
	}

	private static void Prod()
	{
	}

	private static void ThreadProc()
	{
	}

	private static void StopTimerThread()
	{
	}

	private static bool IsTickBetween(int start, int end, int comparand)
	{
		return false;
	}

	private static void OnDomainUnload(object sender, EventArgs e)
	{
	}
}
