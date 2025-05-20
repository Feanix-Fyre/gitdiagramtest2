using System;
using System.Reflection;

namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet>
{
	private readonly VisualElement m_Element;

	internal VisualElementStyleSheetSet(VisualElement element)
	{
		m_Element = null;
	}

	public void Add(StyleSheet styleSheet)
	{
	}

	public bool Remove(StyleSheet styleSheet)
	{
		return false;
	}

	public bool Equals(VisualElementStyleSheetSet other)
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
