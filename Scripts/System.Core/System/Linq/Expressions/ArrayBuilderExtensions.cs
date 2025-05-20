using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal static class ArrayBuilderExtensions
{
	public static ReadOnlyCollection<T> ToReadOnly<T>(this ArrayBuilder<T> builder)
	{
		return null;
	}
}
