using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

[Serializable]
public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V>
{
	public override K SerializeKey(K key)
	{
		return default(K);
	}

	public override V SerializeValue(V val)
	{
		return default(V);
	}

	public override K DeserializeKey(K key)
	{
		return default(K);
	}

	public override V DeserializeValue(V val)
	{
		return default(V);
	}
}
[Serializable]
public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver
{
	[SerializeField]
	private List<SK> m_Keys;

	[SerializeField]
	private List<SV> m_Values;

	public abstract SK SerializeKey(K key);

	public abstract SV SerializeValue(V value);

	public abstract K DeserializeKey(SK serializedKey);

	public abstract V DeserializeValue(SV serializedValue);

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
