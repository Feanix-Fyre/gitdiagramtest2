using System;
using System.Runtime.InteropServices;

namespace Unity.Burst;

public static class BurstRuntime
{
	[StructLayout((LayoutKind)0, Size = 1)]
	private struct HashCode32<T>
	{
		public static readonly int Value;
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct HashCode64<T>
	{
		public static readonly long Value;
	}

	internal class PreserveAttribute : Attribute
	{
	}

	public static int GetHashCode32<T>()
	{
		return 0;
	}

	public static int GetHashCode32(Type type)
	{
		return 0;
	}

	public static long GetHashCode64<T>()
	{
		return 0L;
	}

	public static long GetHashCode64(Type type)
	{
		return 0L;
	}

	internal static int HashStringWithFNV1A32(string text)
	{
		return 0;
	}

	internal static long HashStringWithFNV1A64(string text)
	{
		return 0L;
	}

	public static bool LoadAdditionalLibrary(string pathToLibBurstGenerated)
	{
		return false;
	}

	internal static bool LoadAdditionalLibraryInternal(string pathToLibBurstGenerated)
	{
		return false;
	}

	[Preserve]
	internal unsafe static void RuntimeLog(byte* message, int logType, byte* fileName, int lineNumber)
	{
	}

	internal static void Initialize()
	{
	}

	[Preserve]
	internal static void PreventRequiredAttributeStrip()
	{
	}

	[Preserve]
	internal unsafe static void Log(byte* message, int logType, byte* fileName, int lineNumber)
	{
	}

	public unsafe static byte* GetUTF8LiteralPointer(string str, out int byteCount)
	{
		byteCount = default(int);
		return null;
	}
}
