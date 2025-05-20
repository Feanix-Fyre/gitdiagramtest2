using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

/// <summary>Represents a collection of objects that have a common key.</summary>
/// <typeparam name="TKey">The type of the key of the <see cref="T:System.Linq.IGrouping`2" />.</typeparam>
/// <typeparam name="TElement">The type of the values in the <see cref="T:System.Linq.IGrouping`2" />.</typeparam>
public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
{
	/// <summary>Gets the key of the <see cref="T:System.Linq.IGrouping`2" />.</summary>
	/// <returns>The key of the <see cref="T:System.Linq.IGrouping`2" />.</returns>
	TKey Key { get; }
}
