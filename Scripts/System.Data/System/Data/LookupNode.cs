using System.Collections.Generic;

namespace System.Data;

internal sealed class LookupNode : ExpressionNode
{
	private readonly string _relationName;

	private readonly string _columnName;

	private DataColumn _column;

	private DataRelation _relation;

	internal LookupNode(DataTable table, string columnName, string relationName)
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

	internal override object Eval(int[] recordNos)
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
}
