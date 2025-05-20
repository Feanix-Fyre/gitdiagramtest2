using System.Collections.Generic;

namespace System.Data;

internal sealed class ConstNode : ExpressionNode
{
	internal readonly object _val;

	internal ConstNode(DataTable table, ValueType type, object constant)
		: base(null)
	{
	}

	internal ConstNode(DataTable table, ValueType type, object constant, bool fParseQuotes)
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

	internal override ExpressionNode Optimize()
	{
		return null;
	}

	private object SmallestDecimal(object constant)
	{
		return null;
	}

	private object SmallestNumeric(object constant)
	{
		return null;
	}
}
