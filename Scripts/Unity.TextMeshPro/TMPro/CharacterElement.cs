namespace TMPro;

internal struct CharacterElement
{
	private uint m_Unicode;

	private TMP_TextElement m_TextElement;

	public uint Unicode
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public CharacterElement(TMP_TextElement textElement)
	{
		m_Unicode = 0u;
		m_TextElement = null;
	}
}
