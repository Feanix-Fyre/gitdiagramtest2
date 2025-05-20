using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Core.Internal;

internal class TaskAsyncOperation : AsyncOperationBase, INotifyCompletion
{
	internal static TaskScheduler Scheduler;

	private Task m_Task;

	public override bool IsCompleted => false;

	public override AsyncOperationStatus Status => default(AsyncOperationStatus);

	public override Exception Exception => null;

	public override void GetResult()
	{
	}

	public override AsyncOperationBase GetAwaiter()
	{
		return null;
	}

	public TaskAsyncOperation(Task task)
	{
	}

	public static TaskAsyncOperation Run(Action action)
	{
		return null;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	internal static void SetScheduler()
	{
	}
}
internal class TaskAsyncOperation<T> : AsyncOperationBase<T>
{
	private Task<T> m_Task;

	public override bool IsCompleted => false;

	public override T Result => default(T);

	public override AsyncOperationStatus Status => default(AsyncOperationStatus);

	public override Exception Exception => null;

	public override T GetResult()
	{
		return default(T);
	}

	public override AsyncOperationBase<T> GetAwaiter()
	{
		return null;
	}

	public TaskAsyncOperation(Task<T> task)
	{
	}

	public static TaskAsyncOperation<T> Run(Func<T> func)
	{
		return null;
	}
}
