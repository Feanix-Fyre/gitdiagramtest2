using System;

namespace UnityEngine.InputSystem.Utilities;

internal class Observer<TValue> : IObserver<TValue>
{
	private Action<TValue> m_OnNext;

	private Action m_OnCompleted;

	public Observer(Action<TValue> onNext, Action onCompleted = null)
	{
	}

	public void OnCompleted()
	{
	}

	public void OnError(Exception error)
	{
	}

	public void OnNext(TValue evt)
	{
	}
}
