using System.Collections;

namespace System.Xml.Schema;

internal abstract class DatatypeImplementation : XmlSchemaDatatype
{
	private class SchemaDatatypeMap : IComparable
	{
		private string name;

		private DatatypeImplementation type;

		private int parentIndex;

		public string Name => null;

		public int ParentIndex => 0;

		internal SchemaDatatypeMap(string name, DatatypeImplementation type)
		{
		}

		internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
		{
		}

		public static explicit operator DatatypeImplementation(SchemaDatatypeMap sdm)
		{
			return null;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}
	}

	private XmlSchemaDatatypeVariety variety;

	private RestrictionFacets restriction;

	private DatatypeImplementation baseType;

	private XmlValueConverter valueConverter;

	private XmlSchemaType parentSchemaType;

	private static Hashtable builtinTypes;

	private static XmlSchemaSimpleType[] enumToTypeCode;

	private static XmlSchemaSimpleType anySimpleType;

	private static XmlSchemaSimpleType anyAtomicType;

	private static XmlSchemaSimpleType untypedAtomicType;

	private static XmlSchemaSimpleType yearMonthDurationType;

	private static XmlSchemaSimpleType dayTimeDurationType;

	private static XmlSchemaSimpleType normalizedStringTypeV1Compat;

	private static XmlSchemaSimpleType tokenTypeV1Compat;

	internal static XmlQualifiedName QnAnySimpleType;

	internal static XmlQualifiedName QnAnyType;

	internal static FacetsChecker stringFacetsChecker;

	internal static FacetsChecker miscFacetsChecker;

	internal static FacetsChecker numeric2FacetsChecker;

	internal static FacetsChecker binaryFacetsChecker;

	internal static FacetsChecker dateTimeFacetsChecker;

	internal static FacetsChecker durationFacetsChecker;

	internal static FacetsChecker listFacetsChecker;

	internal static FacetsChecker qnameFacetsChecker;

	internal static FacetsChecker unionFacetsChecker;

	private static readonly DatatypeImplementation c_anySimpleType;

	private static readonly DatatypeImplementation c_anyURI;

	private static readonly DatatypeImplementation c_base64Binary;

	private static readonly DatatypeImplementation c_boolean;

	private static readonly DatatypeImplementation c_byte;

	private static readonly DatatypeImplementation c_char;

	private static readonly DatatypeImplementation c_date;

	private static readonly DatatypeImplementation c_dateTime;

	private static readonly DatatypeImplementation c_dateTimeNoTz;

	private static readonly DatatypeImplementation c_dateTimeTz;

	private static readonly DatatypeImplementation c_day;

	private static readonly DatatypeImplementation c_decimal;

	private static readonly DatatypeImplementation c_double;

	private static readonly DatatypeImplementation c_doubleXdr;

	private static readonly DatatypeImplementation c_duration;

	private static readonly DatatypeImplementation c_ENTITY;

	private static readonly DatatypeImplementation c_ENTITIES;

	private static readonly DatatypeImplementation c_ENUMERATION;

	private static readonly DatatypeImplementation c_fixed;

	private static readonly DatatypeImplementation c_float;

	private static readonly DatatypeImplementation c_floatXdr;

	private static readonly DatatypeImplementation c_hexBinary;

	private static readonly DatatypeImplementation c_ID;

	private static readonly DatatypeImplementation c_IDREF;

	private static readonly DatatypeImplementation c_IDREFS;

	private static readonly DatatypeImplementation c_int;

	private static readonly DatatypeImplementation c_integer;

	private static readonly DatatypeImplementation c_language;

	private static readonly DatatypeImplementation c_long;

	private static readonly DatatypeImplementation c_month;

	private static readonly DatatypeImplementation c_monthDay;

	private static readonly DatatypeImplementation c_Name;

	private static readonly DatatypeImplementation c_NCName;

	private static readonly DatatypeImplementation c_negativeInteger;

	private static readonly DatatypeImplementation c_NMTOKEN;

	private static readonly DatatypeImplementation c_NMTOKENS;

	private static readonly DatatypeImplementation c_nonNegativeInteger;

	private static readonly DatatypeImplementation c_nonPositiveInteger;

