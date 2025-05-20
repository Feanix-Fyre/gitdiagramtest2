using System;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

internal class SelectManyObservable<TSource, TResult> : IObservable<TResult>
{
	private class Select : IObserver<TSource>
	{
		private SelectManyObservable<TSource, TResult> m_Observable;

		private readonly IObserver<TResult> m_Observer;

		public Select(SelectManyObservable<TSource, TResult> observable, IObserver<TResult> observer)
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

	private readonly Func<TSource, IEnumerable<TResult>> m_Filter;

	public SelectManyObservable(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter)
	{
	}

	public IDisposable Subscribe(IObserver<TResult> observer)
	{
		return null;
	}
}
