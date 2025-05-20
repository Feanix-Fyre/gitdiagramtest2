using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions;

/// <summary>Emits or clears a sequence point for debug information. This allows the debugger to highlight the correct source code when debugging.</summary>
[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
public class DebugInfoExpression : Expression
{
	/// <summary>Gets the start line of this <see cref="T:System.Linq.Expressions.DebugInfoExpression" />.</summary>
	/// <returns>The number of the start line of the code that was used to generate the wrapped expression.</returns>
	[ExcludeFromCodeCoverage]
	public virtual int StartLine => 0;

	/// <summary>Gets the end line of this <see cref="T:System.Linq.Expressions.DebugInfoExpression" />.</summary>
	/// <returns>The number of the end line of the code that was used to generate the wrapped expression.</returns>
	[ExcludeFromCodeCoverage]
	public virtual int EndLine => 0;

	/// <summary>Gets the <see cref="T:System.Linq.Expressions.SymbolDocumentInfo" /> that represents the source file.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.SymbolDocumentInfo" /> that represents the source file.</returns>
	public SymbolDocumentInfo Document { get; }

	/// <summary>Gets the value to indicate if the <see cref="T:System.Linq.Expressions.DebugInfoExpression" /> is for clearing a sequence point.</summary>
	/// <returns>True if the <see cref="T:System.Linq.Expressions.DebugInfoExpression" /> is for clearing a sequence point, otherwise false.</returns>
	[ExcludeFromCodeCoverage]
	public virtual bool IsClear => false;
}
