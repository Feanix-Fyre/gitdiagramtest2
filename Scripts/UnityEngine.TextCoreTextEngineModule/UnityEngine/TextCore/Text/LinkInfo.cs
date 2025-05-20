namespace UnityEngine.TextCore.Text;

internal struct LinkInfo
{
	public int hashCode;

	public int linkIdFirstCharacterIndex;

	public int linkIdLength;

	public int linkTextfirstCharacterIndex;

	public int linkTextLength;

	internal char[] linkId;

	private string m_LinkIdString;

	private string m_LinkTextString;

	internal void SetLinkId(char[] text, int startIndex, int length)
	{
	}

	public string GetLinkText(TextInfo textInfo)
	{
		return null;
	}

	public string GetLinkId()
	{
		return null;
	}
}
