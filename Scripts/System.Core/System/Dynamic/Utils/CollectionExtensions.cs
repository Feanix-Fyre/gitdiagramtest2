using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils;

internal static class CollectionExtensions
{
	public static TrueReadOnlyCollection<T> AddFirst<T>(this ReadOnlyCollection<T> list, T item)
	{
		return null;
	}

	public static T[] AddLast<T>(this T[] array, T item)
	{
		return null;
	}

	public static T[] RemoveFirst<T>(this T[] array)
	{
		return null;
	}

	public static T[] RemoveLast<T>(this T[] array)
	{
		return null;
	}

	public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> enumerable)
	{
		return null;
	}
}
