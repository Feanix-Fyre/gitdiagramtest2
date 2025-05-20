using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets;

internal static class StylePropertyUtil
{
	internal static readonly Dictionary<string, StylePropertyId> s_NameToId;

	internal static readonly Dictionary<StylePropertyId, string> s_IdToName;

	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties;

	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties;

	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue)
	{
		intValue = default(int);
		return false;
	}

	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id)
	{
		return false;
	}

	public static bool IsAnimatable(StylePropertyId id)
	{
		return false;
	}
}
