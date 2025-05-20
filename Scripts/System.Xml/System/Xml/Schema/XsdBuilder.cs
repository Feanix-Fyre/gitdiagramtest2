using System.Collections;

namespace System.Xml.Schema;

internal sealed class XsdBuilder : SchemaBuilder
{
	private enum State
	{
		Root = 0,
		Schema = 1,
		Annotation = 2,
		Include = 3,
		Import = 4,
		Element = 5,
		Attribute = 6,
		AttributeGroup = 7,
		AttributeGroupRef = 8,
		AnyAttribute = 9,
		Group = 10,
		GroupRef = 11,
		All = 12,
		Choice = 13,
		Sequence = 14,
		Any = 15,
		Notation = 16,
		SimpleType = 17,
		ComplexType = 18,
		ComplexContent = 19,
		ComplexContentRestriction = 20,
		ComplexContentExtension = 21,
		SimpleContent = 22,
		SimpleContentExtension = 23,
		SimpleContentRestriction = 24,
		SimpleTypeUnion = 25,
		SimpleTypeList = 26,
		SimpleTypeRestriction = 27,
		Unique = 28,
		Key = 29,
		KeyRef = 30,
		Selector = 31,
		Field = 32,
		MinExclusive = 33,
		MinInclusive = 34,
		MaxExclusive = 35,
		MaxInclusive = 36,
		TotalDigits = 37,
		FractionDigits = 38,
		Length = 39,
		MinLength = 40,
		MaxLength = 41,
		Enumeration = 42,
		Pattern = 43,
		WhiteSpace = 44,
		AppInfo = 45,
		Documentation = 46,
		Redefine = 47
	}

	private delegate void XsdBuildFunction(XsdBuilder builder, string value);

	private delegate void XsdInitFunction(XsdBuilder builder, string value);

	private delegate void XsdEndChildFunction(XsdBuilder builder);

	private sealed class XsdAttributeEntry
	{
		public SchemaNames.Token Attribute;

		public XsdBuildFunction BuildFunc;

		public XsdAttributeEntry(SchemaNames.Token a, XsdBuildFunction build)
		{
		}
	}

	private sealed class XsdEntry
	{
		public SchemaNames.Token Name;

		public State CurrentState;

		public State[] NextStates;

		public XsdAttributeEntry[] Attributes;

		public XsdInitFunction InitFunc;

		public XsdEndChildFunction EndChildFunc;

		public bool ParseContent;

		public XsdEntry(SchemaNames.Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent)
		{
		}
	}

	private class BuilderNamespaceManager : XmlNamespaceManager
	{
		private XmlNamespaceManager nsMgr;

		private XmlReader reader;

		public BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader)
		{
		}

