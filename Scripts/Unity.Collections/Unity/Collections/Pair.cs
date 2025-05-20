namespace Unity.Collections;

internal struct Pair<Key, Value>
{
	public Key key;

	public Value value;

	public Pair(Key k, Value v)
	{
		key = default(Key);
		value = default(Value);
	}

	public override string ToString()
	{
		return null;
	}
}
