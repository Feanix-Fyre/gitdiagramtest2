using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unity.Burst.Intrinsics;

[StructLayout((LayoutKind)2)]
[DebuggerTypeProxy(typeof(V64DebugView))]
public struct v64
{
	[FieldOffset(0)]
	public byte Byte0;

	[FieldOffset(1)]
	public byte Byte1;

	[FieldOffset(2)]
	public byte Byte2;

	[FieldOffset(3)]
	public byte Byte3;

	[FieldOffset(4)]
	public byte Byte4;

	[FieldOffset(5)]
	public byte Byte5;

	[FieldOffset(6)]
	public byte Byte6;

	[FieldOffset(7)]
	public byte Byte7;

	[FieldOffset(0)]
	public sbyte SByte0;

	[FieldOffset(1)]
	public sbyte SByte1;

	[FieldOffset(2)]
	public sbyte SByte2;

	[FieldOffset(3)]
	public sbyte SByte3;

	[FieldOffset(4)]
	public sbyte SByte4;

	[FieldOffset(5)]
	public sbyte SByte5;

	[FieldOffset(6)]
	public sbyte SByte6;

	[FieldOffset(7)]
	public sbyte SByte7;

	[FieldOffset(0)]
	public ushort UShort0;

	[FieldOffset(2)]
	public ushort UShort1;

	[FieldOffset(4)]
	public ushort UShort2;

	[FieldOffset(6)]
	public ushort UShort3;

	[FieldOffset(0)]
	public short SShort0;

	[FieldOffset(2)]
	public short SShort1;

	[FieldOffset(4)]
	public short SShort2;

	[FieldOffset(6)]
	public short SShort3;

	[FieldOffset(0)]
	public uint UInt0;

	[FieldOffset(4)]
	public uint UInt1;

	[FieldOffset(0)]
	public int SInt0;

	[FieldOffset(4)]
	public int SInt1;

	[FieldOffset(0)]
	public ulong ULong0;

	[FieldOffset(0)]
	public long SLong0;

	[FieldOffset(0)]
	public float Float0;

	[FieldOffset(4)]
	public float Float1;

	[FieldOffset(0)]
	public double Double0;

	public v64(byte b)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(sbyte b)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(short v)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(short a, short b, short c, short d)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(ushort v)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(ushort a, ushort b, ushort c, ushort d)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(int v)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(int a, int b)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(uint v)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(uint a, uint b)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(float f)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(float a, float b)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(double a)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(long a)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}

	public v64(ulong a)
	{
		Byte0 = 0;
		Byte1 = 0;
		Byte2 = 0;
		Byte3 = 0;
		Byte4 = 0;
		Byte5 = 0;
		Byte6 = 0;
		Byte7 = 0;
		SByte0 = 0;
		SByte1 = 0;
		SByte2 = 0;
		SByte3 = 0;
		SByte4 = 0;
		SByte5 = 0;
		SByte6 = 0;
		SByte7 = 0;
		UShort0 = 0;
		UShort1 = 0;
		UShort2 = 0;
		UShort3 = 0;
		SShort0 = 0;
		SShort1 = 0;
		SShort2 = 0;
		SShort3 = 0;
		UInt0 = 0u;
		UInt1 = 0u;
		SInt0 = 0;
		SInt1 = 0;
		ULong0 = 0uL;
		SLong0 = 0L;
		Float0 = 0f;
		Float1 = 0f;
		Double0 = 0.0;
	}
}
