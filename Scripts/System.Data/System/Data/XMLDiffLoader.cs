using System.Collections;
using System.Xml;

namespace System.Data;

internal sealed class XMLDiffLoader
{
	private ArrayList _tables;

	private DataSet _dataSet;

	private DataTable _dataTable;

	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader)
	{
	}

	private void CreateTablesHierarchy(DataTable dt)
	{
	}

	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader)
	{
	}

	internal void ProcessDiffs(DataSet ds, XmlReader ssync)
	{
	}

	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync)
	{
	}

	internal void ProcessErrors(DataSet ds, XmlReader ssync)
	{
	}

	internal void ProcessErrors(ArrayList dt, XmlReader ssync)
	{
	}

	private DataTable GetTable(string tableName, string ns)
	{
		return null;
	}

	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row)
	{
		return 0;
	}

	internal void SkipWhitespaces(XmlReader reader)
	{
	}
}
