using System.Collections.Generic;

namespace System.Xml.Schema;

internal abstract class SchemaDeclBase
{
	internal enum Use
	{
		Default = 0,
		Required = 1,
		Implied = 2,
		Fixed = 3,
		RequiredFixed = 4
	}

	protected XmlQualifiedName name;

	protected string prefix;

	protected bool isDeclaredInExternal;

	protected Use presence;

	protected XmlSchemaType schemaType;

	protected XmlSchemaDatatype datatype;

	protected string defaultValueRaw;

	protected object defaultValueTyped;

	protected long maxLength;

	protected long minLength;

	protected List<string> values;

	internal XmlQualifiedName Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string Prefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool IsDeclaredInExternal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal Use Presence
	{
		get
		{
			return default(Use);
		}
		set
		{
		}
	}

	internal long MaxLength
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	internal long MinLength
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	internal XmlSchemaType SchemaType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal XmlSchemaDatatype Datatype
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal List<string> Values
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string DefaultValueRaw
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal object DefaultValueTyped
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected SchemaDeclBase(XmlQualifiedName name, string prefix)
	{
	}

	protected SchemaDeclBase()
	{
	}

	internal void AddValue(string value)
	{
	}

	internal bool CheckEnumeration(object pVal)
	{
		return false;
	}

	internal bool CheckValue(object pVal)
	{
		return false;
	}
}
