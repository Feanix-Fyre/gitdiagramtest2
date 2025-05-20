using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

internal class StyleValueCollection
{
	internal List<StyleValue> m_Values;

	public StyleLength GetStyleLength(StylePropertyId id)
	{
		return default(StyleLength);
	}

	public StyleFloat GetStyleFloat(StylePropertyId id)
	{
		return default(StyleFloat);
	}

	public StyleInt GetStyleInt(StylePropertyId id)
	{
		return default(StyleInt);
	}

	public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value)
	{
		return false;
	}

	public void SetStyleValue(StyleValue value)
	{
	}
}
