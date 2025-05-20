using System;

namespace UnityEngine.UIElements;

internal static class EnumFieldHelpers
{
	internal static readonly UxmlTypeAttributeDescription<Enum> type;

	internal static readonly UxmlStringAttributeDescription value;

	internal static readonly UxmlBoolAttributeDescription includeObsoleteValues;

	internal static bool ExtractValue(IUxmlAttributes bag, CreationContext cc, out Type resEnumType, out Enum resEnumValue, out bool resIncludeObsoleteValues)
	{
		resEnumType = null;
		resEnumValue = null;
		resIncludeObsoleteValues = default(bool);
		return false;
	}
}
