using System.Runtime.InteropServices;

namespace Unity.Collections;

[BurstCompatible]
internal static class FixedStringUtils
{
	[StructLayout((LayoutKind)2)]
	internal struct UintFloatUnion
	{
		[FieldOffset(0)]
		public uint uintValue;

		[FieldOffset(0)]
		public float floatValue;
	}

	internal static ParseError Base10ToBase2(ref float output, ulong mantissa10, int exponent10)
	{
		return default(ParseError);
	}

	internal static void Base2ToBase10(ref ulong mantissa10, ref int exponent10, float input)
	{
	}
}
