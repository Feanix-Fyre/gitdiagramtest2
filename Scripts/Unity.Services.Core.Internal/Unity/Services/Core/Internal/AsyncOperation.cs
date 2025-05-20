using System;
using System.Collections;

namespace Unity.Services.Core.Internal;

internal class AsyncOperation : IAsyncOperation, IEnumerator
{
	protected Action<IAsyncOperation> m_CompletedCallback;

	public bool IsDone { get; protected set; }

	public AsyncOperationStatus Status { get; protected set; }

	public Exception Exception { get; protected set; }

	object IEnumerator.Current => null;

	public event Action<IAsyncOperation> Completed
	{
		add
		{
		}
		remove
		{
		}
	}

	public void SetInProgress()
	{
	}

	public void Succeed()
	{
	}

	public void Fail(Exception reason)
	{
	}

	public void Cancel()
	{
	}

	bool IEnumerator.MoveNext()
	{
		return false;
	}

	void IEnumerator.Reset()
	{
	}
}
internal class AsyncOperation<T> : IAsyncOperation<T>, IEnumerator
{
	protected Action<IAsyncOperation<T>> m_CompletedCallback;

	public bool IsDone { get; protected set; }

	public AsyncOperationStatus Status { get; protected set; }

	public Exception Exception { get; protected set; }

	public T Result { get; protected set; }

	object IEnumerator.Current => null;

	public event Action<IAsyncOperation<T>> Completed
	{
		add
		{
		}
		remove
		{
		}
	}

	public void SetInProgress()
	{
	}

	public void Succeed(T result)
	{
	}

	public void Fail(Exception reason)
	{
	}

	public void Cancel()
	{
	}

	bool IEnumerator.MoveNext()
	{
		return false;
	}

	void IEnumerator.Reset()
	{
	}
}
