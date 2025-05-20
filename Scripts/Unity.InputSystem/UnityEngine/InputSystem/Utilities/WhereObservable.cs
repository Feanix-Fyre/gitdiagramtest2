using System;

namespace UnityEngine.InputSystem.Utilities;

internal class WhereObservable<TValue> : IObservable<TValue>
{
	private class Where : IObserver<TValue>
	{
		private WhereObservable<TValue> m_Observable;

		private readonly IObserver<TValue> m_Observer;

		public Where(WhereObservable<TValue> observable, IObserver<TValue> observer)
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

	private readonly IObservable<TValue> m_Source;

	private readonly Func<TValue, bool> m_Predicate;

	public WhereObservable(IObservable<TValue> source, Func<TValue, bool> predicate)
	{
	}

	public IDisposable Subscribe(IObserver<TValue> observer)
	{
		return null;
	}
}
