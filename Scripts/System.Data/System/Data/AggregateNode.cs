using System.Collections.Generic;

namespace System.Data;

internal sealed class AggregateNode : ExpressionNode
{
	private readonly AggregateType _type;

	private readonly Aggregate _aggregate;

	private readonly bool _local;

	private readonly string _relationName;

	private readonly string _columnName;

	private DataTable _childTable;

	private DataColumn _column;

	private DataRelation _relation;

	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName)
		: base(null)
	{
	}

	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName)
		: base(null)
	{
	}

	internal override void Bind(DataTable table, List<DataColumn> list)
	{
	}

	internal static void Bind(DataRelation relation, List<DataColumn> list)
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
}
