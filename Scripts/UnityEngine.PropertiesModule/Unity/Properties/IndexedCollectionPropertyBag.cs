using System.Collections.Generic;

namespace Unity.Properties;

public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>, IPropertyBag<TList>, IPropertyBag, IConstructorWithCount<TList>, IConstructor where TList : IList<TElement>
{
	private class ListElementProperty : Property<TList, TElement>
	{
		internal int m_Index;

		public int Index => 0;

		public override string Name => null;
	}

	private readonly ListElementProperty m_Property;

	TList IConstructorWithCount<TList>.InstantiateWithCount(int count)
	{
		return default(TList);
	}

	protected virtual TList InstantiateWithCount(int count)
	{
		return default(TList);
	}
}
