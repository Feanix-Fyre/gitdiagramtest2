using System.Collections;
using System.Data.Common;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace System.Data;

[Serializable]
internal sealed class SimpleType : ISerializable
{
	private string _baseType;

	private SimpleType _baseSimpleType;

	private XmlQualifiedName _xmlBaseType;

	private string _name;

	private int _length;

	private int _minLength;

	private int _maxLength;

	private string _pattern;

	private string _ns;

	private string _maxExclusive;

	private string _maxInclusive;

	private string _minExclusive;

	private string _minInclusive;

	internal string _enumeration;

	internal string BaseType => null;

	internal XmlQualifiedName XmlBaseType => null;

	internal string Name => null;

	internal string Namespace => null;

	internal int Length => 0;

	internal int MaxLength
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal SimpleType BaseSimpleType => null;

	public string SimpleTypeQualifiedName => null;

	internal SimpleType(string baseType)
	{
	}

	internal SimpleType(XmlSchemaSimpleType node)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal void LoadTypeValues(XmlSchemaSimpleType node)
	{
	}

	internal bool IsPlainString()
	{
		return false;
	}

	internal string QualifiedName(string name)
	{
		return null;
	}

	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting)
	{
		return null;
	}

	internal static SimpleType CreateEnumeratedType(string values)
	{
		return null;
	}

	internal static SimpleType CreateByteArrayType(string encoding)
	{
		return null;
	}

	internal static SimpleType CreateLimitedStringType(int length)
	{
		return null;
	}

	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type)
	{
		return null;
	}

	internal string HasConflictingDefinition(SimpleType otherSimpleType)
	{
		return null;
	}

	internal bool CanHaveMaxLength()
	{
		return false;
	}

	internal void ConvertToAnnonymousSimpleType()
	{
	}
}
