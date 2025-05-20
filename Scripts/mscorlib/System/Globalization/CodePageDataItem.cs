namespace System.Globalization;

[Serializable]
internal class CodePageDataItem
{
	internal int m_dataIndex;

	internal int m_uiFamilyCodePage;

	internal string m_webName;

	internal string m_headerName;

	internal string m_bodyName;

	internal uint m_flags;

	private static readonly char[] sep;

	public string WebName => null;

	public string HeaderName => null;

	internal CodePageDataItem(int dataIndex)
	{
	}

	internal static string CreateString(string pStrings, uint index)
	{
		return null;
	}
}
