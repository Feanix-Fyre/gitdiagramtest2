using System.Collections;

namespace System.Xml.Schema;

internal sealed class XdrBuilder : SchemaBuilder
{
	private sealed class DeclBaseInfo
	{
		internal XmlQualifiedName _Name;

		internal string _Prefix;

		internal XmlQualifiedName _TypeName;

		internal string _TypePrefix;

		internal object _Default;

		internal object _Revises;

		internal uint _MaxOccurs;

		internal uint _MinOccurs;

		internal bool _Checking;

		internal SchemaElementDecl _ElementDecl;

		internal SchemaAttDef _Attdef;

		internal DeclBaseInfo _Next;

		internal DeclBaseInfo()
		{
		}

		internal void Reset()
		{
		}
	}

	private sealed class GroupContent
	{
		internal uint _MinVal;

		internal uint _MaxVal;

		internal bool _HasMaxAttr;

		internal bool _HasMinAttr;

		internal int _Order;

		internal static void Copy(GroupContent from, GroupContent to)
		{
		}

		internal static GroupContent Copy(GroupContent other)
		{
			return null;
		}
	}

	private sealed class ElementContent
	{
		internal SchemaElementDecl _ElementDecl;

		internal int _ContentAttr;

		internal int _OrderAttr;

		internal bool _MasterGroupRequired;

		internal bool _ExistTerminal;

		internal bool _AllowDataType;

		internal bool _HasDataType;

		internal bool _HasType;

		internal bool _EnumerationRequired;

		internal uint _MinVal;

		internal uint _MaxVal;

		internal uint _MaxLength;

		internal uint _MinLength;

		internal Hashtable _AttDefList;
	}

	private sealed class AttributeContent
	{
		internal SchemaAttDef _AttDef;

		internal XmlQualifiedName _Name;

		internal string _Prefix;

		internal bool _Required;

		internal uint _MinVal;

		internal uint _MaxVal;

		internal uint _MaxLength;

		internal uint _MinLength;

		internal bool _EnumerationRequired;

		internal bool _HasDataType;

		internal bool _Global;

		internal object _Default;
	}

	private delegate void XdrBuildFunction(XdrBuilder builder, object obj, string prefix);

	private delegate void XdrInitFunction(XdrBuilder builder, object obj);

	private delegate void XdrBeginChildFunction(XdrBuilder builder);

	private delegate void XdrEndChildFunction(XdrBuilder builder);

	private sealed class XdrAttributeEntry
	{
		internal SchemaNames.Token _Attribute;

		internal int _SchemaFlags;

		internal XmlSchemaDatatype _Datatype;

		internal XdrBuildFunction _BuildFunc;

		internal XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuildFunction build)
		{
		}

