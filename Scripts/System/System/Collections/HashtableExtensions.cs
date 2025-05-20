namespace System.Collections;

internal static class HashtableExtensions
{
	public static bool TryGetValue<T>(this Hashtable table, object key, out T value)
	{
		value = default(T);
		return false;
	}
}
