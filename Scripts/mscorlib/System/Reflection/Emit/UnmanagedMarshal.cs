using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

/// <summary>Represents the class that describes how to marshal a field from managed to unmanaged code. This class cannot be inherited.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
public sealed class UnmanagedMarshal
{
	private UnmanagedMarshal()
	{
	}
}
