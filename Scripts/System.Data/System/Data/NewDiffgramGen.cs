using System.Collections;
using System.Xml;

namespace System.Data;

internal sealed class NewDiffgramGen
{
	internal XmlDocument _doc;

	internal DataSet _ds;

	internal DataTable _dt;

	internal XmlWriter _xmlw;

	private bool _fBefore;

	private bool _fErrors;

	internal Hashtable _rowsOrder;

	private ArrayList _tables;

	private bool _writeHierarchy;

	internal NewDiffgramGen(DataSet ds)
	{
	}

	internal NewDiffgramGen(DataTable dt, bool writeHierarchy)
	{
	}

	private void CreateTableHierarchy(DataTable dt)
	{
	}

	private void DoAssignments(ArrayList tables)
	{
	}

	private bool EmptyData()
	{
		return false;
	}

	internal void Save(XmlWriter xmlw)
	{
	}

	internal void Save(XmlWriter xmlw, DataTable table)
	{
	}

	private void GenerateTable(DataTable table)
	{
	}

	private void GenerateTableErrors(DataTable table)
	{
	}

	private void GenerateRow(DataRow row)
	{
	}

	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version)
	{
	}

	internal static string QualifiedName(string prefix, string name)
	{
		return null;
	}
}
