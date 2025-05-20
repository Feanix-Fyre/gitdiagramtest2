using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Dynamic;

/// <summary>The dynamic call site binder that participates in the <see cref="T:System.Dynamic.DynamicMetaObject" /> binding protocol.</summary>
public abstract class DynamicMetaObjectBinder : CallSiteBinder
{
	/// <summary>The result type of the operation.</summary>
	/// <returns>The <see cref="T:System.Type" /> object representing the result type of the operation.</returns>
	public virtual Type ReturnType => null;

	internal virtual bool IsStandardBinder => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Dynamic.DynamicMetaObjectBinder" /> class.</summary>
	protected DynamicMetaObjectBinder()
	{
	}

	/// <summary>Performs the runtime binding of the dynamic operation on a set of arguments.</summary>
	/// <param name="args">An array of arguments to the dynamic operation.</param>
	/// <param name="parameters">The array of <see cref="T:System.Linq.Expressions.ParameterExpression" /> instances that represent the parameters of the call site in the binding process.</param>
	/// <param name="returnLabel">A LabelTarget used to return the result of the dynamic binding.</param>
	/// <returns>An Expression that performs tests on the dynamic operation arguments, and performs the dynamic operation if the tests are valid. If the tests fail on subsequent occurrences of the dynamic operation, Bind will be called again to produce a new <see cref="T:System.Linq.Expressions.Expression" /> for the new argument types.</returns>
	public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
	{
		return null;
	}

	private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the dynamic operation.</summary>
	/// <param name="target">The target of the dynamic operation.</param>
	/// <param name="args">An array of arguments of the dynamic operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

	/// <summary>Gets an expression that will cause the binding to be updated. It indicates that the expression's binding is no longer valid. This is typically used when the "version" of a dynamic object has changed.</summary>
	/// <param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of the resulting expression; any type is allowed.</param>
	/// <returns>The update expression.</returns>
	public Expression GetUpdateExpression(Type type)
	{
		return null;
	}
}
