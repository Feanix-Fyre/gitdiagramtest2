using System.Runtime.InteropServices;

namespace System.Reflection;

/// <summary>Discovers the attributes of a local variable and provides access to local variable metadata.</summary>
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class LocalVariableInfo
{
	internal Type type;

	internal bool is_pinned;

	internal ushort position;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.LocalVariableInfo" /> class.</summary>
	protected LocalVariableInfo()
	{
	}

	/// <summary>Returns a user-readable string that describes the local variable.</summary>
	/// <returns>A string that displays information about the local variable, including the type name, index, and pinned status.</returns>
	public override string ToString()
	{
		return null;
	}
}
