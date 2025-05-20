using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal static class VisualElementUtils
{
	private static readonly HashSet<string> s_usedNames;

	private static readonly Type s_FoldoutType;

	private static readonly string s_InspectorElementUssClassName;

	public static string GetUniqueName(string nameBase)
	{
		return null;
	}

	internal static int GetFoldoutDepth(this VisualElement element)
	{
		return 0;
	}

	internal static void AssignInspectorStyleIfNecessary(this VisualElement element, string classNameToEnable)
	{
	}
}
