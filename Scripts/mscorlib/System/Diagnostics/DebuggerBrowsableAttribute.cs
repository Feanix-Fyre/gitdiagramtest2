using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Determines if and how a member is displayed in the debugger variable windows. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
[ComVisible(true)]
public sealed class DebuggerBrowsableAttribute : Attribute
{
	private DebuggerBrowsableState state;

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerBrowsableAttribute" /> class.</summary>
	/// <param name="state">One of the <see cref="T:System.Diagnostics.DebuggerBrowsableState" /> values that specifies how to display the member.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="state" /> is not one of the <see cref="T:System.Diagnostics.DebuggerBrowsableState" /> values.</exception>
	public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
	{
	}
}
