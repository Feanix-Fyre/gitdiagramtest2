using System.Collections;
using System.Xml;

namespace System.Data;

internal sealed class XDRSchema : XMLSchema
{
	private sealed class NameType : IComparable
	{
		public string name;

		public Type type;

		public NameType(string n, Type t)
		{
		}

		public int CompareTo(object obj)
		{
			return 0;
		}
	}

	internal string _schemaName;

	internal string _schemaUri;

	internal XmlElement _schemaRoot;

	internal DataSet _ds;

	private static readonly char[] s_colonArray;

	private static NameType[] s_mapNameTypeXdr;

	private static NameType s_enumerationNameType;

	internal XDRSchema(DataSet ds, bool fInline)
	{
	}

	internal void LoadSchema(XmlElement schemaRoot, DataSet ds)
	{
	}

	internal XmlElement FindTypeNode(XmlElement node)
	{
		return null;
	}

	internal bool IsTextOnlyContent(XmlElement node)
	{
		return false;
	}

	internal bool IsXDRField(XmlElement node, XmlElement typeNode)
	{
		return false;
	}

	internal DataTable HandleTable(XmlElement node)
	{
		return null;
	}

	private static NameType FindNameType(string name)
	{
		return null;
	}

	private Type ParseDataType(string dt, string dtValues)
	{
		return null;
	}

	internal string GetInstanceName(XmlElement node)
	{
		return null;
	}

	internal void HandleColumn(XmlElement node, DataTable table)
	{
	}

	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs)
	{
	}

	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs)
	{
	}

	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren)
	{
	}

	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode)
	{
		return null;
	}

	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node)
	{
		return null;
	}
}
