using System.Runtime.InteropServices;
using System.Text;

namespace System.IO;

/// <summary>Reads primitive data types as binary values in a specific encoding.</summary>
[ComVisible(true)]
public class BinaryReader : IDisposable
{
	private Stream m_stream;

	private byte[] m_buffer;

	private Decoder m_decoder;

	private byte[] m_charBytes;

	private char[] m_singleChar;

	private char[] m_charBuffer;

	private int m_maxCharsSize;

	private bool m_2BytesPerChar;

	private bool m_isMemoryStream;

	private bool m_leaveOpen;

	/// <summary>Exposes access to the underlying stream of the <see cref="T:System.IO.BinaryReader" />.</summary>
	/// <returns>The underlying stream associated with the <see langword="BinaryReader" />.</returns>
	public virtual Stream BaseStream => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and using UTF-8 encoding.</summary>
	/// <param name="input">The input stream.</param>
	/// <exception cref="T:System.ArgumentException">The stream does not support reading, is <see langword="null" />, or is already closed.</exception>
	public BinaryReader(Stream input)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and character encoding.</summary>
	/// <param name="input">The input stream.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <exception cref="T:System.ArgumentException">The stream does not support reading, is <see langword="null" />, or is already closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="encoding" /> is <see langword="null" />.</exception>
	public BinaryReader(Stream input, Encoding encoding)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
	/// <param name="input">The input stream.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">The stream does not support reading, is <see langword="null" />, or is already closed.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="encoding" /> or <paramref name="input" /> is <see langword="null" />.</exception>
	public BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
	{
	}

	/// <summary>Closes the current reader and the underlying stream.</summary>
	public virtual void Close()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.BinaryReader" /> class and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.IO.BinaryReader" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Returns the next available character and does not advance the byte or character position.</summary>
	/// <returns>The next available character, or -1 if no more characters are available or the stream does not support seeking.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ArgumentException">The current character cannot be decoded into the internal character buffer by using the <see cref="T:System.Text.Encoding" /> selected for the stream.</exception>
	public virtual int PeekChar()
	{
		return 0;
	}

	/// <summary>Reads characters from the underlying stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific character being read from the stream.</summary>
	/// <returns>The next character from the input stream, or -1 if no characters are currently available.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public virtual int Read()
	{
		return 0;
	}

	/// <summary>Reads a <see langword="Boolean" /> value from the current stream and advances the current position of the stream by one byte.</summary>
	/// <returns>
	///   <see langword="true" /> if the byte is nonzero; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual bool ReadBoolean()
	{
		return false;
	}

	/// <summary>Reads the next byte from the current stream and advances the current position of the stream by one byte.</summary>
	/// <returns>The next byte read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual byte ReadByte()
	{
		return 0;
	}

	/// <summary>Reads a signed byte from this stream and advances the current position of the stream by one byte.</summary>
	/// <returns>A signed byte read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	[CLSCompliant(false)]
	public virtual sbyte ReadSByte()
	{
		return 0;
	}

	/// <summary>Reads the next character from the current stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific character being read from the stream.</summary>
	/// <returns>A character read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ArgumentException">A surrogate character was read.</exception>
	public virtual char ReadChar()
	{
		return '\0';
	}

	/// <summary>Reads a 2-byte signed integer from the current stream and advances the current position of the stream by two bytes.</summary>
	/// <returns>A 2-byte signed integer read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual short ReadInt16()
	{
		return 0;
	}

	/// <summary>Reads a 2-byte unsigned integer from the current stream using little-endian encoding and advances the position of the stream by two bytes.</summary>
	/// <returns>A 2-byte unsigned integer read from this stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	[CLSCompliant(false)]
	public virtual ushort ReadUInt16()
	{
		return 0;
	}

	/// <summary>Reads a 4-byte signed integer from the current stream and advances the current position of the stream by four bytes.</summary>
	/// <returns>A 4-byte signed integer read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual int ReadInt32()
	{
		return 0;
	}

