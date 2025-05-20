using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Text;

/// <summary>Represents a mutable string of characters. This class cannot be inherited.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
public sealed class StringBuilder : ISerializable
{
	internal char[] m_ChunkChars;

	internal StringBuilder m_ChunkPrevious;

	internal int m_ChunkLength;

	internal int m_ChunkOffset;

	internal int m_MaxCapacity;

	internal const int DefaultCapacity = 16;

	private const string CapacityField = "Capacity";

	private const string MaxCapacityField = "m_MaxCapacity";

	private const string StringValueField = "m_StringValue";

	private const string ThreadIDField = "m_currentThread";

	internal const int MaxChunkSize = 8000;

	private const int IndexLimit = 1000000;

	private const int WidthLimit = 1000000;

	/// <summary>Gets or sets the maximum number of characters that can be contained in the memory allocated by the current instance.</summary>
	/// <returns>The maximum number of characters that can be contained in the memory allocated by the current instance. Its value can range from <see cref="P:System.Text.StringBuilder.Length" /> to <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than the current length of this instance.  
	///  -or-  
	///  The value specified for a set operation is greater than the maximum capacity.</exception>
	public int Capacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the maximum capacity of this instance.</summary>
	/// <returns>The maximum number of characters this instance can hold.</returns>
	public int MaxCapacity => 0;

	/// <summary>Gets or sets the length of the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
	/// <returns>The length of this instance.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than zero or greater than <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the character at the specified character position in this instance.</summary>
	/// <param name="index">The position of the character.</param>
	/// <returns>The Unicode character at position <paramref name="index" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the bounds of this instance while setting a character.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index" /> is outside the bounds of this instance while getting a character.</exception>
	[IndexerName("Chars")]
	public char this[int index]
	{
		get
		{
			return '\0';
		}
		set
		{
		}
	}

