using System;
using System.Runtime.CompilerServices;

namespace Unity.Collections;

[BurstCompatible]
[BurstCompatible]
[BurstCompatible]
[BurstCompatible]
public static class FixedStringMethods
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, Unicode.Rune rune) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, char ch) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError AppendRawByte<T>(this ref T fs, byte a) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, Unicode.Rune rune, int count) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, long input) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, int input) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, ulong input) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, uint input) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Append<T>(this ref T fs, float input, char decimalSeparator = '.') where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static FormatError Append<T, T2>(this ref T fs, in T2 input) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static CopyError CopyFrom<T, T2>(this ref T fs, in T2 input) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(CopyError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public unsafe static FormatError Append<T>(this ref T fs, byte* utf8Bytes, int utf8BytesLength) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[NotBurstCompatible]
	public static FormatError Append<T>(this ref T fs, string s) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[NotBurstCompatible]
	public static CopyError CopyFrom<T>(this ref T fs, string s) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(CopyError);
	}

	[NotBurstCompatible]
	public static void CopyFromTruncated<T>(this ref T fs, string s) where T : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0>(this ref T dest, in U format, in T0 arg0) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1>(this ref T dest, in U format, in T0 arg0, in T1 arg1) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2, T3>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2, T3, T4>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes where T4 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2, T3, T4, T5>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes where T4 : struct, INativeList<byte>, IUTF8Bytes where T5 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes where T4 : struct, INativeList<byte>, IUTF8Bytes where T5 : struct, INativeList<byte>, IUTF8Bytes where T6 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes where T4 : struct, INativeList<byte>, IUTF8Bytes where T5 : struct, INativeList<byte>, IUTF8Bytes where T6 : struct, INativeList<byte>, IUTF8Bytes where T7 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes where T4 : struct, INativeList<byte>, IUTF8Bytes where T5 : struct, INativeList<byte>, IUTF8Bytes where T6 : struct, INativeList<byte>, IUTF8Bytes where T7 : struct, INativeList<byte>, IUTF8Bytes where T8 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9) where T : struct, INativeList<byte>, IUTF8Bytes where U : struct, INativeList<byte>, IUTF8Bytes where T0 : struct, INativeList<byte>, IUTF8Bytes where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes where T4 : struct, INativeList<byte>, IUTF8Bytes where T5 : struct, INativeList<byte>, IUTF8Bytes where T6 : struct, INativeList<byte>, IUTF8Bytes where T7 : struct, INativeList<byte>, IUTF8Bytes where T8 : struct, INativeList<byte>, IUTF8Bytes where T9 : struct, INativeList<byte>, IUTF8Bytes
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	internal static FormatError Append<T>(this ref T fs, char a, char b) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	internal static FormatError Append<T>(this ref T fs, char a, char b, char c) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	internal static FormatError Append<T>(this ref T fs, char a, char b, char c, char d, char e, char f, char g, char h) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	internal unsafe static FormatError AppendScientific<T>(this ref T fs, char* source, int sourceLength, int decimalExponent, char decimalSeparator = '.') where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	internal static bool Found<T>(this ref T fs, ref int offset, char a, char b, char c) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	internal static bool Found<T>(this ref T fs, ref int offset, char a, char b, char c, char d, char e, char f, char g, char h) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public unsafe static int IndexOf<T>(this ref T fs, byte* bytes, int bytesLen) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public unsafe static int IndexOf<T>(this ref T fs, byte* bytes, int bytesLen, int startIndex, int distance = int.MaxValue) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static int IndexOf<T, T2>(this ref T fs, in T2 other) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static int IndexOf<T, T2>(this ref T fs, in T2 other, int startIndex, int distance = int.MaxValue) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static bool Contains<T, T2>(this ref T fs, in T2 other) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public unsafe static int LastIndexOf<T>(this ref T fs, byte* bytes, int bytesLen) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public unsafe static int LastIndexOf<T>(this ref T fs, byte* bytes, int bytesLen, int startIndex, int distance = int.MaxValue) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static int LastIndexOf<T, T2>(this ref T fs, in T2 other) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static int LastIndexOf<T, T2>(this ref T fs, in T2 other, int startIndex, int distance = int.MaxValue) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public unsafe static int CompareTo<T>(this ref T fs, byte* bytes, int bytesLen) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static int CompareTo<T, T2>(this ref T fs, in T2 other) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public unsafe static bool Equals<T>(this ref T fs, byte* bytes, int bytesLen) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString128Bytes),
		typeof(FixedString128Bytes)
	})]
	public static bool Equals<T, T2>(this ref T fs, in T2 other) where T : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static Unicode.Rune Peek<T>(this ref T fs, int index) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(Unicode.Rune);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static Unicode.Rune Read<T>(this ref T fs, ref int index) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(Unicode.Rune);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static FormatError Write<T>(this ref T fs, ref int index, Unicode.Rune rune) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FormatError);
	}

	[NotBurstCompatible]
	public static string ConvertToString<T>(this ref T fs) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return null;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static int ComputeHashCode<T>(this ref T fs) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static int EffectiveSizeOf<T>(this ref T fs) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	internal static bool ParseLongInternal<T>(ref T fs, ref int offset, out long value) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		value = default(long);
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static ParseError Parse<T>(this ref T fs, ref int offset, ref int output) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(ParseError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static ParseError Parse<T>(this ref T fs, ref int offset, ref uint output) where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(ParseError);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString128Bytes) })]
	public static ParseError Parse<T>(this ref T fs, ref int offset, ref float output, char decimalSeparator = '.') where T : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(ParseError);
	}
}
