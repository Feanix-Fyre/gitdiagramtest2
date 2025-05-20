using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Mathematics;

namespace Unity.Collections;

[BurstCompatible]
[BurstCompatible]
[BurstCompatible]
[BurstCompile]
public static class xxHash3
{
	private struct ulong2
	{
		public ulong x;

		public ulong y;

		public ulong2(ulong x, ulong y)
		{
			this.x = 0uL;
			this.y = 0uL;
		}
	}

	[BurstCompatible]
	public struct StreamingState
	{
		[StructLayout((LayoutKind)2)]
		private struct StreamingStateData
		{
			[FieldOffset(0)]
			public ulong Acc;

			[FieldOffset(64)]
			public byte Buffer;

			[FieldOffset(320)]
			public int IsHash64;

			[FieldOffset(324)]
			public int BufferedSize;

			[FieldOffset(328)]
			public int NbStripesSoFar;

			[FieldOffset(336)]
			public long TotalLength;

			[FieldOffset(344)]
			public ulong Seed;

			[FieldOffset(352)]
			public byte SecretKey;

			[FieldOffset(540)]
			public byte _PadEnd;
		}

		private static readonly int SECRET_LIMIT;

		private static readonly int NB_STRIPES_PER_BLOCK;

		private static readonly int INTERNAL_BUFFER_SIZE;

		private static readonly int INTERNAL_BUFFER_STRIPES;

		private StreamingStateData State;

		private unsafe ulong* Acc
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		private unsafe byte* Buffer
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		private unsafe byte* SecretKey
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public StreamingState(bool isHash64, ulong seed = 0uL)
		{
			State = default(StreamingStateData);
		}

		public void Reset(bool isHash64, ulong seed = 0uL)
		{
		}

		public unsafe void Update(void* input, int length)
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public void Update<T>(in T input) where T : struct
		{
		}

		public uint4 DigestHash128()
		{
			return default(uint4);
		}

		public uint2 DigestHash64()
		{
			return default(uint2);
		}

		private unsafe void DigestLong(ulong* acc, byte* secret, int isHash64)
		{
		}

		private unsafe void ConsumeStripes(ulong* acc, ref int nbStripesSoFar, byte* input, long totalStripes, byte* secret, int isHash64)
		{
		}

		[BurstDiscard]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckKeySize(int isHash64)
		{
		}
	}

