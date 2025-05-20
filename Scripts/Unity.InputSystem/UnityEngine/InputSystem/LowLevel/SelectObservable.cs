using System;

namespace UnityEngine.InputSystem.LowLevel;

internal class SelectObservable<TSource, TResult> : IObservable<TResult>
{
	private class Select : IObserver<TSource>
	{
		private SelectObservable<TSource, TResult> m_Observable;

		private readonly IObserver<TResult> m_Observer;

		public Select(SelectObservable<TSource, TResult> observable, IObserver<TResult> observer)
		{
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(TSource evt)
		{
		}
	}

	private readonly IObservable<TSource> m_Source;

	private readonly Func<TSource, TResult> m_Filter;

	public SelectObservable(IObservable<TSource> source, Func<TSource, TResult> filter)
	{
	}

	public IDisposable Subscribe(IObserver<TResult> observer)
	{
		return null;
	}
}
