using System.Collections.Generic;

namespace Unity.Properties;

public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement>
{
	protected override InstantiationKind InstantiationKind => default(InstantiationKind);

	protected override List<TElement> InstantiateWithCount(int count)
	{
		return null;
	}

	protected override List<TElement> Instantiate()
	{
		return null;
	}
}
