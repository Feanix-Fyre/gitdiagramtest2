using System;
using System.Collections.Generic;

namespace UnityEngine.TextCore.Text;

[Serializable]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
public class TextStyleSheet : ScriptableObject
{
	[SerializeField]
	private List<TextStyle> m_StyleList;

	private Dictionary<int, TextStyle> m_StyleLookupDictionary;

	internal List<TextStyle> styles => null;

	private void Reset()
	{
	}

	public TextStyle GetStyle(int hashCode)
	{
		return null;
	}

	public TextStyle GetStyle(string name)
	{
		return null;
	}

	public void RefreshStyles()
	{
	}

	private void LoadStyleDictionaryInternal()
	{
	}
}
