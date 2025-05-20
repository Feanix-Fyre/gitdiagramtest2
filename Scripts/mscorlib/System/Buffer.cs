using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System;

/// <summary>Manipulates arrays of primitive types.</summary>
[ComVisible(true)]
public static class Buffer
{
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount)
	{
		return false;
	}

	internal unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
	{
		return 0;
	}

	private static int _ByteLength(Array array)
	{
		return 0;
	}

	internal unsafe static void ZeroMemory(byte* src, long len)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len)
	{
	}

	internal unsafe static void InternalMemcpy(byte* dest, byte* src, int count)
	{
	}

	/// <summary>Returns the number of bytes in the specified array.</summary>
	/// <param name="array">An array.</param>
	/// <returns>The number of bytes in the array.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is not a primitive.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="array" /> is larger than 2 gigabytes (GB).</exception>
	public static int ByteLength(Array array)
	{
		return 0;
	}

	/// <summary>Copies a specified number of bytes from a source array starting at a particular offset to a destination array starting at a particular offset.</summary>
	/// <param name="src">The source buffer.</param>
	/// <param name="srcOffset">The zero-based byte offset into <paramref name="src" />.</param>
	/// <param name="dst">The destination buffer.</param>
	/// <param name="dstOffset">The zero-based byte offset into <paramref name="dst" />.</param>
	/// <param name="count">The number of bytes to copy.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="src" /> or <paramref name="dst" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="src" /> or <paramref name="dst" /> is not an array of primitives.  
	/// -or-  
	/// The number of bytes in <paramref name="src" /> is less than <paramref name="srcOffset" /> plus <paramref name="count" />.  
	/// -or-  
	/// The number of bytes in <paramref name="dst" /> is less than <paramref name="dstOffset" /> plus <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="srcOffset" />, <paramref name="dstOffset" />, or <paramref name="count" /> is less than 0.</exception>
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
	{
	}

	/// <summary>Copies a number of bytes specified as a long integer value from one address in memory to another.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="source">The address of the bytes to copy.</param>
	/// <param name="destination">The target address.</param>
	/// <param name="destinationSizeInBytes">The number of bytes available in the destination memory block.</param>
	/// <param name="sourceBytesToCopy">The number of bytes to copy.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="sourceBytesToCopy" /> is greater than <paramref name="destinationSizeInBytes" />.</exception>
	[CLSCompliant(false)]
	public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
	{
	}

	internal unsafe static void memcpy4(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy2(byte* dest, byte* src, int size)
	{
	}

	private unsafe static void memcpy1(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void Memcpy(byte* dest, byte* src, int len)
	{
	}

	internal unsafe static void Memmove(byte* dest, byte* src, uint len)
	{
	}

	internal static void Memmove<T>(ref T destination, ref T source, ulong elementCount)
	{
	}
}
