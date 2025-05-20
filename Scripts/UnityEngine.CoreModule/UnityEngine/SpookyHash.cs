using System.Runtime.InteropServices;

namespace UnityEngine;

internal static class SpookyHash
{
	[StructLayout((LayoutKind)2)]
	private struct U
	{
		[FieldOffset(0)]
		public unsafe byte* p8;

		[FieldOffset(0)]
		public unsafe uint* p32;

		[FieldOffset(0)]
		public unsafe ulong* p64;

		[FieldOffset(0)]
		public ulong i;

		public unsafe U(ushort* p8)
		{
			this.p8 = null;
			p32 = null;
			p64 = null;
			i = 0uL;
		}
	}

	private static readonly bool AllowUnalignedRead;

	private static bool AttemptDetectAllowUnalignedRead()
	{
		return false;
	}

	public unsafe static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2)
	{
	}

	private unsafe static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
	{
	}

	private static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
	{
	}

	private static void Rot64(ref ulong x, int k)
	{
	}

	private unsafe static void Short(void* message, ulong length, ulong* hash1, ulong* hash2)
	{
	}

	private static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
	{
	}

	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
	{
	}

	private unsafe static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11)
	{
	}

	private unsafe static void memset(void* dst, int value, ulong numberOfBytes)
	{
	}
}
