using System.Diagnostics;

namespace Unity.Burst.Intrinsics;

internal class V128DebugView
{
	private v128 m_Value;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public byte[] Byte => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public sbyte[] SByte => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public ushort[] UShort => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public short[] SShort => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public uint[] UInt => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public int[] SInt => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public float[] Float => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public long[] SLong => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public ulong[] ULong => null;

	[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
	public double[] Double => null;

	public V128DebugView(v128 value)
	{
	}
}
