using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

/// <summary>Represents a visitor or rewriter for expression trees.</summary>
public abstract class ExpressionVisitor
{
	/// <summary>Initializes a new instance of <see cref="T:System.Linq.Expressions.ExpressionVisitor" />.</summary>
	protected ExpressionVisitor()
	{
	}

	/// <summary>Dispatches the expression to one of the more specialized visit methods in this class.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	public virtual Expression Visit(Expression node)
	{
		return null;
	}

	/// <summary>Dispatches the list of expressions to one of the more specialized visit methods in this class.</summary>
	/// <param name="nodes">The expressions to visit.</param>
	/// <returns>The modified expression list, if any one of the elements were modified; otherwise, returns the original expression list.</returns>
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
	{
		return null;
	}

	private Expression[] VisitArguments(IArgumentProvider nodes)
	{
		return null;
	}

	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName)
	{
		return null;
	}

	/// <summary>Visits all nodes in the collection using a specified element visitor.</summary>
	/// <param name="nodes">The nodes to visit.</param>
	/// <param name="elementVisitor">A delegate that visits a single element, optionally replacing it with a new element.</param>
	/// <typeparam name="T">The type of the nodes.</typeparam>
	/// <returns>The modified node list, if any of the elements were modified; otherwise, returns the original node list.</returns>
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
	{
		return null;
	}

	/// <summary>Visits an expression, casting the result back to the original expression type.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <param name="callerName">The name of the calling method; used to report to report a better error message.</param>
	/// <typeparam name="T">The type of the expression.</typeparam>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	/// <exception cref="T:System.InvalidOperationException">The visit method for this node returned a different type.</exception>
	public T VisitAndConvert<T>(T node, string callerName) where T : Expression
	{
		return null;
	}

	/// <summary>Visits an expression, casting the result back to the original expression type.</summary>
	/// <param name="nodes">The expression to visit.</param>
	/// <param name="callerName">The name of the calling method; used to report to report a better error message.</param>
	/// <typeparam name="T">The type of the expression.</typeparam>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	/// <exception cref="T:System.InvalidOperationException">The visit method for this node returned a different type.</exception>
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.BinaryExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitBinary(BinaryExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.BlockExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitBlock(BlockExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.ConditionalExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitConditional(ConditionalExpression node)
	{
		return null;
	}

	/// <summary>Visits the <see cref="T:System.Linq.Expressions.ConstantExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitConstant(ConstantExpression node)
	{
		return null;
	}

	/// <summary>Visits the <see cref="T:System.Linq.Expressions.DefaultExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitDefault(DefaultExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the extension expression.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitExtension(Expression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.GotoExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitGoto(GotoExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.InvocationExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitInvocation(InvocationExpression node)
	{
		return null;
	}

	/// <summary>Visits the <see cref="T:System.Linq.Expressions.LabelTarget" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.LabelExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitLabel(LabelExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.Expression`1" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <typeparam name="T">The type of the delegate.</typeparam>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitLambda<T>(Expression<T> node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.LoopExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitLoop(LoopExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MemberExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitMember(MemberExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.IndexExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitIndex(IndexExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.MethodCallExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.NewArrayExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitNewArray(NewArrayExpression node)
	{
		return null;
	}

	/// <summary>Visits the <see cref="T:System.Linq.Expressions.ParameterExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitParameter(ParameterExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.CatchBlock" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.TryExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitTry(TryExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.TypeBinaryExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node)
	{
		return null;
	}

	/// <summary>Visits the children of the <see cref="T:System.Linq.Expressions.UnaryExpression" />.</summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.</returns>
	protected internal virtual Expression VisitUnary(UnaryExpression node)
	{
		return null;
	}

	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
	{
		return null;
	}

	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
	{
		return null;
	}

	private static void ValidateChildType(Type before, Type after, string methodName)
	{
	}
}
