namespace System.Runtime.CompilerServices;

internal static class Unsafe
{
	public static ref T Add<T>(ref T source, int elementOffset)
	{
		throw null;
	}

	public static ref T Add<T>(ref T source, IntPtr elementOffset)
	{
		throw null;
	}

	public unsafe static void* Add<T>(void* source, int elementOffset)
	{
		return null;
	}

	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset)
	{
		throw null;
	}

	public static bool AreSame<T>(ref T left, ref T right)
	{
		return false;
	}

	public static T As<T>(object o) where T : class
	{
		return null;
	}

	public static ref TTo As<TFrom, TTo>(ref TFrom source)
	{
		throw null;
	}

	public unsafe static void* AsPointer<T>(ref T value)
	{
		return null;
	}

	public unsafe static ref T AsRef<T>(void* source)
	{
		throw null;
	}

	public static ref T AsRef<T>(in T source)
	{
		throw null;
	}

	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
	{
	}

	public unsafe static T Read<T>(void* source)
	{
		return default(T);
	}

	public static T ReadUnaligned<T>(ref byte source)
	{
		return default(T);
	}

	public static int SizeOf<T>()
	{
		return 0;
	}

	public static void WriteUnaligned<T>(ref byte destination, T value)
	{
	}

	public static bool IsAddressLessThan<T>(ref T left, ref T right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ref T AddByteOffset<T>(ref T source, ulong byteOffset)
	{
		throw null;
	}
}