	private static readonly DatatypeImplementation c_normalizedString;

	private static readonly DatatypeImplementation c_NOTATION;

	private static readonly DatatypeImplementation c_positiveInteger;

	private static readonly DatatypeImplementation c_QName;

	private static readonly DatatypeImplementation c_QNameXdr;

	private static readonly DatatypeImplementation c_short;

	private static readonly DatatypeImplementation c_string;

	private static readonly DatatypeImplementation c_time;

	private static readonly DatatypeImplementation c_timeNoTz;

	private static readonly DatatypeImplementation c_timeTz;

	private static readonly DatatypeImplementation c_token;

	private static readonly DatatypeImplementation c_unsignedByte;

	private static readonly DatatypeImplementation c_unsignedInt;

	private static readonly DatatypeImplementation c_unsignedLong;

	private static readonly DatatypeImplementation c_unsignedShort;

	private static readonly DatatypeImplementation c_uuid;

	private static readonly DatatypeImplementation c_year;

	private static readonly DatatypeImplementation c_yearMonth;

	internal static readonly DatatypeImplementation c_normalizedStringV1Compat;

	internal static readonly DatatypeImplementation c_tokenV1Compat;

	private static readonly DatatypeImplementation c_anyAtomicType;

	private static readonly DatatypeImplementation c_dayTimeDuration;

	private static readonly DatatypeImplementation c_untypedAtomicType;

	private static readonly DatatypeImplementation c_yearMonthDuration;

	private static readonly DatatypeImplementation[] c_tokenizedTypes;

	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd;

	private static readonly SchemaDatatypeMap[] c_XdrTypes;

	private static readonly SchemaDatatypeMap[] c_XsdTypes;

	internal static XmlSchemaSimpleType AnySimpleType => null;

	internal static XmlSchemaSimpleType UntypedAtomicType => null;

	internal override FacetsChecker FacetsChecker => null;

	internal override XmlValueConverter ValueConverter => null;

	public override XmlTokenizedType TokenizedType => default(XmlTokenizedType);

	public override Type ValueType => null;

	public override XmlSchemaDatatypeVariety Variety => default(XmlSchemaDatatypeVariety);

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override RestrictionFacets Restriction => null;

	internal override bool HasLexicalFacets => false;

	internal override bool HasValueFacets => false;

	protected DatatypeImplementation Base => null;

	internal abstract Type ListValueType { get; }

	internal abstract RestrictionFlags ValidRestrictionFlags { get; }

	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet => default(XmlSchemaWhiteSpace);

	static DatatypeImplementation()
	{
	}

	internal new static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
	{
		return null;
	}

	internal new static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token)
	{
		return null;
	}

	internal new static DatatypeImplementation FromXdrName(string name)
	{
		return null;
	}

	private static DatatypeImplementation FromTypeName(string name)
	{
		return null;
	}

	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
	{
		return null;
	}

	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
	{
	}

	internal static void CreateBuiltinTypes()
	{
	}

	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
	{
		return null;
	}

	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname)
	{
		return null;
	}

	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
	{
		return null;
	}

	internal static XmlSchemaSimpleType GetTokenTypeV1Compat()
	{
		return null;
	}

	internal static XmlSchemaSimpleType[] GetBuiltInTypes()
	{
		return null;
	}

	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode)
	{
		return default(XmlTypeCode);
	}

	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType)
	{
		return null;
	}

	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType)
	{
		return null;
	}

	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
	{
		return null;
	}

	internal new static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType)
	{
		return null;
	}

	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
	{
	}

	public override bool IsDerivedFrom(XmlSchemaDatatype datatype)
	{
		return false;
	}

	internal override bool IsEqual(object o1, object o2)
	{
		return false;
	}

	internal override bool IsComparable(XmlSchemaDatatype dtype)
	{
		return false;
	}

	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
	{
		return null;
	}

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
	{
		return null;
	}

	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue)
	{
		return null;
	}

	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue)
	{
		typedValue = null;
		return null;
	}

	internal string GetTypeName()
	{
		return null;
	}

	protected int Compare(byte[] value1, byte[] value2)
	{
		return 0;
	}
}
