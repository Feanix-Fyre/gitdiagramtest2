using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets;

internal static class StyleSheetCache
{
	private struct SheetHandleKey
	{
		public readonly int sheetInstanceID;

		public readonly int index;

		public SheetHandleKey(StyleSheet sheet, int index)
		{
			sheetInstanceID = 0;
			this.index = 0;
		}
	}

	private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey>
	{
		public bool Equals(SheetHandleKey x, SheetHandleKey y)
		{
			return false;
		}

		public int GetHashCode(SheetHandleKey key)
		{
			return 0;
		}
	}

	private static SheetHandleKeyComparer s_Comparer;

	private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache;

	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex)
	{
		return null;
	}

	internal static StylePropertyId[] GetPropertyIds(StyleRule rule)
	{
		return null;
	}

	private static StylePropertyId GetPropertyId(StyleRule rule, int index)
	{
		return default(StylePropertyId);
	}
}
