using System.Collections.Generic;
using System.Diagnostics;

namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
internal readonly struct InstructionArray
{
	internal sealed class DebugView
	{
		private readonly InstructionArray _array;

		public DebugView(InstructionArray array)
		{
		}

		public InstructionList.DebugView.InstructionView[] GetInstructionViews(bool includeDebugCookies = false)
		{
			return null;
		}
	}

	internal readonly int MaxStackDepth;

	internal readonly int MaxContinuationDepth;

	internal readonly Instruction[] Instructions;

	internal readonly object[] Objects;

	internal readonly RuntimeLabel[] Labels;

	internal readonly List<KeyValuePair<int, object>> DebugCookies;

	internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies)
	{
		MaxStackDepth = 0;
		MaxContinuationDepth = 0;
		Instructions = null;
		Objects = null;
		Labels = null;
		DebugCookies = null;
	}
}
