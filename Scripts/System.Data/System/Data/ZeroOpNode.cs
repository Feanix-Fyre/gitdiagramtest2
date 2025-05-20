using System.Collections.Generic;

namespace System.Data;

internal sealed class ZeroOpNode : ExpressionNode
{
	internal readonly int _op;

	internal ZeroOpNode(int op)
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
}