	private Span<char> RemainingCurrentChunk
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Span<char>);
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class.</summary>
	public StringBuilder()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class using the specified capacity.</summary>
	/// <param name="capacity">The suggested starting size of this instance.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public StringBuilder(int capacity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class using the specified string.</summary>
	/// <param name="value">The string used to initialize the value of the instance. If <paramref name="value" /> is <see langword="null" />, the new <see cref="T:System.Text.StringBuilder" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />).</param>
	public StringBuilder(string value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class using the specified string and capacity.</summary>
	/// <param name="value">The string used to initialize the value of the instance. If <paramref name="value" /> is <see langword="null" />, the new <see cref="T:System.Text.StringBuilder" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />).</param>
	/// <param name="capacity">The suggested starting size of the <see cref="T:System.Text.StringBuilder" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public StringBuilder(string value, int capacity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class from the specified substring and capacity.</summary>
	/// <param name="value">The string that contains the substring used to initialize the value of this instance. If <paramref name="value" /> is <see langword="null" />, the new <see cref="T:System.Text.StringBuilder" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />).</param>
	/// <param name="startIndex">The position within <paramref name="value" /> where the substring begins.</param>
	/// <param name="length">The number of characters in the substring.</param>
	/// <param name="capacity">The suggested starting size of the <see cref="T:System.Text.StringBuilder" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> plus <paramref name="length" /> is not a position within <paramref name="value" />.</exception>
	public StringBuilder(string value, int startIndex, int length, int capacity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class that starts with a specified capacity and can grow to a specified maximum.</summary>
	/// <param name="capacity">The suggested starting size of the <see cref="T:System.Text.StringBuilder" />.</param>
	/// <param name="maxCapacity">The maximum number of characters the current string can contain.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="maxCapacity" /> is less than one, <paramref name="capacity" /> is less than zero, or <paramref name="capacity" /> is greater than <paramref name="maxCapacity" />.</exception>
	public StringBuilder(int capacity, int maxCapacity)
	{
	}

	private StringBuilder(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data necessary to deserialize the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
	/// <param name="info">The object to populate with serialization information.</param>
	/// <param name="context">The place to store and retrieve serialized data. Reserved for future use.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Converts the value of this instance to a <see cref="T:System.String" />.</summary>
	/// <returns>A string whose value is the same as this instance.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the value of a substring of this instance to a <see cref="T:System.String" />.</summary>
	/// <param name="startIndex">The starting position of the substring in this instance.</param>
	/// <param name="length">The length of the substring.</param>
	/// <returns>A string whose value is the same as the specified substring of this instance.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.  
	/// -or-  
	/// The sum of <paramref name="startIndex" /> and <paramref name="length" /> is greater than the length of the current instance.</exception>
	public string ToString(int startIndex, int length)
	{
		return null;
	}

	/// <summary>Removes all characters from the current <see cref="T:System.Text.StringBuilder" /> instance.</summary>
	/// <returns>An object whose <see cref="P:System.Text.StringBuilder.Length" /> is 0 (zero).</returns>
	public StringBuilder Clear()
	{
		return null;
	}

	/// <summary>Appends a specified number of copies of the string representation of a Unicode character to this instance.</summary>
	/// <param name="value">The character to append.</param>
	/// <param name="repeatCount">The number of times to append <paramref name="value" />.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="repeatCount" /> is less than zero.  
	/// -or-  
	/// Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
	public StringBuilder Append(char value, int repeatCount)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified subarray of Unicode characters to this instance.</summary>
	/// <param name="value">A character array.</param>
	/// <param name="startIndex">The starting position in <paramref name="value" />.</param>
	/// <param name="charCount">The number of characters to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />, and <paramref name="startIndex" /> and <paramref name="charCount" /> are not zero.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> + <paramref name="charCount" /> is greater than the length of <paramref name="value" />.  
	/// -or-  
	/// Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(char[] value, int startIndex, int charCount)
	{
		return null;
	}

	/// <summary>Appends a copy of the specified string to this instance.</summary>
	/// <param name="value">The string to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(string value)
	{
		return null;
	}

	private void AppendHelper(string value)
	{
	}

	/// <summary>Appends a copy of a specified substring to this instance.</summary>
	/// <param name="value">The string that contains the substring to append.</param>
	/// <param name="startIndex">The starting position of the substring within <paramref name="value" />.</param>
	/// <param name="count">The number of characters in <paramref name="value" /> to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />, and <paramref name="startIndex" /> and <paramref name="count" /> are not zero.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> + <paramref name="count" /> is greater than the length of <paramref name="value" />.  
	/// -or-  
	/// Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(string value, int startIndex, int count)
	{
		return null;
	}

	public StringBuilder Append(StringBuilder value)
	{
		return null;
	}

	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count)
	{
		return null;
	}

	/// <summary>Appends the default line terminator to the end of the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendLine()
	{
		return null;
	}

	/// <summary>Appends a copy of the specified string followed by the default line terminator to the end of the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
	/// <param name="value">The string to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendLine(string value)
	{
		return null;
	}

	public void CopyTo(int sourceIndex, Span<char> destination, int count)
	{
	}

	/// <summary>Removes the specified range of characters from this instance.</summary>
	/// <param name="startIndex">The zero-based position in this instance where removal begins.</param>
	/// <param name="length">The number of characters to remove.</param>
	/// <returns>A reference to this instance after the excise operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">If <paramref name="startIndex" /> or <paramref name="length" /> is less than zero, or <paramref name="startIndex" /> + <paramref name="length" /> is greater than the length of this instance.</exception>
	public StringBuilder Remove(int startIndex, int length)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified Boolean value to this instance.</summary>
	/// <param name="value">The Boolean value to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(bool value)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified <see cref="T:System.Char" /> object to this instance.</summary>
	/// <param name="value">The UTF-16-encoded code unit to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(char value)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified 8-bit unsigned integer to this instance.</summary>
	/// <param name="value">The value to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(byte value)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified 32-bit signed integer to this instance.</summary>
	/// <param name="value">The value to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(int value)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified single-precision floating-point number to this instance.</summary>
	/// <param name="value">The value to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(float value)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified double-precision floating-point number to this instance.</summary>
	/// <param name="value">The value to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(double value)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified 16-bit unsigned integer to this instance.</summary>
	/// <param name="value">The value to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	[CLSCompliant(false)]
	public StringBuilder Append(ushort value)
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified 32-bit unsigned integer to this instance.</summary>
	/// <param name="value">The value to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	[CLSCompliant(false)]
	public StringBuilder Append(uint value)
	{
		return null;
	}

	private StringBuilder AppendSpanFormattable<T>(T value) where T : IFormattable
	{
		return null;
	}

	/// <summary>Appends the string representation of a specified object to this instance.</summary>
	/// <param name="value">The object to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(object value)
	{
		return null;
	}

	/// <summary>Appends the string representation of the Unicode characters in a specified array to this instance.</summary>
	/// <param name="value">The array of characters to append.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Append(char[] value)
	{
		return null;
	}

	public StringBuilder Append(ReadOnlySpan<char> value)
	{
		return null;
	}

	/// <summary>Inserts a string into this instance at the specified character position.</summary>
	/// <param name="index">The position in this instance where insertion begins.</param>
	/// <param name="value">The string to insert.</param>
	/// <returns>A reference to this instance after the insert operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero or greater than the current length of this instance.  
	/// -or-  
	/// The current length of this <see cref="T:System.Text.StringBuilder" /> object plus the length of <paramref name="value" /> exceeds <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Insert(int index, string value)
	{
		return null;
	}

	/// <summary>Inserts the string representation of a specified Unicode character into this instance at the specified character position.</summary>
	/// <param name="index">The position in this instance where insertion begins.</param>
	/// <param name="value">The value to insert.</param>
	/// <returns>A reference to this instance after the insert operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero or greater than the length of this instance.  
	/// -or-  
	/// Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Insert(int index, char value)
	{
		return null;
	}

	/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a single argument.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">An object to format.</param>
	/// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of <paramref name="arg0" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than 0 (zero), or greater than or equal to 1.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendFormat(string format, object arg0)
	{
		return null;
	}

	/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of two arguments.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to format.</param>
	/// <param name="arg1">The second object to format.</param>
	/// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than 0 (zero), or greater than or equal to 2.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendFormat(string format, object arg0, object arg1)
	{
		return null;
	}

	/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of three arguments.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to format.</param>
	/// <param name="arg1">The second object to format.</param>
	/// <param name="arg2">The third object to format.</param>
	/// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than 0 (zero), or greater than or equal to 3.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
	{
		return null;
	}

	/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a corresponding argument in a parameter array.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="args">An array of objects to format.</param>
	/// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> or <paramref name="args" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than 0 (zero), or greater than or equal to the length of the <paramref name="args" /> array.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendFormat(string format, params object[] args)
	{
		return null;
	}

	/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a single argument using a specified format provider.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The object to format.</param>
	/// <returns>A reference to this instance after the append operation has completed. After the append operation, this instance contains any data that existed before the operation, suffixed by a copy of <paramref name="format" /> in which any format specification is replaced by the string representation of <paramref name="arg0" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than 0 (zero), or greater than or equal to one (1).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0)
	{
		return null;
	}

	/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of three arguments using a specified format provider.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to format.</param>
	/// <param name="arg1">The second object to format.</param>
	/// <param name="arg2">The third object to format.</param>
	/// <returns>A reference to this instance after the append operation has completed. After the append operation, this instance contains any data that existed before the operation, suffixed by a copy of <paramref name="format" /> where any format specification is replaced by the string representation of the corresponding object argument.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than 0 (zero), or greater than or equal to 3 (three).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
	{
		return null;
	}

	private static void FormatError()
	{
	}

	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args)
	{
		return null;
	}

	/// <summary>Replaces all occurrences of a specified string in this instance with another specified string.</summary>
	/// <param name="oldValue">The string to replace.</param>
	/// <param name="newValue">The string that replaces <paramref name="oldValue" />, or <see langword="null" />.</param>
	/// <returns>A reference to this instance with all instances of <paramref name="oldValue" /> replaced by <paramref name="newValue" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="oldValue" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The length of <paramref name="oldValue" /> is zero.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Replace(string oldValue, string newValue)
	{
		return null;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="sb">An object to compare with this instance, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if this instance and <paramref name="sb" /> have equal string, <see cref="P:System.Text.StringBuilder.Capacity" />, and <see cref="P:System.Text.StringBuilder.MaxCapacity" /> values; otherwise, <see langword="false" />.</returns>
	public bool Equals(StringBuilder sb)
	{
		return false;
	}

	/// <summary>Replaces, within a substring of this instance, all occurrences of a specified string with another specified string.</summary>
	/// <param name="oldValue">The string to replace.</param>
	/// <param name="newValue">The string that replaces <paramref name="oldValue" />, or <see langword="null" />.</param>
	/// <param name="startIndex">The position in this instance where the substring begins.</param>
	/// <param name="count">The length of the substring.</param>
	/// <returns>A reference to this instance with all instances of <paramref name="oldValue" /> replaced by <paramref name="newValue" /> in the range from <paramref name="startIndex" /> to <paramref name="startIndex" /> + <paramref name="count" /> - 1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="oldValue" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The length of <paramref name="oldValue" /> is zero.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> plus <paramref name="count" /> indicates a character position not within this instance.  
	/// -or-  
	/// Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
	{
		return null;
	}

	/// <summary>Appends an array of Unicode characters starting at a specified address to this instance.</summary>
	/// <param name="value">A pointer to an array of characters.</param>
	/// <param name="valueCount">The number of characters in the array.</param>
	/// <returns>A reference to this instance after the append operation has completed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="valueCount" /> is less than zero.  
	/// -or-  
	/// Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
	/// <exception cref="T:System.NullReferenceException">
	///   <paramref name="value" /> is a null pointer.</exception>
	[CLSCompliant(false)]
	public unsafe StringBuilder Append(char* value, int valueCount)
	{
		return null;
	}

	private unsafe void Insert(int index, char* value, int valueCount)
	{
	}

	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value)
	{
	}

	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value)
	{
		return false;
	}

	private unsafe void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count)
	{
	}

	private unsafe static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count)
	{
	}

	private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count)
	{
	}

	private StringBuilder FindChunkForIndex(int index)
	{
		return null;
	}

	private StringBuilder Next(StringBuilder chunk)
	{
		return null;
	}

	private void ExpandByABlock(int minBlockCharCount)
	{
	}

	private StringBuilder(StringBuilder from)
	{
	}

	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars)
	{
		chunk = null;
		indexInChunk = default(int);
	}

	private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
	{
	}

	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
	{
		chunk = null;
		indexInChunk = default(int);
	}
}
