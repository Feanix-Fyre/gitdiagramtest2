namespace System.Xml;

internal class ValidatingReaderNodeData
{
	private string localName;

	private string namespaceUri;

	private string prefix;

	private string nameWPrefix;

	private string rawValue;

	private string originalStringValue;

	private int depth;

	private AttributePSVIInfo attributePSVIInfo;

	private XmlNodeType nodeType;

	private int lineNo;

	private int linePos;

	public string LocalName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Namespace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Prefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Depth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string RawValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string OriginalStringValue => null;

	public XmlNodeType NodeType
	{
		get
		{
			return default(XmlNodeType);
		}
		set
		{
		}
	}

	public AttributePSVIInfo AttInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int LineNumber => 0;

	public int LinePosition => 0;

	public ValidatingReaderNodeData()
	{
	}

	public ValidatingReaderNodeData(XmlNodeType nodeType)
	{
	}

	public string GetAtomizedNameWPrefix(XmlNameTable nameTable)
	{
		return null;
	}

	internal void Clear(XmlNodeType nodeType)
	{
	}

	internal void SetLineInfo(int lineNo, int linePos)
	{
	}

	internal void SetLineInfo(IXmlLineInfo lineInfo)
	{
	}

	internal void SetItemData(string localName, string prefix, string ns, int depth)
	{
	}

	internal void SetItemData(string value)
	{
	}

	internal void SetItemData(string value, string originalStringValue)
	{
	}
}
