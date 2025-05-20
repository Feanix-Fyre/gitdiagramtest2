using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.IO;

/// <summary>Writes primitive types in binary to a stream and supports writing strings in a specific encoding.</summary>
[Serializable]
[ComVisible(true)]
public class BinaryWriter : IDisposable
{
	/// <summary>Specifies a <see cref="T:System.IO.BinaryWriter" /> with no backing store.</summary>
	public static readonly BinaryWriter Null;

	/// <summary>Holds the underlying stream.</summary>
	protected Stream OutStream;

	private byte[] _buffer;

	private Encoding _encoding;

	private Encoder _encoder;

	[OptionalField]
	private bool _leaveOpen;

	private byte[] _largeByteBuffer;

	private int _maxChars;

	/// <summary>Gets the underlying stream of the <see cref="T:System.IO.BinaryWriter" />.</summary>
	/// <returns>The underlying stream associated with the <see langword="BinaryWriter" />.</returns>
	public virtual Stream BaseStream => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class that writes to a stream.</summary>
	protected BinaryWriter()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class based on the specified stream and using UTF-8 encoding.</summary>
	/// <param name="output">The output stream.</param>
	/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="output" /> is <see langword="null" />.</exception>
	public BinaryWriter(Stream output)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class based on the specified stream and character encoding.</summary>
	/// <param name="output">The output stream.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="output" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	public BinaryWriter(Stream output, Encoding encoding)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
	/// <param name="output">The output stream.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="output" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
	{
	}

	/// <summary>Closes the current <see cref="T:System.IO.BinaryWriter" /> and the underlying stream.</summary>
	public virtual void Close()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.BinaryWriter" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.IO.BinaryWriter" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Clears all buffers for the current writer and causes any buffered data to be written to the underlying device.</summary>
	public virtual void Flush()
	{
	}

	/// <summary>Writes a one-byte <see langword="Boolean" /> value to the current stream, with 0 representing <see langword="false" /> and 1 representing <see langword="true" />.</summary>
	/// <param name="value">The <see langword="Boolean" /> value to write (0 or 1).</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(bool value)
	{
	}

	/// <summary>Writes an unsigned byte to the current stream and advances the stream position by one byte.</summary>
	/// <param name="value">The unsigned byte to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(byte value)
	{
	}

	/// <summary>Writes a signed byte to the current stream and advances the stream position by one byte.</summary>
	/// <param name="value">The signed byte to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	[CLSCompliant(false)]
	public virtual void Write(sbyte value)
	{
	}

	/// <summary>Writes a byte array to the underlying stream.</summary>
	/// <param name="buffer">A byte array containing the data to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	public virtual void Write(byte[] buffer)
	{
	}

	/// <summary>Writes a region of a byte array to the current stream.</summary>
	/// <param name="buffer">A byte array containing the data to write.</param>
	/// <param name="index">The index of the first byte to read from <paramref name="buffer" /> and to write to the stream.</param>
	/// <param name="count">The number of bytes to read from <paramref name="buffer" /> and to write to the stream.</param>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(byte[] buffer, int index, int count)
	{
	}

	/// <summary>Writes a Unicode character to the current stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific characters being written to the stream.</summary>
	/// <param name="ch">The non-surrogate, Unicode character to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="ch" /> is a single surrogate character.</exception>
	public virtual void Write(char ch)
	{
	}

	/// <summary>Writes a character array to the current stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific characters being written to the stream.</summary>
	/// <param name="chars">A character array containing the data to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual void Write(char[] chars)
	{
	}

	/// <summary>Writes an eight-byte floating-point value to the current stream and advances the stream position by eight bytes.</summary>
	/// <param name="value">The eight-byte floating-point value to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(double value)
	{
	}

	/// <summary>Writes a two-byte signed integer to the current stream and advances the stream position by two bytes.</summary>
	/// <param name="value">The two-byte signed integer to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(short value)
	{
	}

	/// <summary>Writes a two-byte unsigned integer to the current stream and advances the stream position by two bytes.</summary>
	/// <param name="value">The two-byte unsigned integer to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	[CLSCompliant(false)]
	public virtual void Write(ushort value)
	{
	}

	/// <summary>Writes a four-byte signed integer to the current stream and advances the stream position by four bytes.</summary>
	/// <param name="value">The four-byte signed integer to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(int value)
	{
	}

	/// <summary>Writes a four-byte unsigned integer to the current stream and advances the stream position by four bytes.</summary>
	/// <param name="value">The four-byte unsigned integer to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	[CLSCompliant(false)]
	public virtual void Write(uint value)
	{
	}

	/// <summary>Writes an eight-byte signed integer to the current stream and advances the stream position by eight bytes.</summary>
	/// <param name="value">The eight-byte signed integer to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(long value)
	{
	}

	/// <summary>Writes an eight-byte unsigned integer to the current stream and advances the stream position by eight bytes.</summary>
	/// <param name="value">The eight-byte unsigned integer to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	[CLSCompliant(false)]
	public virtual void Write(ulong value)
	{
	}

	/// <summary>Writes a four-byte floating-point value to the current stream and advances the stream position by four bytes.</summary>
	/// <param name="value">The four-byte floating-point value to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(float value)
	{
	}

	/// <summary>Writes a length-prefixed string to this stream in the current encoding of the <see cref="T:System.IO.BinaryWriter" />, and advances the current position of the stream in accordance with the encoding used and the specific characters being written to the stream.</summary>
	/// <param name="value">The value to write.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual void Write(string value)
	{
	}

	/// <summary>Writes a 32-bit integer in a compressed format.</summary>
	/// <param name="value">The 32-bit integer to be written.</param>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">The stream is closed.</exception>
	protected void Write7BitEncodedInt(int value)
	{
	}
}
