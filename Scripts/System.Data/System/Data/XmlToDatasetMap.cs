using System.Collections;
using System.Xml;

namespace System.Data;

internal sealed class XmlToDatasetMap
{
	private sealed class XmlNodeIdentety
	{
		public string LocalName;

		public string NamespaceURI;

		public XmlNodeIdentety(string localName, string namespaceURI)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}

	internal sealed class XmlNodeIdHashtable : Hashtable
	{
		private XmlNodeIdentety _id;

		public object this[XmlNode node] => null;

		public object this[XmlReader dataReader] => null;

		public object this[DataTable table] => null;

		public object this[string name] => null;

		public XmlNodeIdHashtable(int capacity)
		{
		}
	}

	private sealed class TableSchemaInfo
	{
		public DataTable TableSchema;

		public XmlNodeIdHashtable ColumnsSchemaMap;

		public TableSchemaInfo(DataTable tableSchema)
		{
		}
	}

	private XmlNodeIdHashtable _tableSchemaMap;

	private TableSchemaInfo _lastTableSchemaInfo;

	public XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable)
	{
	}

	public XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet)
	{
	}

	public XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable)
	{
	}

	public XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable)
	{
	}

	internal static bool IsMappedColumn(DataColumn c)
	{
		return false;
	}

	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable)
	{
		return null;
	}

	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table)
	{
		return null;
	}

	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns)
	{
		return false;
	}

	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns)
	{
		return false;
	}

	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable)
	{
	}

	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet)
	{
	}

	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable)
	{
	}

	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable)
	{
	}

	private ArrayList GetSelfAndDescendants(DataTable dt)
	{
		return null;
	}

	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace)
	{
		return null;
	}

	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace)
	{
		return null;
	}

	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace)
	{
		return null;
	}

	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace)
	{
		return null;
	}

	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns)
	{
	}
}
