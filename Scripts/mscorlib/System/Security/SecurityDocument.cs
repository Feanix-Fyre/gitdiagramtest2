namespace System.Security;

[Serializable]
internal sealed class SecurityDocument
{
	internal byte[] m_data;

	public SecurityDocument(int numData)
	{
	}

	public void GuaranteeSize(int size)
	{
	}

	public void AddString(string str, ref int position)
	{
	}

	public void AppendString(string str, ref int position)
	{
	}

	public static int EncodedStringSize(string str)
	{
		return 0;
	}

	public string GetString(ref int position, bool bCreate)
	{
		return null;
	}

	public void AddToken(byte b, ref int position)
	{
	}

	public SecurityElement GetRootElement()
	{
		return null;
	}

	public SecurityElement GetElement(int position, bool bCreate)
	{
		return null;
	}

	internal SecurityElement InternalGetElement(ref int position, bool bCreate)
	{
		return null;
	}
}
