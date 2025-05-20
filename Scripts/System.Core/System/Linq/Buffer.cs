using System.Collections.Generic;

namespace System.Linq;

internal struct Buffer<TElement>
{
	internal TElement[] items;

	internal int count;

	internal Buffer(IEnumerable<TElement> source)
	{
		items = null;
		count = 0;
	}

	internal TElement[] ToArray()
	{
		return null;
	}
}
