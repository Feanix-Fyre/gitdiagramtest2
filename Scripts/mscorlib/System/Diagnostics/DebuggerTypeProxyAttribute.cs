using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Specifies the display proxy for a type.</summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
[ComVisible(true)]
public sealed class DebuggerTypeProxyAttribute : Attribute
{
	private string typeName;

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerTypeProxyAttribute" /> class using the type of the proxy.</summary>
	/// <param name="type">The proxy type.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	public DebuggerTypeProxyAttribute(Type type)
	{
	}
}
