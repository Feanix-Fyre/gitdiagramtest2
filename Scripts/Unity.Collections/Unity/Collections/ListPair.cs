using System.Collections;

namespace Unity.Collections;

internal struct ListPair<Key, Value> where Value : IList
{
	public Key key;

	public Value value;

	public ListPair(Key k, Value v)
	{
		key = default(Key);
		value = default(Value);
	}

	public override string ToString()
	{
		return null;
	}
}
