using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
{
	private StyleVariableContext m_ProcessVarContext;

	private HashSet<VisualElement> m_UpdateList;

	private HashSet<VisualElement> m_ParentList;

	private List<SelectorMatchRecord> m_TempMatchResults;

	private StyleMatchingContext m_StyleMatchingContext;

	private StylePropertyReader m_StylePropertyReader;

	private readonly List<StylePropertyId> m_AnimatedProperties;

	private float currentPixelsPerPoint { get; set; }

	public void PrepareTraversal(float pixelsPerPoint)
	{
	}

	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	public void Clear()
	{
	}

	private void PropagateToChildren(VisualElement ve)
	{
	}

	private void PropagateToParents(VisualElement ve)
	{
	}

	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info)
	{
	}

	public override void TraverseRecursive(VisualElement element, int depth)
	{
	}

	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle)
	{
	}

	private void ForceUpdateTransitions(VisualElement element)
	{
	}

	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle)
	{
	}

	protected bool ShouldSkipElement(VisualElement element)
	{
		return false;
	}

	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors)
	{
		return default(ComputedStyle);
	}

	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule)
	{
	}
}
