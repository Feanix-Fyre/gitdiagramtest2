using System.Collections.Generic;

namespace Unity.Properties;

public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement>
{
	protected override InstantiationKind InstantiationKind => default(InstantiationKind);

	protected override HashSet<TElement> Instantiate()
	{
		return null;
	}
}
