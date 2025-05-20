using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal sealed class LightCompiler
{
	private sealed class QuoteVisitor : ExpressionVisitor
	{
		private readonly Dictionary<ParameterExpression, int> _definedParameters;

		public readonly HashSet<ParameterExpression> _hoistedParameters;

		protected internal override Expression VisitParameter(ParameterExpression node)
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

		protected internal override Expression VisitLambda<T>(Expression<T> node)
		{
			return null;
		}

		private void PushParameters(IEnumerable<ParameterExpression> parameters)
		{
		}

		private void PopParameters(IEnumerable<ParameterExpression> parameters)
		{
		}
	}

	private readonly InstructionList _instructions;

	private readonly LocalVariables _locals;

	private readonly List<DebugInfo> _debugInfos;

	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels;

	private LabelScopeInfo _labelBlock;

	private readonly Stack<ParameterExpression> _exceptionForRethrowStack;

	private readonly LightCompiler _parent;

	private readonly StackGuard _guard;

	private static readonly LocalDefinition[] s_emptyLocals;

	public InstructionList Instructions => null;

	public LightCompiler()
	{
	}

	private LightCompiler(LightCompiler parent)
	{
	}

	public LightDelegateCreator CompileTop(LambdaExpression node)
	{
		return null;
	}

	private Interpreter MakeInterpreter(string lambdaName)
	{
		return null;
	}

	private void CompileConstantExpression(Expression expr)
	{
	}

	private void CompileDefaultExpression(Expression expr)
	{
	}

	private void CompileDefaultExpression(Type type)
	{
	}

	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr)
	{
		return null;
	}

	private LocalVariable ResolveLocal(ParameterExpression variable)
	{
		return null;
	}

	private void CompileGetVariable(ParameterExpression variable)
	{
	}

	private void EmitCopyValueType(Type valueType)
	{
	}

	private void LoadLocalNoValueTypeCopy(ParameterExpression variable)
	{
	}

	private bool MaybeMutableValueType(Type type)
	{
		return false;
	}

	private void CompileGetBoxedVariable(ParameterExpression variable)
	{
	}

	private void CompileSetVariable(ParameterExpression variable, bool isVoid)
	{
	}

	private void CompileParameterExpression(Expression expr)
	{
	}

	private void CompileBlockExpression(Expression expr, bool asVoid)
	{
	}

	private LocalDefinition[] CompileBlockStart(BlockExpression node)
	{
		return null;
	}

	private void CompileBlockEnd(LocalDefinition[] locals)
	{
	}

	private void CompileIndexExpression(Expression expr)
	{
	}

	private void EmitIndexGet(IndexExpression index)
	{
	}

	private void CompileIndexAssignment(BinaryExpression node, bool asVoid)
	{
	}

	private void CompileMemberAssignment(BinaryExpression node, bool asVoid)
	{
	}

	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding)
	{
	}

	private void CompileVariableAssignment(BinaryExpression node, bool asVoid)
	{
	}

	private void CompileAssignBinaryExpression(Expression expr, bool asVoid)
	{
	}

	private void CompileBinaryExpression(Expression expr)
	{
	}

	private void CompileEqual(Expression left, Expression right, bool liftedToNull)
	{
	}

	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull)
	{
	}

	private void CompileComparison(BinaryExpression node)
	{
	}

	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right)
	{
	}

	private void CompileConvertUnaryExpression(Expression expr)
	{
	}

	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull)
	{
	}

	private void CompileNotExpression(UnaryExpression node)
	{
	}

	private void CompileUnaryExpression(Expression expr)
	{
	}

	private void EmitUnaryMethodCall(UnaryExpression node)
	{
	}

	private void EmitUnaryBoolCheck(UnaryExpression node)
	{
	}

	private void CompileAndAlsoBinaryExpression(Expression expr)
	{
	}

	private void CompileOrElseBinaryExpression(Expression expr)
	{
	}

	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso)
	{
	}

	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso)
	{
	}

	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso)
	{
	}

	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso)
	{
	}

	private void CompileConditionalExpression(Expression expr, bool asVoid)
	{
	}

	private void CompileLoopExpression(Expression expr)
	{
	}

	private void CompileSwitchExpression(Expression expr)
	{
	}

	private void CompileIntSwitchExpression<T>(SwitchExpression node)
	{
	}

	private void CompileStringSwitchExpression(SwitchExpression node)
	{
	}

	private void CompileLabelExpression(Expression expr)
	{
	}

	private void CompileGotoExpression(Expression expr)
	{
	}

	private void PushLabelBlock(LabelScopeKind type)
	{
	}

	private void PopLabelBlock(LabelScopeKind kind)
	{
	}

	private LabelInfo EnsureLabel(LabelTarget node)
	{
		return null;
	}

	private LabelInfo ReferenceLabel(LabelTarget node)
	{
		return null;
	}

	private LabelInfo DefineLabel(LabelTarget node)
	{
		return null;
	}

	private bool TryPushLabelBlock(Expression node)
	{
		return false;
	}

	private void DefineBlockLabels(Expression node)
	{
	}

	private void CheckRethrow()
	{
	}

	private void CompileThrowUnaryExpression(Expression expr, bool asVoid)
	{
	}

	private void CompileTryExpression(Expression expr)
	{
	}

	private void CompileTryFaultExpression(TryExpression expr)
	{
	}

	private void CompileMethodCallExpression(Expression expr)
	{
	}

	private void CompileMethodCallExpression(Expression @object, MethodInfo method, IArgumentProvider arguments)
	{
	}

	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex)
	{
		return null;
	}

	private void EmitThisForMethodCall(Expression node)
	{
	}

	private static bool ShouldWritebackNode(Expression node)
	{
		return false;
	}

	private ByRefUpdater CompileAddress(Expression node, int index)
	{
		return null;
	}

	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index)
	{
		return null;
	}

	private void CompileNewExpression(Expression expr)
	{
	}

	private void CompileMemberExpression(Expression expr)
	{
	}

	private void CompileMember(Expression from, MemberInfo member, bool forBinding)
	{
	}

	private void CompileNewArrayExpression(Expression expr)
	{
	}

	private void CompileDebugInfoExpression(Expression expr)
	{
	}

	private void CompileRuntimeVariablesExpression(Expression expr)
	{
	}

	private void CompileLambdaExpression(Expression expr)
	{
	}

	private void CompileCoalesceBinaryExpression(Expression expr)
	{
	}

	private void CompileInvocationExpression(Expression expr)
	{
	}

	private void CompileListInitExpression(Expression expr)
	{
	}

	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers)
	{
	}

	private void CompileMemberInitExpression(Expression expr)
	{
	}

	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings)
	{
	}

	private static Type GetMemberType(MemberInfo member)
	{
		return null;
	}

	private void CompileQuoteUnaryExpression(Expression expr)
	{
	}

	private void CompileUnboxUnaryExpression(Expression expr)
	{
	}

	private void CompileTypeEqualExpression(Expression expr)
	{
	}

	private void CompileTypeAsExpression(UnaryExpression node)
	{
	}

	private void CompileTypeIsExpression(Expression expr)
	{
	}

	private void Compile(Expression expr, bool asVoid)
	{
	}

	private void CompileAsVoid(Expression expr)
	{
	}

	private void CompileNoLabelPush(Expression expr)
	{
	}

	private void Compile(Expression expr)
	{
	}
}
