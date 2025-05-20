namespace System.Xml.Schema;

internal sealed class SchemaNames
{
	public enum Token
	{
		Empty = 0,
		SchemaName = 1,
		SchemaType = 2,
		SchemaMaxOccurs = 3,
		SchemaMinOccurs = 4,
		SchemaInfinite = 5,
		SchemaModel = 6,
		SchemaOpen = 7,
		SchemaClosed = 8,
		SchemaContent = 9,
		SchemaMixed = 10,
		SchemaEmpty = 11,
		SchemaElementOnly = 12,
		SchemaTextOnly = 13,
		SchemaOrder = 14,
		SchemaSeq = 15,
		SchemaOne = 16,
		SchemaMany = 17,
		SchemaRequired = 18,
		SchemaYes = 19,
		SchemaNo = 20,
		SchemaString = 21,
		SchemaId = 22,
		SchemaIdref = 23,
		SchemaIdrefs = 24,
		SchemaEntity = 25,
		SchemaEntities = 26,
		SchemaNmtoken = 27,
		SchemaNmtokens = 28,
		SchemaEnumeration = 29,
		SchemaDefault = 30,
		XdrRoot = 31,
		XdrElementType = 32,
		XdrElement = 33,
		XdrGroup = 34,
		XdrAttributeType = 35,
		XdrAttribute = 36,
		XdrDatatype = 37,
		XdrDescription = 38,
		XdrExtends = 39,
		SchemaXdrRootAlias = 40,
		SchemaDtType = 41,
		SchemaDtValues = 42,
		SchemaDtMaxLength = 43,
		SchemaDtMinLength = 44,
		SchemaDtMax = 45,
		SchemaDtMin = 46,
		SchemaDtMinExclusive = 47,
		SchemaDtMaxExclusive = 48,
		SchemaTargetNamespace = 49,
		SchemaVersion = 50,
		SchemaFinalDefault = 51,
		SchemaBlockDefault = 52,
		SchemaFixed = 53,
		SchemaAbstract = 54,
		SchemaBlock = 55,
		SchemaSubstitutionGroup = 56,
		SchemaFinal = 57,
		SchemaNillable = 58,
		SchemaRef = 59,
		SchemaBase = 60,
		SchemaDerivedBy = 61,
		SchemaNamespace = 62,
		SchemaProcessContents = 63,
		SchemaRefer = 64,
		SchemaPublic = 65,
		SchemaSystem = 66,
		SchemaSchemaLocation = 67,
		SchemaValue = 68,
		SchemaSource = 69,
		SchemaAttributeFormDefault = 70,
		SchemaElementFormDefault = 71,
		SchemaUse = 72,
		SchemaForm = 73,
		XsdSchema = 74,
		XsdAnnotation = 75,
		XsdInclude = 76,
		XsdImport = 77,
		XsdElement = 78,
		XsdAttribute = 79,
		xsdAttributeGroup = 80,
		XsdAnyAttribute = 81,
		XsdGroup = 82,
		XsdAll = 83,
		XsdChoice = 84,
		XsdSequence = 85,
		XsdAny = 86,
		XsdNotation = 87,
		XsdSimpleType = 88,
		XsdComplexType = 89,
		XsdUnique = 90,
		XsdKey = 91,
		XsdKeyref = 92,
		XsdSelector = 93,
		XsdField = 94,
		XsdMinExclusive = 95,
		XsdMinInclusive = 96,
		XsdMaxExclusive = 97,
		XsdMaxInclusive = 98,
		XsdTotalDigits = 99,
		XsdFractionDigits = 100,
		XsdLength = 101,
		XsdMinLength = 102,
		XsdMaxLength = 103,
		XsdEnumeration = 104,
		XsdPattern = 105,
		XsdDocumentation = 106,
		XsdAppInfo = 107,
		XsdComplexContent = 108,
		XsdComplexContentExtension = 109,
		XsdComplexContentRestriction = 110,
		XsdSimpleContent = 111,
		XsdSimpleContentExtension = 112,
		XsdSimpleContentRestriction = 113,
		XsdSimpleTypeList = 114,
		XsdSimpleTypeRestriction = 115,
		XsdSimpleTypeUnion = 116,
		XsdWhitespace = 117,
		XsdRedefine = 118,
		SchemaItemType = 119,
		SchemaMemberTypes = 120,
		SchemaXPath = 121,
		XmlLang = 122
	}

