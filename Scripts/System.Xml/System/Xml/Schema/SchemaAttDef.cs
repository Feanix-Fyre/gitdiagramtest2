namespace System.Xml.Schema;

internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo
{
	internal enum Reserve
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2
	}

	private string defExpanded;

	private int lineNum;

	private int linePos;

	private int valueLineNum;

	private int valueLinePos;

	private Reserve reserved;

	private bool defaultValueChecked;

	private XmlSchemaAttribute schemaAttribute;

	public static readonly SchemaAttDef Empty;

	string IDtdAttributeInfo.Prefix => null;

	string IDtdAttributeInfo.LocalName => null;

	int IDtdAttributeInfo.LineNumber => 0;

	int IDtdAttributeInfo.LinePosition => 0;

	bool IDtdAttributeInfo.IsNonCDataType => false;

	bool IDtdAttributeInfo.IsDeclaredInExternal => false;

	bool IDtdAttributeInfo.IsXmlAttribute => false;

	string IDtdDefaultAttributeInfo.DefaultValueExpanded => null;

	object IDtdDefaultAttributeInfo.DefaultValueTyped => null;

	int IDtdDefaultAttributeInfo.ValueLineNumber => 0;

	int IDtdDefaultAttributeInfo.ValueLinePosition => 0;

	internal int LinePosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int LineNumber
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int ValueLinePosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int ValueLineNumber
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal string DefaultValueExpanded
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal XmlTokenizedType TokenizedType
	{
		get
		{
			return default(XmlTokenizedType);
		}
		set
		{
		}
	}

	internal Reserve Reserved
	{
		get
		{
			return default(Reserve);
		}
		set
		{
		}
	}

	internal bool DefaultValueChecked => false;

	internal XmlSchemaAttribute SchemaAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SchemaAttDef(XmlQualifiedName name, string prefix)
		: base(null, null)
	{
	}

	public SchemaAttDef(XmlQualifiedName name)
		: base(null, null)
	{
	}

	private SchemaAttDef()
		: base(null, null)
	{
	}

	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling)
	{
	}

	internal SchemaAttDef Clone()
	{
		return null;
	}
}
