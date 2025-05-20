using System.Collections.Generic;

namespace Unity.Properties;

public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>>
{
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty;

	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty;
}