	/// <summary>Reads a 4-byte unsigned integer from the current stream and advances the position of the stream by four bytes.</summary>
	/// <returns>A 4-byte unsigned integer read from this stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	[CLSCompliant(false)]
	public virtual uint ReadUInt32()
	{
		return 0u;
	}

	/// <summary>Reads an 8-byte signed integer from the current stream and advances the current position of the stream by eight bytes.</summary>
	/// <returns>An 8-byte signed integer read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual long ReadInt64()
	{
		return 0L;
	}

	/// <summary>Reads an 8-byte unsigned integer from the current stream and advances the position of the stream by eight bytes.</summary>
	/// <returns>An 8-byte unsigned integer read from this stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	[CLSCompliant(false)]
	public virtual ulong ReadUInt64()
	{
		return 0uL;
	}

	/// <summary>Reads a 4-byte floating point value from the current stream and advances the current position of the stream by four bytes.</summary>
	/// <returns>A 4-byte floating point value read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual float ReadSingle()
	{
		return 0f;
	}

	/// <summary>Reads an 8-byte floating point value from the current stream and advances the current position of the stream by eight bytes.</summary>
	/// <returns>An 8-byte floating point value read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual double ReadDouble()
	{
		return 0.0;
	}

	/// <summary>Reads a decimal value from the current stream and advances the current position of the stream by sixteen bytes.</summary>
	/// <returns>A decimal value read from the current stream.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual decimal ReadDecimal()
	{
		return default(decimal);
	}

	/// <summary>Reads a string from the current stream. The string is prefixed with the length, encoded as an integer seven bits at a time.</summary>
	/// <returns>The string being read.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual string ReadString()
	{
		return null;
	}

	private int InternalReadChars(char[] buffer, int index, int count)
	{
		return 0;
	}

	private int InternalReadOneChar()
	{
		return 0;
	}

	/// <summary>Reads the specified number of characters from the current stream, returns the data in a character array, and advances the current position in accordance with the <see langword="Encoding" /> used and the specific character being read from the stream.</summary>
	/// <param name="count">The number of characters to read.</param>
	/// <returns>A character array containing data read from the underlying stream. This might be less than the number of characters requested if the end of the stream is reached.</returns>
	/// <exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is negative.</exception>
	public virtual char[] ReadChars(int count)
	{
		return null;
	}

	/// <summary>Reads the specified number of bytes from the stream, starting from a specified point in the byte array.</summary>
	/// <param name="buffer">The buffer to read data into.</param>
	/// <param name="index">The starting point in the buffer at which to begin reading into the buffer.</param>
	/// <param name="count">The number of bytes to read.</param>
	/// <returns>The number of bytes read into <paramref name="buffer" />. This might be less than the number of bytes requested if that many bytes are not available, or it might be zero if the end of the stream is reached.</returns>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.  
	///  -or-  
	///  The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual int Read(byte[] buffer, int index, int count)
	{
		return 0;
	}

	/// <summary>Reads the specified number of bytes from the current stream into a byte array and advances the current position by that number of bytes.</summary>
	/// <param name="count">The number of bytes to read. This value must be 0 or a non-negative number or an exception will occur.</param>
	/// <returns>A byte array containing data read from the underlying stream. This might be less than the number of bytes requested if the end of the stream is reached.</returns>
	/// <exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is negative.</exception>
	public virtual byte[] ReadBytes(int count)
	{
		return null;
	}

	/// <summary>Fills the internal buffer with the specified number of bytes read from the stream.</summary>
	/// <param name="numBytes">The number of bytes to be read.</param>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached before <paramref name="numBytes" /> could be read.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Requested <paramref name="numBytes" /> is larger than the internal buffer size.</exception>
	protected virtual void FillBuffer(int numBytes)
	{
	}

	/// <summary>Reads in a 32-bit integer in compressed format.</summary>
	/// <returns>A 32-bit integer in compressed format.</returns>
	/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.FormatException">The stream is corrupted.</exception>
	protected internal int Read7BitEncodedInt()
	{
		return 0;
	}
}
