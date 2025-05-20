using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace System.Dynamic;

/// <summary>Represents a set of binding restrictions on the <see cref="T:System.Dynamic.DynamicMetaObject" /> under which the dynamic binding is valid.</summary>
[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
[DebuggerDisplay("{DebugView}")]
public abstract class BindingRestrictions
{
	private sealed class TestBuilder
	{
		private struct AndNode
		{
			internal int Depth;

			internal Expression Node;
		}

		private readonly HashSet<BindingRestrictions> _unique;

		private readonly Stack<AndNode> _tests;

		internal void Append(BindingRestrictions restrictions)
		{
		}

		internal Expression ToExpression()
		{
			return null;
		}

		private void Push(Expression node, int depth)
		{
		}
	}

	private sealed class MergedRestriction : BindingRestrictions
	{
		internal readonly BindingRestrictions Left;

		internal readonly BindingRestrictions Right;

		internal MergedRestriction(BindingRestrictions left, BindingRestrictions right)
		{
		}

		internal override Expression GetExpression()
		{
			return null;
		}
	}

	private sealed class CustomRestriction : BindingRestrictions
	{
		private readonly Expression _expression;

		internal CustomRestriction(Expression expression)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal override Expression GetExpression()
		{
			return null;
		}
	}

	private sealed class TypeRestriction : BindingRestrictions
	{
		private readonly Expression _expression;

		private readonly Type _type;

		internal TypeRestriction(Expression parameter, Type type)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal override Expression GetExpression()
		{
			return null;
		}
	}

	private sealed class InstanceRestriction : BindingRestrictions
	{
		private readonly Expression _expression;

		private readonly object _instance;

		internal InstanceRestriction(Expression parameter, object instance)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal override Expression GetExpression()
		{
			return null;
		}
	}

	private sealed class BindingRestrictionsProxy
	{
	}

	/// <summary>Represents an empty set of binding restrictions. This field is read only.</summary>
	public static readonly BindingRestrictions Empty;

	private BindingRestrictions()
	{
	}

	internal abstract Expression GetExpression();

	/// <summary>Merges the set of binding restrictions with the current binding restrictions.</summary>
	/// <param name="restrictions">The set of restrictions with which to merge the current binding restrictions.</param>
	/// <returns>The new set of binding restrictions.</returns>
	public BindingRestrictions Merge(BindingRestrictions restrictions)
	{
		return null;
	}

	/// <summary>Creates the binding restriction that check the expression for runtime type identity.</summary>
	/// <param name="expression">The expression to test.</param>
	/// <param name="type">The exact type to test.</param>
	/// <returns>The new binding restrictions.</returns>
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
	{
		return null;
	}

	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
	{
		return null;
	}

	/// <summary>Creates the binding restriction that checks the expression for object instance identity.</summary>
	/// <param name="expression">The expression to test.</param>
	/// <param name="instance">The exact object instance to test.</param>
	/// <returns>The new binding restrictions.</returns>
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance)
	{
		return null;
	}

	/// <summary>Creates the <see cref="T:System.Linq.Expressions.Expression" /> representing the binding restrictions.</summary>
	/// <returns>The expression tree representing the restrictions.</returns>
	public Expression ToExpression()
	{
		return null;
	}
}
