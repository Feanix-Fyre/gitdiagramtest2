using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> where T : VisualElement
{
	private List<StyleSelector> m_StyleSelectors;

	private List<StyleSelectorPart> m_Parts;

	private VisualElement m_Element;

	private List<RuleMatcher> m_Matchers;

	private StyleSelectorRelationship m_Relationship;

	private int pseudoStatesMask;

	private int negatedPseudoStatesMask;

	private List<StyleSelector> styleSelectors => null;

	private List<StyleSelectorPart> parts => null;

	public UQueryBuilder(VisualElement visualElement)
	{
		m_StyleSelectors = null;
		m_Parts = null;
		m_Element = null;
		m_Matchers = null;
		m_Relationship = default(StyleSelectorRelationship);
		pseudoStatesMask = 0;
		negatedPseudoStatesMask = 0;
	}

	public UQueryBuilder<T> Class(string classname)
	{
		return default(UQueryBuilder<T>);
	}

	public UQueryBuilder<T> Name(string id)
	{
		return default(UQueryBuilder<T>);
	}

	internal UQueryBuilder<T> SingleBaseType()
	{
		return default(UQueryBuilder<T>);
	}

	private void AddClass(string c)
	{
	}

	private void AddName(string id)
	{
	}

	private void AddPseudoStatesRuleIfNecessasy()
	{
	}

	private void FinishSelector()
	{
	}

	private bool CurrentSelectorEmpty()
	{
		return false;
	}

	private void FinishCurrentSelector()
	{
	}

	public UQueryState<T> Build()
	{
		return default(UQueryState<T>);
	}

	public bool Equals(UQueryBuilder<T> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
