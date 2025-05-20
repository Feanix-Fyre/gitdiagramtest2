namespace System.Xml.Schema;

internal sealed class SchemaEntity : IDtdEntityInfo
{
	private XmlQualifiedName qname;

	private string url;

	private string pubid;

	private string text;

	private XmlQualifiedName ndata;

	private int lineNumber;

	private int linePosition;

	private bool isParameter;

	private bool isExternal;

	private bool parsingInProgress;

	private bool isDeclaredInExternal;

	private string baseURI;

	private string declaredURI;

	string IDtdEntityInfo.Name => null;

	bool IDtdEntityInfo.IsExternal => false;

	bool IDtdEntityInfo.IsDeclaredInExternal => false;

	bool IDtdEntityInfo.IsUnparsedEntity => false;

	bool IDtdEntityInfo.IsParameterEntity => false;

	string IDtdEntityInfo.BaseUriString => null;

	string IDtdEntityInfo.DeclaredUriString => null;

	string IDtdEntityInfo.SystemId => null;

	string IDtdEntityInfo.PublicId => null;

	string IDtdEntityInfo.Text => null;

	int IDtdEntityInfo.LineNumber => 0;

	int IDtdEntityInfo.LinePosition => 0;

	internal XmlQualifiedName Name => null;

	internal string Url
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string Pubid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool IsExternal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool DeclaredInExternal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal XmlQualifiedName NData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal int Line
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int Pos
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal string BaseURI
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool ParsingInProgress
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal string DeclaredURI
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal SchemaEntity(XmlQualifiedName qname, bool isParameter)
	{
	}

	internal static bool IsPredefinedEntity(string n)
	{
		return false;
	}
}