		public override string LookupNamespace(string prefix)
		{
			return null;
		}
	}

	private static readonly State[] SchemaElement;

	private static readonly State[] SchemaSubelements;

	private static readonly State[] AttributeSubelements;

	private static readonly State[] ElementSubelements;

	private static readonly State[] ComplexTypeSubelements;

	private static readonly State[] SimpleContentSubelements;

	private static readonly State[] SimpleContentExtensionSubelements;

	private static readonly State[] SimpleContentRestrictionSubelements;

	private static readonly State[] ComplexContentSubelements;

	private static readonly State[] ComplexContentExtensionSubelements;

	private static readonly State[] ComplexContentRestrictionSubelements;

	private static readonly State[] SimpleTypeSubelements;

	private static readonly State[] SimpleTypeRestrictionSubelements;

	private static readonly State[] SimpleTypeListSubelements;

	private static readonly State[] SimpleTypeUnionSubelements;

	private static readonly State[] RedefineSubelements;

	private static readonly State[] AttributeGroupSubelements;

	private static readonly State[] GroupSubelements;

	private static readonly State[] AllSubelements;

	private static readonly State[] ChoiceSequenceSubelements;

	private static readonly State[] IdentityConstraintSubelements;

	private static readonly State[] AnnotationSubelements;

	private static readonly State[] AnnotatedSubelements;

	private static readonly XsdAttributeEntry[] SchemaAttributes;

	private static readonly XsdAttributeEntry[] AttributeAttributes;

	private static readonly XsdAttributeEntry[] ElementAttributes;

	private static readonly XsdAttributeEntry[] ComplexTypeAttributes;

	private static readonly XsdAttributeEntry[] SimpleContentAttributes;

	private static readonly XsdAttributeEntry[] SimpleContentExtensionAttributes;

	private static readonly XsdAttributeEntry[] SimpleContentRestrictionAttributes;

	private static readonly XsdAttributeEntry[] ComplexContentAttributes;

	private static readonly XsdAttributeEntry[] ComplexContentExtensionAttributes;

	private static readonly XsdAttributeEntry[] ComplexContentRestrictionAttributes;

	private static readonly XsdAttributeEntry[] SimpleTypeAttributes;

	private static readonly XsdAttributeEntry[] SimpleTypeRestrictionAttributes;

	private static readonly XsdAttributeEntry[] SimpleTypeUnionAttributes;

	private static readonly XsdAttributeEntry[] SimpleTypeListAttributes;

	private static readonly XsdAttributeEntry[] AttributeGroupAttributes;

	private static readonly XsdAttributeEntry[] AttributeGroupRefAttributes;

	private static readonly XsdAttributeEntry[] GroupAttributes;

	private static readonly XsdAttributeEntry[] GroupRefAttributes;

	private static readonly XsdAttributeEntry[] ParticleAttributes;

	private static readonly XsdAttributeEntry[] AnyAttributes;

	private static readonly XsdAttributeEntry[] IdentityConstraintAttributes;

	private static readonly XsdAttributeEntry[] SelectorAttributes;

	private static readonly XsdAttributeEntry[] FieldAttributes;

	private static readonly XsdAttributeEntry[] NotationAttributes;

	private static readonly XsdAttributeEntry[] IncludeAttributes;

	private static readonly XsdAttributeEntry[] ImportAttributes;

	private static readonly XsdAttributeEntry[] FacetAttributes;

	private static readonly XsdAttributeEntry[] AnyAttributeAttributes;

	private static readonly XsdAttributeEntry[] DocumentationAttributes;

	private static readonly XsdAttributeEntry[] AppinfoAttributes;

	private static readonly XsdAttributeEntry[] RedefineAttributes;

	private static readonly XsdAttributeEntry[] AnnotationAttributes;

	private static readonly XsdEntry[] SchemaEntries;

	private static readonly int[] DerivationMethodValues;

	private static readonly string[] DerivationMethodStrings;

	private static readonly string[] FormStringValues;

	private static readonly string[] UseStringValues;

	private static readonly string[] ProcessContentsStringValues;

	private XmlReader reader;

	private PositionInfo positionInfo;

	private XsdEntry currentEntry;

	private XsdEntry nextEntry;

	private bool hasChild;

	private HWStack stateHistory;

	private Stack containerStack;

	private XmlNameTable nameTable;

	private SchemaNames schemaNames;

	private XmlNamespaceManager namespaceManager;

	private bool canIncludeImport;

	private XmlSchema schema;

	private XmlSchemaObject xso;

	private XmlSchemaElement element;

	private XmlSchemaAny anyElement;

	private XmlSchemaAttribute attribute;

	private XmlSchemaAnyAttribute anyAttribute;

	private XmlSchemaComplexType complexType;

	private XmlSchemaSimpleType simpleType;

	private XmlSchemaComplexContent complexContent;

	private XmlSchemaComplexContentExtension complexContentExtension;

	private XmlSchemaComplexContentRestriction complexContentRestriction;

	private XmlSchemaSimpleContent simpleContent;

	private XmlSchemaSimpleContentExtension simpleContentExtension;

	private XmlSchemaSimpleContentRestriction simpleContentRestriction;

	private XmlSchemaSimpleTypeUnion simpleTypeUnion;

	private XmlSchemaSimpleTypeList simpleTypeList;

	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction;

	private XmlSchemaGroup group;

	private XmlSchemaGroupRef groupRef;

	private XmlSchemaAll all;

	private XmlSchemaChoice choice;

	private XmlSchemaSequence sequence;

	private XmlSchemaParticle particle;

	private XmlSchemaAttributeGroup attributeGroup;

	private XmlSchemaAttributeGroupRef attributeGroupRef;

	private XmlSchemaNotation notation;

	private XmlSchemaIdentityConstraint identityConstraint;

	private XmlSchemaXPath xpath;

	private XmlSchemaInclude include;

	private XmlSchemaImport import;

	private XmlSchemaAnnotation annotation;

	private XmlSchemaAppInfo appInfo;

	private XmlSchemaDocumentation documentation;

	private XmlSchemaFacet facet;

	private XmlNode[] markup;

	private XmlSchemaRedefine redefine;

	private ValidationEventHandler validationEventHandler;

	private ArrayList unhandledAttributes;

	private Hashtable namespaces;

	private SchemaNames.Token CurrentElement => default(SchemaNames.Token);

	private SchemaNames.Token ParentElement => default(SchemaNames.Token);

	private XmlSchemaObject ParentContainer => null;

	internal XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
	{
	}

	internal override bool ProcessElement(string prefix, string name, string ns)
	{
		return false;
	}

	internal override void ProcessAttribute(string prefix, string name, string ns, string value)
	{
	}

	internal override bool IsContentParsed()
	{
		return false;
	}

	internal override void ProcessMarkup(XmlNode[] markup)
	{
	}

	internal override void ProcessCData(string value)
	{
	}

	internal override void StartChildren()
	{
	}

	internal override void EndChildren()
	{
	}

	private void Push()
	{
	}

	private void Pop()
	{
	}

	private XmlSchemaObject GetContainer(State state)
	{
		return null;
	}

	private void SetContainer(State state, object container)
	{
	}

	private static void BuildAnnotated_Id(XsdBuilder builder, string value)
	{
	}

	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value)
	{
	}

	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value)
	{
	}

	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value)
	{
	}

	private static void BuildSchema_Version(XsdBuilder builder, string value)
	{
	}

	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value)
	{
	}

	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value)
	{
	}

	private static void InitSchema(XsdBuilder builder, string value)
	{
	}

	private static void InitInclude(XsdBuilder builder, string value)
	{
	}

	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value)
	{
	}

	private static void InitImport(XsdBuilder builder, string value)
	{
	}

	private static void BuildImport_Namespace(XsdBuilder builder, string value)
	{
	}

	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value)
	{
	}

	private static void InitRedefine(XsdBuilder builder, string value)
	{
	}

	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value)
	{
	}

	private static void EndRedefine(XsdBuilder builder)
	{
	}

	private static void InitAttribute(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttribute_Default(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttribute_Fixed(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttribute_Form(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttribute_Use(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttribute_Ref(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttribute_Name(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttribute_Type(XsdBuilder builder, string value)
	{
	}

	private static void InitElement(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Abstract(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Block(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Default(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Form(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Final(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Fixed(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_MinOccurs(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Name(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Nillable(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Ref(XsdBuilder builder, string value)
	{
	}

	private static void BuildElement_Type(XsdBuilder builder, string value)
	{
	}

	private static void InitSimpleType(XsdBuilder builder, string value)
	{
	}

	private static void BuildSimpleType_Name(XsdBuilder builder, string value)
	{
	}

	private static void BuildSimpleType_Final(XsdBuilder builder, string value)
	{
	}

	private static void InitSimpleTypeUnion(XsdBuilder builder, string value)
	{
	}

	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value)
	{
	}

	private static void InitSimpleTypeList(XsdBuilder builder, string value)
	{
	}

	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value)
	{
	}

	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value)
	{
	}

	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value)
	{
	}

	private static void InitComplexType(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexType_Abstract(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexType_Block(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexType_Final(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexType_Mixed(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexType_Name(XsdBuilder builder, string value)
	{
	}

	private static void InitComplexContent(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value)
	{
	}

	private static void InitComplexContentExtension(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value)
	{
	}

	private static void InitComplexContentRestriction(XsdBuilder builder, string value)
	{
	}

	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value)
	{
	}

	private static void InitSimpleContent(XsdBuilder builder, string value)
	{
	}

	private static void InitSimpleContentExtension(XsdBuilder builder, string value)
	{
	}

	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value)
	{
	}

	private static void InitSimpleContentRestriction(XsdBuilder builder, string value)
	{
	}

	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value)
	{
	}

	private static void InitAttributeGroup(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value)
	{
	}

	private static void InitAttributeGroupRef(XsdBuilder builder, string value)
	{
	}

	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value)
	{
	}

	private static void InitAnyAttribute(XsdBuilder builder, string value)
	{
	}

	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value)
	{
	}

	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value)
	{
	}

	private static void InitGroup(XsdBuilder builder, string value)
	{
	}

	private static void BuildGroup_Name(XsdBuilder builder, string value)
	{
	}

	private static void InitGroupRef(XsdBuilder builder, string value)
	{
	}

	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value)
	{
	}

	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value)
	{
	}

	private static void BuildGroupRef_Ref(XsdBuilder builder, string value)
	{
	}

	private static void InitAll(XsdBuilder builder, string value)
	{
	}

	private static void InitChoice(XsdBuilder builder, string value)
	{
	}

	private static void InitSequence(XsdBuilder builder, string value)
	{
	}

	private static void InitAny(XsdBuilder builder, string value)
	{
	}

	private static void BuildAny_Namespace(XsdBuilder builder, string value)
	{
	}

	private static void BuildAny_ProcessContents(XsdBuilder builder, string value)
	{
	}

	private static void InitNotation(XsdBuilder builder, string value)
	{
	}

	private static void BuildNotation_Name(XsdBuilder builder, string value)
	{
	}

	private static void BuildNotation_Public(XsdBuilder builder, string value)
	{
	}

	private static void BuildNotation_System(XsdBuilder builder, string value)
	{
	}

	private static void InitFacet(XsdBuilder builder, string value)
	{
	}

	private static void BuildFacet_Fixed(XsdBuilder builder, string value)
	{
	}

	private static void BuildFacet_Value(XsdBuilder builder, string value)
	{
	}

	private static void InitIdentityConstraint(XsdBuilder builder, string value)
	{
	}

	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value)
	{
	}

	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value)
	{
	}

	private static void InitSelector(XsdBuilder builder, string value)
	{
	}

	private static void BuildSelector_XPath(XsdBuilder builder, string value)
	{
	}

	private static void InitField(XsdBuilder builder, string value)
	{
	}

	private static void BuildField_XPath(XsdBuilder builder, string value)
	{
	}

	private static void InitAnnotation(XsdBuilder builder, string value)
	{
	}

	private static void InitAppinfo(XsdBuilder builder, string value)
	{
	}

	private static void BuildAppinfo_Source(XsdBuilder builder, string value)
	{
	}

	private static void EndAppinfo(XsdBuilder builder)
	{
	}

	private static void InitDocumentation(XsdBuilder builder, string value)
	{
	}

	private static void BuildDocumentation_Source(XsdBuilder builder, string value)
	{
	}

	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value)
	{
	}

	private static void EndDocumentation(XsdBuilder builder)
	{
	}

	private void AddAttribute(XmlSchemaObject value)
	{
	}

	private void AddParticle(XmlSchemaParticle particle)
	{
	}

	private bool GetNextState(XmlQualifiedName qname)
	{
		return false;
	}

	private bool IsSkipableElement(XmlQualifiedName qname)
	{
		return false;
	}

	private void SetMinOccurs(XmlSchemaParticle particle, string value)
	{
	}

	private void SetMaxOccurs(XmlSchemaParticle particle, string value)
	{
	}

	private bool ParseBoolean(string value, string attributeName)
	{
		return false;
	}

	private int ParseEnum(string value, string attributeName, string[] values)
	{
		return 0;
	}

	private XmlQualifiedName ParseQName(string value, string attributeName)
	{
		return null;
	}

	private int ParseBlockFinalEnum(string value, string attributeName)
	{
		return 0;
	}

	private static string ParseUriReference(string s)
	{
		return null;
	}

	private void SendValidationEvent(string code, string arg0, string arg1, string arg2)
	{
	}

	private void SendValidationEvent(string code, string msg)
	{
	}

	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity)
	{
	}

	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
	{
	}

	private void SendValidationEvent(XmlSchemaException e)
	{
	}

	private void RecordPosition()
	{
	}
}
