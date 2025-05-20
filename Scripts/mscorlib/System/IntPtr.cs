using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>A platform-specific type that is used to represent a pointer or a handle.</summary>
[Serializable]
[ComVisible(true)]
public readonly struct IntPtr : ISerializable, IEquatable<IntPtr>
{
	private unsafe readonly void* m_value;

	/// <summary>A read-only field that represents a pointer or handle that has been initialized to zero.</summary>
	public static readonly IntPtr Zero;

	/// <summary>Gets the size of this instance.</summary>
	/// <returns>The size of a pointer or handle in this process, measured in bytes. The value of this property is 4 in a 32-bit process, and 8 in a 64-bit process. You can define the process type by setting the <see langword="/platform" /> switch when you compile your code with the C# and Visual Basic compilers.</returns>
	public static int Size
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	/// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified 32-bit pointer or handle.</summary>
	/// <param name="value">A pointer or handle contained in a 32-bit signed integer.</param>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public unsafe IntPtr(int value)
	{
		m_value = null;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified 64-bit pointer.</summary>
	/// <param name="value">A pointer or handle contained in a 64-bit signed integer.</param>
	/// <exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large or too small to represent as an <see cref="T:System.IntPtr" />.</exception>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public unsafe IntPtr(long value)
	{
		m_value = null;
	}

	/// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified pointer to an unspecified type.</summary>
	/// <param name="value">A pointer to an unspecified type.</param>
	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public unsafe IntPtr(void* value)
	{
		m_value = null;
	}

	private unsafe IntPtr(SerializationInfo info, StreamingContext context)
	{
		m_value = null;
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.IntPtr" /> object.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data.</param>
	/// <param name="context">The destination for this serialization. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.IntPtr" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts the value of this instance to a 32-bit signed integer.</summary>
	/// <returns>A 32-bit signed integer equal to the value of this instance.</returns>
	/// <exception cref="T:System.OverflowException">On a 64-bit platform, the value of this instance is too large or too small to represent as a 32-bit signed integer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public int ToInt32()
	{
		return 0;
	}

	/// <summary>Converts the value of this instance to a 64-bit signed integer.</summary>
	/// <returns>A 64-bit signed integer equal to the value of this instance.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public long ToInt64()
	{
		return 0L;
	}

	/// <summary>Converts the value of this instance to a pointer to an unspecified type.</summary>
	/// <returns>A pointer to <see cref="T:System.Void" />; that is, a pointer to memory containing data of an unspecified type.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[CLSCompliant(false)]
	public unsafe void* ToPointer()
	{
		return null;
	}

	/// <summary>Converts the numeric value of the current <see cref="T:System.IntPtr" /> object to its equivalent string representation.</summary>
	/// <returns>The string representation of the value of this instance.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the numeric value of the current <see cref="T:System.IntPtr" /> object to its equivalent string representation.</summary>
	/// <param name="format">A format specification that governs how the current <see cref="T:System.IntPtr" /> object is converted.</param>
	/// <returns>The string representation of the value of the current <see cref="T:System.IntPtr" /> object.</returns>
	public string ToString(string format)
	{
		return null;
	}

	/// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are equal.</summary>
	/// <param name="value1">The first pointer or handle to compare.</param>
	/// <param name="value2">The second pointer or handle to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, <see langword="false" />.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static bool operator ==(IntPtr value1, IntPtr value2)
	{
		return false;
	}

	/// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are not equal.</summary>
	/// <param name="value1">The first pointer or handle to compare.</param>
	/// <param name="value2">The second pointer or handle to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, <see langword="false" />.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static bool operator !=(IntPtr value1, IntPtr value2)
	{
		return false;
	}

	/// <summary>Converts the value of a 32-bit signed integer to an <see cref="T:System.IntPtr" />.</summary>
	/// <param name="value">A 32-bit signed integer.</param>
	/// <returns>A new instance of <see cref="T:System.IntPtr" /> initialized to <paramref name="value" />.</returns>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static explicit operator IntPtr(int value)
	{
		return (IntPtr)0;
	}

	/// <summary>Converts the value of a 64-bit signed integer to an <see cref="T:System.IntPtr" />.</summary>
	/// <param name="value">A 64-bit signed integer.</param>
	/// <returns>A new instance of <see cref="T:System.IntPtr" /> initialized to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large to represent as an <see cref="T:System.IntPtr" />.</exception>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static explicit operator IntPtr(long value)
	{
		return (IntPtr)0;
	}

	/// <summary>Converts the specified pointer to an unspecified type to an <see cref="T:System.IntPtr" />.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="value">A pointer to an unspecified type.</param>
	/// <returns>A new instance of <see cref="T:System.IntPtr" /> initialized to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public unsafe static explicit operator IntPtr(void* value)
	{
		return (IntPtr)0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.IntPtr" /> to a 32-bit signed integer.</summary>
	/// <param name="value">The pointer or handle to convert.</param>
	/// <returns>The contents of <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">On a 64-bit platform, the value of <paramref name="value" /> is too large to represent as a 32-bit signed integer.</exception>
	public static explicit operator int(IntPtr value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.IntPtr" /> to a 64-bit signed integer.</summary>
	/// <param name="value">The pointer or handle to convert.</param>
	/// <returns>The contents of <paramref name="value" />.</returns>
	public static explicit operator long(IntPtr value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified <see cref="T:System.IntPtr" /> to a pointer to an unspecified type.  
	///  This API is not CLS-compliant.</summary>
	/// <param name="value">The pointer or handle to convert.</param>
	/// <returns>The contents of <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public unsafe static explicit operator void*(IntPtr value)
	{
		return null;
	}

	/// <summary>Adds an offset to the value of a pointer.</summary>
	/// <param name="pointer">The pointer to add the offset to.</param>
	/// <param name="offset">The offset to add.</param>
	/// <returns>A new pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static IntPtr Add(IntPtr pointer, int offset)
	{
		return (IntPtr)0;
	}

	/// <summary>Adds an offset to the value of a pointer.</summary>
	/// <param name="pointer">The pointer to add the offset to.</param>
	/// <param name="offset">The offset to add.</param>
	/// <returns>A new pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static IntPtr operator +(IntPtr pointer, int offset)
	{
		return (IntPtr)0;
	}

	/// <summary>Subtracts an offset from the value of a pointer.</summary>
	/// <param name="pointer">The pointer to subtract the offset from.</param>
	/// <param name="offset">The offset to subtract.</param>
	/// <returns>A new pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static IntPtr operator -(IntPtr pointer, int offset)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal bool IsNull()
	{
		return false;
	}

	bool IEquatable<IntPtr>.Equals(IntPtr other)
	{
		return false;
	}
}
