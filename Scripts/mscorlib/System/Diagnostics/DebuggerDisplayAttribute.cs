using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Determines how a class or field is displayed in the debugger variable windows.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Delegate, AllowMultiple = true)]
public sealed class DebuggerDisplayAttribute : Attribute
{
	private string name;

	private string value;

	private string type;

	/// <summary>Gets or sets the name to display in the debugger variable windows.</summary>
	/// <returns>The name to display in the debugger variable windows.</returns>
	public string Name
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the string to display in the type column of the debugger variable windows.</summary>
	/// <returns>The string to display in the type column of the debugger variable windows.</returns>
	public string Type
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerDisplayAttribute" /> class.</summary>
	/// <param name="value">The string to be displayed in the value column for instances of the type; an empty string ("") causes the value column to be hidden.</param>
	public DebuggerDisplayAttribute(string value)
	{
	}
}
