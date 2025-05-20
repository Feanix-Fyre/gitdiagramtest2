using System;

namespace UnityEngine.InputSystem.Utilities;

internal class TakeNObservable<TValue> : IObservable<TValue>
{
	private class Take : IObserver<TValue>
	{
		private IObserver<TValue> m_Observer;

		private int m_Remaining;

		public Take(TakeNObservable<TValue> observable, IObserver<TValue> observer)
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

	private IObservable<TValue> m_Source;

	private int m_Count;

	public TakeNObservable(IObservable<TValue> source, int count)
	{
	}

	public IDisposable Subscribe(IObserver<TValue> observer)
	{
		return null;
	}
}
