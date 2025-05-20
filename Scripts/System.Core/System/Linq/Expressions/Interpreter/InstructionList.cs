using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
internal sealed class InstructionList
{
	internal sealed class DebugView
	{
		[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
		internal readonly struct InstructionView
		{
			private readonly int _index;

			private readonly int _stackDepth;

			private readonly int _continuationsDepth;

			private readonly string _name;

			private readonly Instruction _instruction;

			internal string GetValue()
			{
				return null;
			}

			public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth)
			{
				_index = 0;
				_stackDepth = 0;
				_continuationsDepth = 0;
				_name = null;
				_instruction = null;
			}
		}

		internal static InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<object> objects, Func<int, int> labelIndexer, IReadOnlyList<KeyValuePair<int, object>> debugCookies)
		{
			return null;
		}
	}

	private readonly List<Instruction> _instructions;

	private List<object> _objects;

	private int _currentStackDepth;

	private int _maxStackDepth;

	private int _currentContinuationsDepth;

	private int _maxContinuationDepth;

	private int _runtimeLabelCount;

	private List<BranchLabel> _labels;

	private List<KeyValuePair<int, object>> _debugCookies;

	private static Instruction s_null;

	private static Instruction s_true;

	private static Instruction s_false;

	private static Instruction[] s_Ints;

	private static Instruction[] s_loadObjectCached;

	private static Instruction[] s_loadLocal;

	private static Instruction[] s_loadLocalBoxed;

	private static Instruction[] s_loadLocalFromClosure;

	private static Instruction[] s_loadLocalFromClosureBoxed;

	private static Instruction[] s_assignLocal;

	private static Instruction[] s_storeLocal;

	private static Instruction[] s_assignLocalBoxed;

	private static Instruction[] s_storeLocalBoxed;

	private static Instruction[] s_assignLocalToClosure;

	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields;

	private static readonly RuntimeLabel[] s_emptyRuntimeLabels;

	public int Count => 0;

	public int CurrentStackDepth => 0;

	public int CurrentContinuationsDepth => 0;

	public void Emit(Instruction instruction)
	{
	}

	private void UpdateStackDepth(Instruction instruction)
	{
	}

	public void UnEmit()
	{
	}

	internal Instruction GetInstruction(int index)
	{
		return null;
	}

	public InstructionArray ToArray()
	{
		return default(InstructionArray);
	}

	public void EmitLoad(object value)
	{
	}

	public void EmitLoad(bool value)
	{
	}

	public void EmitLoad(object value, Type type)
	{
	}

	public void EmitDup()
	{
	}

	public void EmitPop()
	{
	}

	internal void SwitchToBoxed(int index, int instructionIndex)
	{
	}

	public void EmitLoadLocal(int index)
	{
	}

	public void EmitLoadLocalBoxed(int index)
	{
	}

	internal static Instruction LoadLocalBoxed(int index)
	{
		return null;
	}

	public void EmitLoadLocalFromClosure(int index)
	{
	}

	public void EmitLoadLocalFromClosureBoxed(int index)
	{
	}

	public void EmitAssignLocal(int index)
	{
	}

	public void EmitStoreLocal(int index)
	{
	}

	public void EmitAssignLocalBoxed(int index)
	{
	}

	internal static Instruction AssignLocalBoxed(int index)
	{
		return null;
	}

	public void EmitStoreLocalBoxed(int index)
	{
	}

	internal static Instruction StoreLocalBoxed(int index)
	{
		return null;
	}

	public void EmitAssignLocalToClosure(int index)
	{
	}

	public void EmitStoreLocalToClosure(int index)
	{
	}

	public void EmitInitializeLocal(int index, Type type)
	{
	}

	internal void EmitInitializeParameter(int index)
	{
	}

	internal static Instruction Parameter(int index)
	{
		return null;
	}

	internal static Instruction ParameterBox(int index)
	{
		return null;
	}

	internal static Instruction InitReference(int index)
	{
		return null;
	}

	internal static Instruction InitImmutableRefBox(int index)
	{
		return null;
	}

	public void EmitNewRuntimeVariables(int count)
	{
	}

	public void EmitGetArrayItem()
	{
	}

	public void EmitSetArrayItem()
	{
	}

	public void EmitNewArray(Type elementType)
	{
	}

	public void EmitNewArrayBounds(Type elementType, int rank)
	{
	}

	public void EmitNewArrayInit(Type elementType, int elementCount)
	{
	}

	public void EmitAdd(Type type, bool @checked)
	{
	}

	public void EmitSub(Type type, bool @checked)
	{
	}

	public void EmitMul(Type type, bool @checked)
	{
	}

	public void EmitDiv(Type type)
	{
	}

	public void EmitModulo(Type type)
	{
	}

	public void EmitExclusiveOr(Type type)
	{
	}

	public void EmitAnd(Type type)
	{
	}

	public void EmitOr(Type type)
	{
	}

	public void EmitLeftShift(Type type)
	{
	}

	public void EmitRightShift(Type type)
	{
	}

	public void EmitEqual(Type type, bool liftedToNull = false)
	{
	}

	public void EmitNotEqual(Type type, bool liftedToNull = false)
	{
	}

	public void EmitLessThan(Type type, bool liftedToNull)
	{
	}

	public void EmitLessThanOrEqual(Type type, bool liftedToNull)
	{
	}

	public void EmitGreaterThan(Type type, bool liftedToNull)
	{
	}

	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull)
	{
	}

	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull)
	{
	}

	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull)
	{
	}

	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull)
	{
	}

	public void EmitCast(Type toType)
	{
	}

	public void EmitCastToEnum(Type toType)
	{
	}

	public void EmitCastReferenceToEnum(Type toType)
	{
	}

	public void EmitNot(Type type)
	{
	}

	public void EmitDefaultValue(Type type)
	{
	}

	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters)
	{
	}

	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters)
	{
	}

	internal void EmitCreateDelegate(LightDelegateCreator creator)
	{
	}

	public void EmitTypeEquals()
	{
	}

	public void EmitArrayLength()
	{
	}

	public void EmitNegate(Type type)
	{
	}

	public void EmitNegateChecked(Type type)
	{
	}

	public void EmitIncrement(Type type)
	{
	}

	public void EmitDecrement(Type type)
	{
	}

	public void EmitTypeIs(Type type)
	{
	}

	public void EmitTypeAs(Type type)
	{
	}

	public void EmitLoadField(FieldInfo field)
	{
	}

	private Instruction GetLoadField(FieldInfo field)
	{
		return null;
	}

	public void EmitStoreField(FieldInfo field)
	{
	}

	public void EmitCall(MethodInfo method)
	{
	}

	public void EmitCall(MethodInfo method, ParameterInfo[] parameters)
	{
	}

	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs)
	{
	}

	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters)
	{
	}

	private RuntimeLabel[] BuildRuntimeLabels()
	{
		return null;
	}

	public BranchLabel MakeLabel()
	{
		return null;
	}

	internal void FixupBranch(int branchIndex, int offset)
	{
	}

	private int EnsureLabelIndex(BranchLabel label)
	{
		return 0;
	}

	public int MarkRuntimeLabel()
	{
		return 0;
	}

	public void MarkLabel(BranchLabel label)
	{
	}

	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue)
	{
	}

	private void EmitBranch(OffsetInstruction instruction, BranchLabel label)
	{
	}

	public void EmitBranch(BranchLabel label)
	{
	}

	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue)
	{
	}

	public void EmitCoalescingBranch(BranchLabel leftNotNull)
	{
	}

	public void EmitBranchTrue(BranchLabel elseLabel)
	{
	}

	public void EmitBranchFalse(BranchLabel elseLabel)
	{
	}

	public void EmitThrow()
	{
	}

	public void EmitThrowVoid()
	{
	}

	public void EmitRethrow()
	{
	}

	public void EmitRethrowVoid()
	{
	}

	public void EmitEnterTryFinally(BranchLabel finallyStartLabel)
	{
	}

	public void EmitEnterTryCatch()
	{
	}

	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd)
	{
		return null;
	}

	public void EmitEnterFinally(BranchLabel finallyStartLabel)
	{
	}

	public void EmitLeaveFinally()
	{
	}

	public void EmitEnterFault(BranchLabel faultStartLabel)
	{
	}

	public void EmitLeaveFault()
	{
	}

	public void EmitEnterExceptionFilter()
	{
	}

	public void EmitLeaveExceptionFilter()
	{
	}

	public void EmitEnterExceptionHandlerNonVoid()
	{
	}

	public void EmitEnterExceptionHandlerVoid()
	{
	}

	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel)
	{
	}

	public void EmitIntSwitch<T>(Dictionary<T, int> cases)
	{
	}

	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase)
	{
	}
}
