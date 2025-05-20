using System;
using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

internal class StyleMatchingContext
{
	private List<StyleSheet> m_StyleSheetStack;

	public StyleVariableContext variableContext;

	public VisualElement currentElement;

	public Action<VisualElement, MatchResultInfo> processResult;

	public AncestorFilter ancestorFilter;

	public int styleSheetCount => 0;

	public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult)
	{
	}

	public void AddStyleSheet(StyleSheet sheet)
	{
	}

	public void RemoveStyleSheetRange(int index, int count)
	{
	}

	public StyleSheet GetStyleSheetAt(int index)
	{
		return null;
	}
}
