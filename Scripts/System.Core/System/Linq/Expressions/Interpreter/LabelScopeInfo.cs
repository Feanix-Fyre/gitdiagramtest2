namespace System.Linq.Expressions.Interpreter;

internal sealed class LabelScopeInfo
{
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels;

	internal readonly LabelScopeKind Kind;

	internal readonly LabelScopeInfo Parent;

	internal bool CanJumpInto => false;

	internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind)
	{
	}

	internal bool ContainsTarget(LabelTarget target)
	{
		return false;
	}

	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info)
	{
		info = null;
		return false;
	}

	internal void AddLabelInfo(LabelTarget target, LabelInfo info)
	{
	}
}
