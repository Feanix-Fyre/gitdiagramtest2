using System.Collections.Concurrent;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class NameCache
{
	private static ConcurrentDictionary<string, object> ht;

	private string name;

	internal object GetCachedValue(string name)
	{
		return null;
	}

	internal void SetCachedValue(object value)
	{
	}
}
