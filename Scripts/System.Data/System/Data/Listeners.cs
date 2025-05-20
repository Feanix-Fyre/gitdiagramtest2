using System.Collections.Generic;

namespace System.Data;

internal sealed class Listeners<TElem> where TElem : class
{
	internal delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	internal delegate TResult Func<T1, TResult>(T1 arg1);

	private readonly List<TElem> _listeners;

	private readonly Func<TElem, bool> _filter;

	private readonly int _objectID;

	private int _listenerReaderCount;

	internal bool HasListeners => false;

	internal Listeners(int ObjectID, Func<TElem, bool> notifyFilter)
	{
	}

	internal void Add(TElem listener)
	{
	}

	internal int IndexOfReference(TElem listener)
	{
		return 0;
	}

	internal void Remove(TElem listener)
	{
	}

	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Action<TElem, T1, T2, T3> action)
	{
	}

	private void RemoveNullListeners(int nullIndex)
	{
	}
}
