using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal sealed class NewArrayBoundsExpression : NewArrayExpression
{
	public sealed override ExpressionType NodeType => default(ExpressionType);

	internal NewArrayBoundsExpression(Type type, ReadOnlyCollection<Expression> expressions)
		: base(null, null)
	{
	}
}
