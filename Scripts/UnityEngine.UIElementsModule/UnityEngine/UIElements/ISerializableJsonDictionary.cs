namespace UnityEngine.UIElements;

internal interface ISerializableJsonDictionary
{
	void Set<T>(string key, T value) where T : class;

	T Get<T>(string key) where T : class;

	void Overwrite(object obj, string key);

	bool ContainsKey(string key);
}
