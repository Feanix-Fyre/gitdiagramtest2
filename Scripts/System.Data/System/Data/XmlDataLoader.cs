using System.Collections;
using System.Xml;

namespace System.Data;

internal sealed class XmlDataLoader
{
	private DataSet _dataSet;

	private XmlToDatasetMap _nodeToSchemaMap;

	private Hashtable _nodeToRowMap;

	private Stack _childRowsStack;

	private Hashtable _htableExcludedNS;

	private bool _fIsXdr;

	internal bool _isDiffgram;

	private XmlElement _topMostNode;

	private bool _ignoreSchema;

	private DataTable _dataTable;

	private bool _isTableLevel;

	private bool _fromInference;

	private XmlReader _dataReader;

	private object _XSD_XMLNS_NS;

	private object _XDR_SCHEMA;

	private object _XDRNS;

	private object _SQL_SYNC;

	private object _UPDGNS;

	private object _XSD_SCHEMA;

	private object _XSDNS;

	private object _DFFNS;

	private object _MSDNS;

	private object _DIFFID;

	private object _HASCHANGES;

	private object _ROWORDER;

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

	internal XmlDataLoader(DataSet dataset, bool IsXdr, bool ignoreSchema)
	{
	}

	internal XmlDataLoader(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema)
	{
	}

	internal XmlDataLoader(DataTable datatable, bool IsXdr, bool ignoreSchema)
	{
	}

	internal XmlDataLoader(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema)
	{
	}

	private void AttachRows(DataRow parentRow, XmlNode parentElement)
	{
	}

	private int CountNonNSAttributes(XmlNode node)
	{
		return 0;
	}

	private string GetValueForTextOnlyColums(XmlNode n)
	{
		return null;
	}

	private string GetInitialTextFromNodes(ref XmlNode n)
	{
		return null;
	}

	private DataColumn GetTextOnlyColumn(DataRow row)
	{
		return null;
	}

	internal DataRow GetRowFromElement(XmlElement e)
	{
		return null;
	}

	internal bool FColumnElement(XmlElement e)
	{
		return false;
	}

	private bool FExcludedNamespace(string ns)
	{
		return false;
	}

	private bool FIgnoreNamespace(XmlNode node)
	{
		return false;
	}

	private bool FIgnoreNamespace(XmlReader node)
	{
		return false;
	}

	internal bool IsTextLikeNode(XmlNodeType n)
	{
		return false;
	}

	internal bool IsTextOnly(DataColumn c)
	{
		return false;
	}

	internal void LoadData(XmlDocument xdoc)
	{
	}

	private void LoadRowData(DataRow row, XmlElement rowElement)
	{
	}

	private void LoadRows(DataRow parentRow, XmlNode parentElement)
	{
	}

	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText)
	{
	}

	private void InitNameTable()
	{
	}

	internal void LoadData(XmlReader reader)
	{
	}

	private void LoadTopMostTable(DataTable table)
	{
	}

	private void LoadTable(DataTable table, bool isNested)
	{
	}

	private void LoadColumn(DataColumn column, object[] foundColumns)
	{
	}

	private bool ProcessXsdSchema()
	{
		return false;
	}
}
