using System.Collections;
using System.Xml;

namespace System.Data;

internal sealed class XmlDataTreeWriter
{
	private XmlWriter _xmlw;

	private DataSet _ds;

	private DataTable _dt;

	private ArrayList _dTables;

	private DataTable[] _topLevelTables;

	private bool _fFromTable;

	private bool _isDiffgram;

	private Hashtable _rowsOrder;

	private bool _writeHierarchy;

	internal XmlDataTreeWriter(DataSet ds)
	{
	}

	internal XmlDataTreeWriter(DataTable dt, bool writeHierarchy)
	{
	}

	private DataTable[] CreateToplevelTables()
	{
		return null;
	}

	private void CreateTablesHierarchy(DataTable dt)
	{
	}

	internal static bool RowHasErrors(DataRow row)
	{
		return false;
	}

	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder)
	{
	}

	internal void Save(XmlWriter xw, bool writeSchema)
	{
	}

	private ArrayList GetNestedChildRelations(DataRow row)
	{
		return null;
	}

	internal void XmlDataRowWriter(DataRow row, string encodedTableName)
	{
	}

	internal static bool PreserveSpace(object value)
	{
		return false;
	}
}
