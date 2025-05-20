using System.Collections.Generic;
using System.Text;

namespace System.Net.Http.Headers;

internal static class CollectionExtensions
{
	public static bool SequenceEqual<TSource>(this List<TSource> first, List<TSource> second)
	{
		return false;
	}

	public static void SetValue(this List<NameValueHeaderValue> parameters, string key, string value)
	{
	}

	public static string ToString<T>(this List<T> list)
	{
		return null;
	}

	public static void ToStringBuilder<T>(this List<T> list, StringBuilder sb)
	{
	}
}
