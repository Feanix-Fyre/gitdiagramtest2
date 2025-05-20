using System.Runtime.InteropServices;

namespace System.Numerics;

[StructLayout((LayoutKind)2)]
internal struct DoubleUlong
{
	[FieldOffset(0)]
	public double dbl;

	[FieldOffset(0)]
	public ulong uu;
}