	private XmlNameTable nameTable;

	public string NsDataType;

	public string NsDataTypeAlias;

	public string NsDataTypeOld;

	public string NsXml;

	public string NsXmlNs;

	public string NsXdr;

	public string NsXdrAlias;

	public string NsXs;

	public string NsXsi;

	public string XsiType;

	public string XsiNil;

	public string XsiSchemaLocation;

	public string XsiNoNamespaceSchemaLocation;

	public string XsdSchema;

	public string XdrSchema;

	public XmlQualifiedName QnPCData;

	public XmlQualifiedName QnXml;

	public XmlQualifiedName QnXmlNs;

	public XmlQualifiedName QnDtDt;

	public XmlQualifiedName QnXmlLang;

	public XmlQualifiedName QnName;

	public XmlQualifiedName QnType;

	public XmlQualifiedName QnMaxOccurs;

	public XmlQualifiedName QnMinOccurs;

	public XmlQualifiedName QnInfinite;

	public XmlQualifiedName QnModel;

	public XmlQualifiedName QnOpen;

	public XmlQualifiedName QnClosed;

	public XmlQualifiedName QnContent;

	public XmlQualifiedName QnMixed;

	public XmlQualifiedName QnEmpty;

	public XmlQualifiedName QnEltOnly;

	public XmlQualifiedName QnTextOnly;

	public XmlQualifiedName QnOrder;

	public XmlQualifiedName QnSeq;

	public XmlQualifiedName QnOne;

	public XmlQualifiedName QnMany;

	public XmlQualifiedName QnRequired;

	public XmlQualifiedName QnYes;

	public XmlQualifiedName QnNo;

	public XmlQualifiedName QnString;

	public XmlQualifiedName QnID;

	public XmlQualifiedName QnIDRef;

	public XmlQualifiedName QnIDRefs;

	public XmlQualifiedName QnEntity;

	public XmlQualifiedName QnEntities;

	public XmlQualifiedName QnNmToken;

	public XmlQualifiedName QnNmTokens;

	public XmlQualifiedName QnEnumeration;

	public XmlQualifiedName QnDefault;

	public XmlQualifiedName QnXdrSchema;

	public XmlQualifiedName QnXdrElementType;

	public XmlQualifiedName QnXdrElement;

	public XmlQualifiedName QnXdrGroup;

	public XmlQualifiedName QnXdrAttributeType;

	public XmlQualifiedName QnXdrAttribute;

	public XmlQualifiedName QnXdrDataType;

	public XmlQualifiedName QnXdrDescription;

	public XmlQualifiedName QnXdrExtends;

	public XmlQualifiedName QnXdrAliasSchema;

	public XmlQualifiedName QnDtType;

	public XmlQualifiedName QnDtValues;

	public XmlQualifiedName QnDtMaxLength;

	public XmlQualifiedName QnDtMinLength;

	public XmlQualifiedName QnDtMax;

	public XmlQualifiedName QnDtMin;

	public XmlQualifiedName QnDtMinExclusive;

	public XmlQualifiedName QnDtMaxExclusive;

	public XmlQualifiedName QnTargetNamespace;

	public XmlQualifiedName QnVersion;

	public XmlQualifiedName QnFinalDefault;

	public XmlQualifiedName QnBlockDefault;

	public XmlQualifiedName QnFixed;

	public XmlQualifiedName QnAbstract;

	public XmlQualifiedName QnBlock;

