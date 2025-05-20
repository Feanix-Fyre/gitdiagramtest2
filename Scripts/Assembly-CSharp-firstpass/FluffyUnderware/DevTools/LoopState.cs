using System;
using System.Collections.Generic;

namespace FluffyUnderware.DevTools;

internal class LoopState<T>
{
	public short StartIndex { get; private set; }

	public short EndIndex { get; private set; }

	public IEnumerable<T> Items { get; private set; }

	public int ItemsCount { get; private set; }

	public Action<T, int, int> Action { get; private set; }

	public LoopState()
	{
	}

	public LoopState(short startIndex, short endIndex, IEnumerable<T> items, int itemsCount, Action<T, int, int> action)
	{
	}

	public void Set(short startIndex, short endIndex, IEnumerable<T> items, int itemsCount, Action<T, int, int> action)
	{
	}
}
