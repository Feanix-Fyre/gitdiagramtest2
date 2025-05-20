using System.Collections.Generic;

namespace Unity.Properties;

public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IPropertyBag<TDictionary>, IPropertyBag where TDictionary : IDictionary<TKey, TValue>
{
	private class KeyValuePairProperty : Property<TDictionary, KeyValuePair<TKey, TValue>>
	{
		public override string Name => null;

		public TKey Key { get; }
	}

	private readonly KeyValuePairProperty m_KeyValuePairProperty;
}
