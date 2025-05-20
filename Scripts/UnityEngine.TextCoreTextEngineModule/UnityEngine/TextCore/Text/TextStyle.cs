using System;

namespace UnityEngine.TextCore.Text;

[Serializable]
public class TextStyle
{
	internal static TextStyle k_NormalStyle;

	[SerializeField]
	private string m_Name;

	[SerializeField]
	private int m_HashCode;

	[SerializeField]
	private string m_OpeningDefinition;

	[SerializeField]
	private string m_ClosingDefinition;

	[SerializeField]
	private uint[] m_OpeningTagArray;

	[SerializeField]
	private uint[] m_ClosingTagArray;

	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray;

	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray;

	public int hashCode => 0;

	public uint[] styleOpeningTagArray => null;

	public uint[] styleClosingTagArray => null;

	internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
	{
	}

	public void RefreshStyle()
	{
	}
}
