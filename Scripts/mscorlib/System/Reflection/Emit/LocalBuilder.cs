using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

/// <summary>Represents a local variable within a method or constructor.</summary>
[StructLayout((LayoutKind)0)]
public sealed class LocalBuilder : LocalVariableInfo
{
	private string name;

	internal ILGenerator ilgen;

	private int startOffset;

	private int endOffset;
}
