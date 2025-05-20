using System.Collections.Generic;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements;

internal static class StyleValueExtensions
{
	internal static string DebugString<T>(this IStyleValue<T> styleValue)
	{
		return null;
	}

	internal static YogaValue ToYogaValue(this Length length)
	{
		return default(YogaValue);
	}

	internal static Length ToLength(this StyleKeyword keyword)
	{
		return default(Length);
	}

	internal static Rotate ToRotate(this StyleKeyword keyword)
	{
		return default(Rotate);
	}

	internal static Scale ToScale(this StyleKeyword keyword)
	{
		return default(Scale);
	}

	internal static Translate ToTranslate(this StyleKeyword keyword)
	{
		return default(Translate);
	}

	internal static Length ToLength(this StyleLength styleLength)
	{
		return default(Length);
	}

	internal static void CopyFrom<T>(this List<T> list, List<T> other)
	{
	}
}
