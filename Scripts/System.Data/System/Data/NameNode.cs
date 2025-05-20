using System.Collections.Generic;

namespace System.Data;

internal sealed class NameNode : ExpressionNode
{
	internal string _name;

	internal bool _found;

	internal DataColumn _column;

	internal override bool IsSqlColumn => false;

	internal NameNode(DataTable table, char[] text, int start, int pos)
		: base(null)
	{
	}

	internal NameNode(DataTable table, string name)
		: base(null)
	{
	}

	internal override void Bind(DataTable table, List<DataColumn> list)
	{
	}

	internal override object Eval()
	{
		return null;
	}

	internal override object Eval(DataRow row, DataRowVersion version)
	{
		return null;
	}

	internal override object Eval(int[] records)
	{
		return null;
	}

	internal override bool IsConstant()
	{
		return false;
	}

	internal override bool IsTableConstant()
	{
		return false;
	}

	internal override bool HasLocalAggregate()
	{
		return false;
	}

	internal override bool HasRemoteAggregate()
	{
		return false;
	}

	internal override bool DependsOn(DataColumn column)
	{
		return false;
	}

	internal override ExpressionNode Optimize()
	{
		return null;
	}

	internal static string ParseName(char[] text, int start, int pos)
	{
		return null;
	}
}