	public unsafe delegate ulong Hash64Long_000008F4_0024PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret);

	internal static class Hash64Long_000008F4_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public unsafe static ulong Invoke(byte* input, byte* dest, long length, byte* secret)
		{
			return 0uL;
		}
	}

	public unsafe delegate void Hash128Long_000008FB_0024PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret, out uint4 result);

	internal static class Hash128Long_000008FB_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public unsafe static void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result)
		{
			result = default(uint4);
		}
	}

	private const int STRIPE_LEN = 64;

	private const int ACC_NB = 8;

	private const int SECRET_CONSUME_RATE = 8;

	private const int SECRET_KEY_SIZE = 192;

	private const int SECRET_KEY_MIN_SIZE = 136;

	private const int SECRET_LASTACC_START = 7;

	private const int NB_ROUNDS = 16;

	private const int BLOCK_LEN = 1024;

	private const uint PRIME32_1 = 2654435761u;

	private const uint PRIME32_2 = 2246822519u;

	private const uint PRIME32_3 = 3266489917u;

	private const uint PRIME32_5 = 374761393u;

	private const ulong PRIME64_1 = 11400714785074694791uL;

	private const ulong PRIME64_2 = 14029467366897019727uL;

	private const ulong PRIME64_3 = 1609587929392839161uL;

	private const ulong PRIME64_4 = 9650029242287828579uL;

	private const ulong PRIME64_5 = 2870177450012600261uL;

	private const int MIDSIZE_MAX = 240;

	private const int MIDSIZE_STARTOFFSET = 3;

	private const int MIDSIZE_LASTOFFSET = 17;

	private const int SECRET_MERGEACCS_START = 11;

	internal unsafe static void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64)
	{
	}

	internal unsafe static void Avx2ScrambleAcc(ulong* acc, byte* secret)
	{
	}

	internal unsafe static void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64)
	{
	}

	internal unsafe static void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret)
	{
	}

	public unsafe static uint2 Hash64(void* input, long length)
	{
		return default(uint2);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static uint2 Hash64<T>(in T input) where T : struct
	{
		return default(uint2);
	}

	public unsafe static uint2 Hash64(void* input, long length, ulong seed)
	{
		return default(uint2);
	}

	public unsafe static uint4 Hash128(void* input, long length)
	{
		return default(uint4);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static uint4 Hash128<T>(in T input) where T : struct
	{
		return default(uint4);
	}

	public unsafe static uint4 Hash128(void* input, void* destination, long length)
	{
		return default(uint4);
	}

	public unsafe static uint4 Hash128(void* input, long length, ulong seed)
	{
		return default(uint4);
	}

	public unsafe static uint4 Hash128(void* input, void* destination, long length, ulong seed)
	{
		return default(uint4);
	}

	internal unsafe static ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed)
	{
		return 0uL;
	}

	internal unsafe static void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result)
	{
		result = default(uint4);
	}

	private unsafe static ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed)
	{
		return 0uL;
	}

	private unsafe static ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed)
	{
		return 0uL;
	}

	private unsafe static ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed)
	{
		return 0uL;
	}

	private unsafe static ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed)
	{
		return 0uL;
	}

	private unsafe static ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed)
	{
		return 0uL;
	}

	private unsafe static ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed)
	{
		return 0uL;
	}

	[BurstCompile]
	private unsafe static ulong Hash64Long(byte* input, byte* dest, long length, byte* secret)
	{
		return 0uL;
	}

	private unsafe static void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result)
	{
		result = default(uint4);
	}

	private unsafe static void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result)
	{
		result = default(uint4);
	}

	private unsafe static void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result)
	{
		result = default(uint4);
	}

	private unsafe static void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result)
	{
		result = default(uint4);
	}

	private unsafe static void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result)
	{
		result = default(uint4);
	}

	private unsafe static void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result)
	{
		result = default(uint4);
	}

	[BurstCompile]
	private unsafe static void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result)
	{
		result = default(uint4);
	}

	internal static uint2 ToUint2(ulong u)
	{
		return default(uint2);
	}

	internal static uint4 ToUint4(ulong ul0, ulong ul1)
	{
		return default(uint4);
	}

	internal unsafe static void EncodeSecretKey(byte* dst, byte* secret, ulong seed)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static ulong Read64LE(void* addr)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static uint Read32LE(void* addr)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void Write64LE(void* addr, ulong value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void Read32LE(void* addr, uint value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong Mul32To64(uint x, uint y)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong Swap64(ulong x)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint Swap32(uint x)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint RotL32(uint x, int r)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong RotL64(ulong x, int r)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong XorShift64(ulong v64, int shift)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong Mul128Fold64(ulong lhs, ulong rhs)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static ulong Mix16(byte* input, byte* secret, ulong seed)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static ulong2 Mix32(ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed)
	{
		return default(ulong2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong Avalanche(ulong h64)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong AvalancheH64(ulong h64)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ulong rrmxmx(ulong h64, ulong length)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret)
	{
		return 0uL;
	}

	internal unsafe static ulong MergeAcc(ulong* acc, byte* secret, ulong start)
	{
		return 0uL;
	}

	private unsafe static void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64)
	{
	}

	internal unsafe static void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64)
	{
	}

	internal unsafe static void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64)
	{
	}

	internal unsafe static void DefaultScrambleAcc(ulong* acc, byte* secret)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	public unsafe static ulong Hash64Long_0024BurstManaged(byte* input, byte* dest, long length, byte* secret)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	public unsafe static void Hash128Long_0024BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result)
	{
		result = default(uint4);
	}
}
