using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Interpreter;

internal sealed class QuoteInstruction : Instruction
{
	private sealed class ExpressionQuoter : ExpressionVisitor
	{
		private readonly Dictionary<ParameterExpression, LocalVariable> _variables;

		private readonly InterpretedFrame _frame;

		private readonly Stack<HashSet<ParameterExpression>> _shadowedVars;

		internal ExpressionQuoter(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame)
		{
		}

		protected internal override Expression VisitLambda<T>(Expression<T> node)
		{
			return null;
		}

		protected internal override Expression VisitBlock(BlockExpression node)
		{
			return null;
		}

		protected override CatchBlock VisitCatchBlock(CatchBlock node)
		{
			return null;
		}

		protected internal override Expression VisitParameter(ParameterExpression node)
		{
			return null;
		}

		private IStrongBox GetBox(ParameterExpression variable)
		{
			return null;
		}
	}

	private readonly Expression _operand;

	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	public QuoteInstruction(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
