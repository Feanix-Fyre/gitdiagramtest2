using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class ServicePointScheduler
{
	private class ConnectionGroup
	{
		private static int nextId;

		public readonly int ID;

		private LinkedList<WebConnection> connections;

		private LinkedList<WebOperation> queue;

		public ServicePointScheduler Scheduler { get; }

		public ConnectionGroup(ServicePointScheduler scheduler, string name)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public void RemoveConnection(WebConnection connection)
		{
		}

		public void Cleanup()
		{
		}

		public void Close()
		{
		}

		public void EnqueueOperation(WebOperation operation)
		{
		}

		public WebOperation GetNextOperation()
		{
			return null;
		}

		public WebConnection FindIdleConnection(WebOperation operation)
		{
			return null;
		}

		public (WebConnection, bool) CreateOrReuseConnection(WebOperation operation, bool force)
		{
			return default((WebConnection, bool));
		}
	}

	private class AsyncManualResetEvent
	{
		private TaskCompletionSource<bool> m_tcs;

		public Task<bool> WaitAsync(int millisecondTimeout)
		{
			return null;
		}

		public void Set()
		{
		}

		public void Reset()
		{
		}

		public AsyncManualResetEvent(bool state)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRunScheduler_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ServicePointScheduler _003C_003E4__this;

		private (ConnectionGroup, WebOperation)[] _003CoperationArray_003E5__2;

		private (ConnectionGroup, WebConnection, Task)[] _003CidleArray_003E5__3;

		private List<Task> _003CtaskList_003E5__4;

		private Task<bool> _003CschedulerTask_003E5__5;

		private bool _003CfinalCleanup_003E5__6;

		private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWaitAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public int millisecondTimeout;

		public Task workerTask;

		private CancellationTokenSource _003Ccts_003E5__2;

		private Task _003CtimeoutTask_003E5__3;

		private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private int running;

	private int maxIdleTime;

	private AsyncManualResetEvent schedulerEvent;

	private ConnectionGroup defaultGroup;

	private Dictionary<string, ConnectionGroup> groups;

	private LinkedList<(ConnectionGroup, WebOperation)> operations;

	private LinkedList<(ConnectionGroup, WebConnection, Task)> idleConnections;

	private int currentConnections;

	private int connectionLimit;

	private DateTime idleSince;

	private static int nextId;

	public readonly int ID;

	private ServicePoint ServicePoint { get; set; }

	public int MaxIdleTime => 0;

	public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
	{
	}

	public void Run()
	{
	}

	[AsyncStateMachine(typeof(_003CRunScheduler_003Ed__32))]
	private Task RunScheduler()
	{
		return null;
	}

	private void Cleanup()
	{
	}

	private void RunSchedulerIteration()
	{
	}

	private bool OperationCompleted(ConnectionGroup group, WebOperation operation)
	{
		return false;
	}

	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection)
	{
	}

	private bool SchedulerIteration(ConnectionGroup group)
	{
		return false;
	}

	private void RemoveOperation(WebOperation operation)
	{
	}

	private void RemoveIdleConnection(WebConnection connection)
	{
	}

	private void FinalCleanup()
	{
	}

	public void SendRequest(WebOperation operation, string groupName)
	{
	}

	public bool CloseConnectionGroup(string groupName)
	{
		return false;
	}

	private ConnectionGroup GetConnectionGroup(string name)
	{
		return null;
	}

	private void OnConnectionCreated(WebConnection connection)
	{
	}

	private void OnConnectionClosed(WebConnection connection)
	{
	}

	[AsyncStateMachine(typeof(_003CWaitAsync_003Ed__46))]
	public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout)
	{
		return null;
	}
}
