using System;
using System.Collections.Generic;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Utilities;

public static class Observable
{
	public static IObservable<TValue> Where<TValue>(this IObservable<TValue> source, Func<TValue, bool> predicate)
	{
		return null;
	}

	public static IObservable<TResult> Select<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> filter)
	{
		return null;
	}

	public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter)
	{
		return null;
	}

	public static IObservable<TValue> Take<TValue>(this IObservable<TValue> source, int count)
	{
		return null;
	}

	public static IObservable<InputEventPtr> ForDevice(this IObservable<InputEventPtr> source, InputDevice device)
	{
		return null;
	}

	public static IObservable<InputEventPtr> ForDevice<TDevice>(this IObservable<InputEventPtr> source) where TDevice : InputDevice
	{
		return null;
	}

	public static IDisposable CallOnce<TValue>(this IObservable<TValue> source, Action<TValue> action)
	{
		return null;
	}

	public static IDisposable Call<TValue>(this IObservable<TValue> source, Action<TValue> action)
	{
		return null;
	}
}