	public XmlQualifiedName QnSubstitutionGroup;

	public XmlQualifiedName QnFinal;

	public XmlQualifiedName QnNillable;

	public XmlQualifiedName QnRef;

	public XmlQualifiedName QnBase;

	public XmlQualifiedName QnDerivedBy;

	public XmlQualifiedName QnNamespace;

	public XmlQualifiedName QnProcessContents;

	public XmlQualifiedName QnRefer;

	public XmlQualifiedName QnPublic;

	public XmlQualifiedName QnSystem;

	public XmlQualifiedName QnSchemaLocation;

	public XmlQualifiedName QnValue;

	public XmlQualifiedName QnUse;

	public XmlQualifiedName QnForm;

	public XmlQualifiedName QnElementFormDefault;

	public XmlQualifiedName QnAttributeFormDefault;

	public XmlQualifiedName QnItemType;

	public XmlQualifiedName QnMemberTypes;

	public XmlQualifiedName QnXPath;

	public XmlQualifiedName QnXsdSchema;

	public XmlQualifiedName QnXsdAnnotation;

	public XmlQualifiedName QnXsdInclude;

	public XmlQualifiedName QnXsdImport;

	public XmlQualifiedName QnXsdElement;

	public XmlQualifiedName QnXsdAttribute;

	public XmlQualifiedName QnXsdAttributeGroup;

	public XmlQualifiedName QnXsdAnyAttribute;

	public XmlQualifiedName QnXsdGroup;

	public XmlQualifiedName QnXsdAll;

	public XmlQualifiedName QnXsdChoice;

	public XmlQualifiedName QnXsdSequence;

	public XmlQualifiedName QnXsdAny;

	public XmlQualifiedName QnXsdNotation;

	public XmlQualifiedName QnXsdSimpleType;

	public XmlQualifiedName QnXsdComplexType;

	public XmlQualifiedName QnXsdUnique;

	public XmlQualifiedName QnXsdKey;

	public XmlQualifiedName QnXsdKeyRef;

	public XmlQualifiedName QnXsdSelector;

	public XmlQualifiedName QnXsdField;

	public XmlQualifiedName QnXsdMinExclusive;

	public XmlQualifiedName QnXsdMinInclusive;

	public XmlQualifiedName QnXsdMaxInclusive;

	public XmlQualifiedName QnXsdMaxExclusive;

	public XmlQualifiedName QnXsdTotalDigits;

	public XmlQualifiedName QnXsdFractionDigits;

	public XmlQualifiedName QnXsdLength;

	public XmlQualifiedName QnXsdMinLength;

	public XmlQualifiedName QnXsdMaxLength;

	public XmlQualifiedName QnXsdEnumeration;

	public XmlQualifiedName QnXsdPattern;

	public XmlQualifiedName QnXsdDocumentation;

	public XmlQualifiedName QnXsdAppinfo;

	public XmlQualifiedName QnSource;

	public XmlQualifiedName QnXsdComplexContent;

	public XmlQualifiedName QnXsdSimpleContent;

	public XmlQualifiedName QnXsdRestriction;

	public XmlQualifiedName QnXsdExtension;

	public XmlQualifiedName QnXsdUnion;

	public XmlQualifiedName QnXsdList;

	public XmlQualifiedName QnXsdWhiteSpace;

	public XmlQualifiedName QnXsdRedefine;

	public XmlQualifiedName QnXsdAnyType;

	internal XmlQualifiedName[] TokenToQName;

	public SchemaNames(XmlNameTable nameTable)
	{
	}

	public void CreateTokenToQNameTable()
	{
	}

	public SchemaType SchemaTypeFromRoot(string localName, string ns)
	{
		return default(SchemaType);
	}

	public bool IsXSDRoot(string localName, string ns)
	{
		return false;
	}

	public bool IsXDRRoot(string localName, string ns)
	{
		return false;
	}
}
