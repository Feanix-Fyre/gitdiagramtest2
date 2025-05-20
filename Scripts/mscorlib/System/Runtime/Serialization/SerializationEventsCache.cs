using System.Collections.Concurrent;

namespace System.Runtime.Serialization;

internal static class SerializationEventsCache
{
	private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache;

	internal static SerializationEvents GetSerializationEventsForType(Type t)
	{
		return null;
	}
}
