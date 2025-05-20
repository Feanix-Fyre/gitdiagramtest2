using System.Collections.Generic;

namespace System.Data;

internal sealed class FunctionNode : ExpressionNode
{
	internal readonly string _name;

	internal readonly int _info;

	internal int _argumentCount;

	internal ExpressionNode[] _arguments;

	private readonly TypeLimiter? _capturedLimiter;

	private static readonly Function[] s_funcs;

	internal FunctionId Aggregate => default(FunctionId);

	internal bool IsAggregate => false;

	internal FunctionNode(DataTable table, string name)
		: base(null)
	{
	}

	internal void AddArgument(ExpressionNode argument)
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

	private Type GetDataType(ExpressionNode node)
	{
		return null;
	}

	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version)
	{
		return null;
	}

	internal void Check()
	{
	}
}
