using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	private IEnumerable<TSource> source;

	private Func<TSource, TKey> keySelector;

	private Func<TSource, TElement> elementSelector;

	private IEqualityComparer<TKey> comparer;

	public GroupedEnumerable(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
	}

	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
