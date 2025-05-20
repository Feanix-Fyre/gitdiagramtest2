using System.Collections.Generic;

namespace System.Data;

internal sealed class UnaryNode : ExpressionNode
{
	internal readonly int _op;

	internal ExpressionNode _right;

	internal UnaryNode(DataTable table, int op, ExpressionNode right)
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

	private object EvalUnaryOp(int op, object vl)
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
