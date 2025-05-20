using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Specifies the <see cref="T:System.Diagnostics.DebuggerHiddenAttribute" />. This class cannot be inherited.</summary>
[Serializable]
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
public sealed class DebuggerHiddenAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerHiddenAttribute" /> class.</summary>
	public DebuggerHiddenAttribute()
	{
	}
}
