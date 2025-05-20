using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Interpreter;

internal sealed class Interpreter
{
	internal static readonly object NoValue;

	private readonly InstructionArray _instructions;

	internal readonly object[] _objects;

	internal readonly RuntimeLabel[] _labels;

	internal readonly DebugInfo[] _debugInfos;

	internal string Name { get; }

	internal int LocalCount { get; }

	internal int ClosureSize => 0;

	internal InstructionArray Instructions => default(InstructionArray);

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run(InterpretedFrame frame)
	{
	}
}
