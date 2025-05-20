using System.Runtime.ConstrainedExecution;

namespace System.Threading;

internal sealed class ThreadPoolWorkQueue
{
	internal class SparseArray<T> where T : class
	{
		private T[] m_array;

		internal T[] Current => null;

		internal SparseArray(int initialSize)
		{
		}

		internal int Add(T e)
		{
			return 0;
		}

		internal void Remove(T e)
		{
		}
	}

	internal class WorkStealingQueue
	{
		internal IThreadPoolWorkItem[] m_array;

		private int m_mask;

		private int m_headIndex;

		private int m_tailIndex;

		private SpinLock m_foreignLock;

		public void LocalPush(IThreadPoolWorkItem obj)
		{
		}

		public bool LocalFindAndPop(IThreadPoolWorkItem obj)
		{
			return false;
		}

		public bool LocalPop(out IThreadPoolWorkItem obj)
		{
			obj = null;
			return false;
		}

		public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
		{
			obj = null;
			return false;
		}

		private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
		{
			obj = null;
			return false;
		}
	}

	internal class QueueSegment
	{
		internal readonly IThreadPoolWorkItem[] nodes;

		private int indexes;

		public QueueSegment Next;

		private void GetIndexes(out int upper, out int lower)
		{
			upper = default(int);
			lower = default(int);
		}

		private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
		{
			return false;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public QueueSegment()
		{
		}

		public bool IsUsedUp()
		{
			return false;
		}

		public bool TryEnqueue(IThreadPoolWorkItem node)
		{
			return false;
		}

		public bool TryDequeue(out IThreadPoolWorkItem node)
		{
			node = null;
			return false;
		}
	}

	internal QueueSegment queueHead;

	internal QueueSegment queueTail;

	internal static SparseArray<WorkStealingQueue> allThreadQueues;

	private int numOutstandingThreadRequests;

	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
	{
		return null;
	}

	internal void EnsureThreadRequested()
	{
	}

	internal void MarkThreadRequestSatisfied()
	{
	}

	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
	{
	}

	internal bool LocalFindAndPop(IThreadPoolWorkItem callback)
	{
		return false;
	}

	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
	{
		callback = null;
		missedSteal = default(bool);
	}

	internal static bool Dispatch()
	{
		return false;
	}
}
