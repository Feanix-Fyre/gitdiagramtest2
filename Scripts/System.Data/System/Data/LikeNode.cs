namespace System.Data;

internal sealed class LikeNode : BinaryNode
{
	private int _kind;

	private string _pattern;

	internal LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
		: base(null, 0, null, null)
	{
	}

	internal override object Eval(DataRow row, DataRowVersion version)
	{
		return null;
	}

	internal string AnalyzePattern(string pat)
	{
		return null;
	}
}
