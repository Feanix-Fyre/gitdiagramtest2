using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace Unity.Burst;

internal static class Unsafe
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static T Read<T>(void* source)
	{
		return default(T);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static T ReadUnaligned<T>(void* source)
	{
		return default(T);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static T ReadUnaligned<T>(ref byte source)
	{
		return default(T);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void Write<T>(void* destination, T value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void WriteUnaligned<T>(void* destination, T value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static void WriteUnaligned<T>(ref byte destination, T value)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void Copy<T>(void* destination, ref T source)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void Copy<T>(ref T destination, void* source)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void* AsPointer<T>(ref T value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static int SizeOf<T>()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void CopyBlock(void* destination, void* source, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void CopyBlockUnaligned(void* destination, void* source, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void InitBlock(void* startAddress, byte value, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static void InitBlock(ref byte startAddress, byte value, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static T As<T>(object o) where T : class
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static ref T AsRef<T>(void* source)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T AsRef<T>(in T source)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref TTo As<TFrom, TTo>(ref TFrom source)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T Unbox<T>(object box) where T : struct
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T Add<T>(ref T source, int elementOffset)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void* Add<T>(void* source, int elementOffset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T Add<T>(ref T source, IntPtr elementOffset)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T Subtract<T>(ref T source, int elementOffset)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public unsafe static void* Subtract<T>(void* source, int elementOffset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T Subtract<T>(ref T source, IntPtr elementOffset)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static ref T SubtractByteOffset<T>(ref T source, IntPtr byteOffset)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static IntPtr ByteOffset<T>(ref T origin, ref T target)
	{
		return (IntPtr)0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static bool AreSame<T>(ref T left, ref T right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static bool IsAddressGreaterThan<T>(ref T left, ref T right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[System.Runtime.Versioning.NonVersionable]
	public static bool IsAddressLessThan<T>(ref T left, ref T right)
	{
		return false;
	}
}
