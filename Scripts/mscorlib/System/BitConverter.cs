using System.Runtime.CompilerServices;

namespace System;

/// <summary>Converts base data types to an array of bytes, and an array of bytes to base data types.</summary>
public static class BitConverter
{
	/// <summary>Indicates the byte order ("endianness") in which data is stored in this computer architecture.</summary>
	[Intrinsic]
	public static readonly bool IsLittleEndian;

	/// <summary>Returns the specified Boolean value as a byte array.</summary>
	/// <param name="value">A Boolean value.</param>
	/// <returns>A byte array with length 1.</returns>
	public static byte[] GetBytes(bool value)
	{
		return null;
	}

	/// <summary>Returns the specified Unicode character value as an array of bytes.</summary>
	/// <param name="value">A character to convert.</param>
	/// <returns>An array of bytes with length 2.</returns>
	public static byte[] GetBytes(char value)
	{
		return null;
	}

	/// <summary>Returns the specified 16-bit signed integer value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 2.</returns>
	public static byte[] GetBytes(short value)
	{
		return null;
	}

	/// <summary>Returns the specified 32-bit signed integer value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 4.</returns>
	public static byte[] GetBytes(int value)
	{
		return null;
	}

	/// <summary>Returns the specified 64-bit signed integer value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 8.</returns>
	public static byte[] GetBytes(long value)
	{
		return null;
	}

	/// <summary>Returns the specified 16-bit unsigned integer value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 2.</returns>
	[CLSCompliant(false)]
	public static byte[] GetBytes(ushort value)
	{
		return null;
	}

	/// <summary>Returns the specified 32-bit unsigned integer value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 4.</returns>
	[CLSCompliant(false)]
	public static byte[] GetBytes(uint value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public static bool TryWriteBytes(Span<byte> destination, uint value)
	{
		return false;
	}

	/// <summary>Returns the specified 64-bit unsigned integer value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 8.</returns>
	[CLSCompliant(false)]
	public static byte[] GetBytes(ulong value)
	{
		return null;
	}

	/// <summary>Returns the specified single-precision floating point value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 4.</returns>
	public static byte[] GetBytes(float value)
	{
		return null;
	}

	/// <summary>Returns the specified double-precision floating point value as an array of bytes.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>An array of bytes with length 8.</returns>
	public static byte[] GetBytes(double value)
	{
		return null;
	}

	/// <summary>Returns a 16-bit signed integer converted from two bytes at a specified position in a byte array.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A 16-bit signed integer formed by two bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> equals the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	public static short ToInt16(byte[] value, int startIndex)
	{
		return 0;
	}

	/// <summary>Returns a 32-bit signed integer converted from four bytes at a specified position in a byte array.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A 32-bit signed integer formed by four bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 3, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	public static int ToInt32(byte[] value, int startIndex)
	{
		return 0;
	}

	/// <summary>Returns a 64-bit signed integer converted from eight bytes at a specified position in a byte array.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A 64-bit signed integer formed by eight bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 7, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	public static long ToInt64(byte[] value, int startIndex)
	{
		return 0L;
	}

	/// <summary>Returns a 16-bit unsigned integer converted from two bytes at a specified position in a byte array.</summary>
	/// <param name="value">The array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A 16-bit unsigned integer formed by two bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> equals the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(byte[] value, int startIndex)
	{
		return 0;
	}

	/// <summary>Returns a 32-bit unsigned integer converted from four bytes at a specified position in a byte array.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A 32-bit unsigned integer formed by four bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 3, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(byte[] value, int startIndex)
	{
		return 0u;
	}

	/// <summary>Returns a 64-bit unsigned integer converted from eight bytes at a specified position in a byte array.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A 64-bit unsigned integer formed by the eight bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 7, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(byte[] value, int startIndex)
	{
		return 0uL;
	}

	/// <summary>Returns a single-precision floating point number converted from four bytes at a specified position in a byte array.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A single-precision floating point number formed by four bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 3, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	public static float ToSingle(byte[] value, int startIndex)
	{
		return 0f;
	}

	/// <summary>Returns a double-precision floating point number converted from eight bytes at a specified position in a byte array.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <returns>A double precision floating point number formed by eight bytes beginning at <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 7, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1.</exception>
	public static double ToDouble(byte[] value, int startIndex)
	{
		return 0.0;
	}

	/// <summary>Converts the numeric value of each element of a specified subarray of bytes to its equivalent hexadecimal string representation.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <param name="length">The number of array elements in <paramref name="value" /> to convert.</param>
	/// <returns>A string of hexadecimal pairs separated by hyphens, where each pair represents the corresponding element in a subarray of <paramref name="value" />; for example, "7F-2C-4A-00".</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> is greater than zero and is greater than or equal to the length of <paramref name="value" />.</exception>
	/// <exception cref="T:System.ArgumentException">The combination of <paramref name="startIndex" /> and <paramref name="length" /> does not specify a position within <paramref name="value" />; that is, the <paramref name="startIndex" /> parameter is greater than the length of <paramref name="value" /> minus the <paramref name="length" /> parameter.</exception>
	public static string ToString(byte[] value, int startIndex, int length)
	{
		return null;
	}

	/// <summary>Converts the numeric value of each element of a specified array of bytes to its equivalent hexadecimal string representation.</summary>
	/// <param name="value">An array of bytes.</param>
	/// <returns>A string of hexadecimal pairs separated by hyphens, where each pair represents the corresponding element in <paramref name="value" />; for example, "7F-2C-4A-00".</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public static string ToString(byte[] value)
	{
		return null;
	}

	/// <summary>Converts the specified double-precision floating point number to a 64-bit signed integer.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>A 64-bit signed integer whose value is equivalent to <paramref name="value" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long DoubleToInt64Bits(double value)
	{
		return 0L;
	}

	/// <summary>Converts the specified 64-bit signed integer to a double-precision floating point number.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>A double-precision floating point number whose value is equivalent to <paramref name="value" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Int64BitsToDouble(long value)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int SingleToInt32Bits(float value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Int32BitsToSingle(int value)
	{
		return 0f;
	}

	static BitConverter()
	{
	}
}
