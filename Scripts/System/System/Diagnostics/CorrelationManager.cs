using System.Collections;

namespace System.Diagnostics;

/// <summary>Correlates traces that are part of a logical transaction.</summary>
public class CorrelationManager
{
	/// <summary>Gets the logical operation stack from the call context.</summary>
	/// <returns>A <see cref="T:System.Collections.Stack" /> object that represents the logical operation stack for the call context.</returns>
	public Stack LogicalOperationStack => null;

	internal CorrelationManager()
	{
	}

	private Stack GetLogicalOperationStack()
	{
		return null;
	}
}
