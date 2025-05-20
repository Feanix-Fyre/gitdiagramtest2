using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal static class GroupBoxUtility
{
	private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers;

	private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache;

	private static readonly Type k_GenericGroupBoxType;

	public static void RegisterGroupBoxOption<T>(this T option) where T : VisualElement, IGroupBoxOption
	{
	}

	public static void UnregisterGroupBoxOption<T>(this T option) where T : VisualElement, IGroupBoxOption
	{
	}

	public static void OnOptionSelected<T>(this T selectedOption) where T : VisualElement, IGroupBoxOption
	{
	}

	private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox)
	{
		return null;
	}

	private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt)
	{
	}

	private static void OnPanelDestroyed(BaseVisualElementPanel panel)
	{
	}
}