		internal XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuildFunction build)
		{
		}
	}

	private sealed class XdrEntry
	{
		internal SchemaNames.Token _Name;

		internal int[] _NextStates;

		internal XdrAttributeEntry[] _Attributes;

		internal XdrInitFunction _InitFunc;

		internal XdrBeginChildFunction _BeginChildFunc;

		internal XdrEndChildFunction _EndChildFunc;

		internal bool _AllowText;

		internal XdrEntry(SchemaNames.Token n, int[] states, XdrAttributeEntry[] attributes, XdrInitFunction init, XdrBeginChildFunction begin, XdrEndChildFunction end, bool fText)
		{
		}
	}

	private static readonly int[] S_XDR_Root_Element;

	private static readonly int[] S_XDR_Root_SubElements;

	private static readonly int[] S_XDR_ElementType_SubElements;

	private static readonly int[] S_XDR_AttributeType_SubElements;

	private static readonly int[] S_XDR_Group_SubElements;

	private static readonly XdrAttributeEntry[] S_XDR_Root_Attributes;

	private static readonly XdrAttributeEntry[] S_XDR_ElementType_Attributes;

	private static readonly XdrAttributeEntry[] S_XDR_AttributeType_Attributes;

	private static readonly XdrAttributeEntry[] S_XDR_Element_Attributes;

	private static readonly XdrAttributeEntry[] S_XDR_Attribute_Attributes;

	private static readonly XdrAttributeEntry[] S_XDR_Group_Attributes;

	private static readonly XdrAttributeEntry[] S_XDR_ElementDataType_Attributes;

	private static readonly XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes;

	private static readonly XdrEntry[] S_SchemaEntries;

	private SchemaInfo _SchemaInfo;

	private string _TargetNamespace;

	private XmlReader _reader;

	private PositionInfo positionInfo;

	private ParticleContentValidator _contentValidator;

	private XdrEntry _CurState;

	private XdrEntry _NextState;

	private HWStack _StateHistory;

	private HWStack _GroupStack;

	private string _XdrName;

	private string _XdrPrefix;

	private ElementContent _ElementDef;

	private GroupContent _GroupDef;

	private AttributeContent _AttributeDef;

	private DeclBaseInfo _UndefinedAttributeTypes;

	private DeclBaseInfo _BaseDecl;

	private XmlNameTable _NameTable;

	private SchemaNames _SchemaNames;

	private XmlNamespaceManager _CurNsMgr;

	private string _Text;

	private ValidationEventHandler validationEventHandler;

	private Hashtable _UndeclaredElements;

	private XmlResolver xmlResolver;

	internal XmlResolver XmlResolver
	{
		set
		{
		}
	}

	internal XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
	{
	}

	internal override bool ProcessElement(string prefix, string name, string ns)
	{
		return false;
	}

	internal override void ProcessAttribute(string prefix, string name, string ns, string value)
	{
	}

	private bool LoadSchema(string uri)
	{
		return false;
	}

	internal static bool IsXdrSchema(string uri)
	{
		return false;
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

	private void PushGroupInfo()
	{
	}

	private void PopGroupInfo()
	{
	}

	private static void XDR_InitRoot(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BeginRoot(XdrBuilder builder)
	{
	}

	private static void XDR_EndRoot(XdrBuilder builder)
	{
	}

	private static void XDR_InitElementType(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BeginElementType(XdrBuilder builder)
	{
	}

	private static void XDR_EndElementType(XdrBuilder builder)
	{
	}

	private static void XDR_InitAttributeType(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BeginAttributeType(XdrBuilder builder)
	{
	}

	private static void XDR_EndAttributeType(XdrBuilder builder)
	{
	}

	private static void XDR_InitElement(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_EndElement(XdrBuilder builder)
	{
	}

	private static void XDR_InitAttribute(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BeginAttribute(XdrBuilder builder)
	{
	}

	private static void XDR_EndAttribute(XdrBuilder builder)
	{
	}

	private static void XDR_InitGroup(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix)
	{
	}

	private static void XDR_EndGroup(XdrBuilder builder)
	{
	}

	private static void XDR_InitElementDtType(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_EndElementDtType(XdrBuilder builder)
	{
	}

	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj)
	{
	}

	private static void XDR_EndAttributeDtType(XdrBuilder builder)
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

	private bool IsSkipableAttribute(XmlQualifiedName qname)
	{
		return false;
	}

	private int GetOrder(XmlQualifiedName qname)
	{
		return 0;
	}

	private void AddOrder()
	{
	}

	private static bool IsYes(object obj, XdrBuilder builder)
	{
		return false;
	}

	private static uint ParseMinOccurs(object obj, XdrBuilder builder)
	{
		return 0u;
	}

	private static uint ParseMaxOccurs(object obj, XdrBuilder builder)
	{
		return 0u;
	}

	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax)
	{
	}

	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder)
	{
	}

	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder)
	{
	}

	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder)
	{
	}

	private static bool ParseInteger(string str, ref uint n)
	{
		return false;
	}

	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef)
	{
	}

	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired)
	{
	}

	private int GetContent(XmlQualifiedName qname)
	{
		return 0;
	}

	private bool GetModel(XmlQualifiedName qname)
	{
		return false;
	}

	private XmlSchemaDatatype CheckDatatype(string str)
	{
		return null;
	}

	private void CheckDefaultAttValue(SchemaAttDef attDef)
	{
	}

	private bool IsGlobal(int flags)
	{
		return false;
	}

	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity)
	{
	}

	private void SendValidationEvent(string code)
	{
	}

	private void SendValidationEvent(string code, string msg)
	{
	}

	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
	{
	}
}
