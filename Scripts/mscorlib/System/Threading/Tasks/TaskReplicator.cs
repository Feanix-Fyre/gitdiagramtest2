using System.Collections.Concurrent;

namespace System.Threading.Tasks;

internal class TaskReplicator
{
	public delegate void ReplicatableUserAction<TState>(ref TState replicaState, int timeout, out bool yieldedBeforeCompletion);

	private abstract class Replica
	{
		protected readonly TaskReplicator _replicator;

		protected readonly int _timeout;

		protected int _remainingConcurrency;

		protected Task _pendingTask;

		protected Replica(TaskReplicator replicator, int maxConcurrency, int timeout)
		{
		}

		public void Start()
		{
		}

		public void Wait()
		{
		}

		public void Execute()
		{
		}

		protected abstract void CreateNewReplica();

		protected abstract void ExecuteAction(out bool yieldedBeforeCompletion);
	}

	private sealed class Replica<TState> : Replica
	{
		private readonly ReplicatableUserAction<TState> _action;

		private TState _state;

		public Replica(TaskReplicator replicator, int maxConcurrency, int timeout, ReplicatableUserAction<TState> action)
			: base(null, 0, 0)
		{
		}

		protected override void CreateNewReplica()
		{
		}

		protected override void ExecuteAction(out bool yieldedBeforeCompletion)
		{
			yieldedBeforeCompletion = default(bool);
		}
	}

	private readonly TaskScheduler _scheduler;

	private readonly bool _stopOnFirstFailure;

	private readonly ConcurrentQueue<Replica> _pendingReplicas;

	private ConcurrentQueue<Exception> _exceptions;

	private bool _stopReplicating;

	private TaskReplicator(ParallelOptions options, bool stopOnFirstFailure)
	{
	}

	public static void Run<TState>(ReplicatableUserAction<TState> action, ParallelOptions options, bool stopOnFirstFailure)
	{
	}

	private static int GenerateCooperativeMultitaskingTaskTimeout()
	{
		return 0;
	}
}
