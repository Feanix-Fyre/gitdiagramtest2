using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;

namespace System.Data;

internal sealed class XSDSchema : XMLSchema
{
	private sealed class NameType : IComparable
	{
		public readonly string name;

		public readonly Type type;

		public NameType(string n, Type t)
		{
		}

		public int CompareTo(object obj)
		{
			return 0;
		}
	}

	private XmlSchemaSet _schemaSet;

	private XmlSchemaElement _dsElement;

	private DataSet _ds;

	private string _schemaName;

	private ArrayList _columnExpressions;

	private Hashtable _constraintNodes;

	private ArrayList _refTables;

	private ArrayList _complexTypes;

	private XmlSchemaObjectCollection _annotations;

	private XmlSchemaObjectCollection _elements;

	private Hashtable _attributes;

	private Hashtable _elementsTable;

	private Hashtable _attributeGroups;

	private Hashtable _schemaTypes;

	private Hashtable _expressions;

	private Dictionary<DataTable, List<DataTable>> _tableDictionary;

	private Hashtable _udSimpleTypes;

	private Hashtable _existingSimpleTypeMap;

	private bool _fromInference;

	private static readonly NameType[] s_mapNameTypeXsd;

	internal bool FromInference
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void CollectElementsAnnotations(XmlSchema schema)
	{
	}

	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList)
	{
	}

	internal static string QualifiedName(string name)
	{
		return null;
	}

	internal static void SetProperties(object instance, XmlAttribute[] attrs)
	{
	}

	private static void SetExtProperties(object instance, XmlAttribute[] attrs)
	{
	}

	private void HandleColumnExpression(object instance, XmlAttribute[] attrs)
	{
	}

	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln)
	{
		return null;
	}

	private static void SetExtProperties(object instance, XmlAttributeCollection attrs)
	{
	}

	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element)
	{
	}

	internal void HandleRelation(XmlElement node, bool fNested)
	{
	}

	private bool HasAttributes(XmlSchemaObjectCollection attributes)
	{
		return false;
	}

	private bool IsDatasetParticle(XmlSchemaParticle pt)
	{
		return false;
	}

	private int DatasetElementCount(XmlSchemaObjectCollection elements)
	{
		return 0;
	}

	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements)
	{
		return null;
	}

	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt)
	{
	}

	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds)
	{
	}

	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested)
	{
	}

	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt)
	{
		return null;
	}

	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase)
	{
	}

	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase)
	{
	}

	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase)
	{
	}

	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable)
	{
	}

	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct)
	{
		return null;
	}

	internal DataColumn FindField(DataTable table, string field)
	{
		return null;
	}

	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table)
	{
		return null;
	}

	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal)
	{
		return false;
	}

	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal)
	{
		return null;
	}

	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule)
	{
		return default(AcceptRejectRule);
	}

	internal static Rule TranslateRule(string strRule)
	{
		return default(Rule);
	}

	internal void HandleKeyref(XmlSchemaKeyref keyref)
	{
	}

	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode)
	{
	}

	internal DataTable InstantiateSimpleTable(XmlSchemaElement node)
	{
		return null;
	}

	internal string GetInstanceName(XmlSchemaAnnotated node)
	{
		return null;
	}

	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef)
	{
		return null;
	}

	public static Type XsdtoClr(string xsdTypeName)
	{
		return null;
	}

	private static NameType FindNameType(string name)
	{
		return null;
	}

	private Type ParseDataType(string dt)
	{
		return null;
	}

	internal static bool IsXsdType(string name)
	{
		return false;
	}

	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node)
	{
		return null;
	}

	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable)
	{
	}

	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable)
	{
	}

	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase)
	{
	}

	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase)
	{
	}

	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet)
	{
	}

	private void AddTablesToList(List<DataTable> tableList, DataTable dt)
	{
	}

	private string GetPrefix(string ns)
	{
		return null;
	}

	private string GetNamespaceFromPrefix(string prefix)
	{
		return null;
	}

	private string GetTableNamespace(XmlSchemaIdentityConstraint key)
	{
		return null;
	}

	private string GetTableName(XmlSchemaIdentityConstraint key)
	{
		return null;
	}

	internal bool IsTable(XmlSchemaElement node)
	{
		return false;
	}

	internal DataTable HandleTable(XmlSchemaElement node)
	{
		return null;
	}
}
