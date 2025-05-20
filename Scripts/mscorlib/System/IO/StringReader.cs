using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.IO;

/// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads from a string.</summary>
[Serializable]
[ComVisible(true)]
public class StringReader : TextReader
{
	private string _s;

	private int _pos;

	private int _length;

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringReader" /> class that reads from the specified string.</summary>
	/// <param name="s">The string to which the <see cref="T:System.IO.StringReader" /> should be initialized.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is <see langword="null" />.</exception>
	public StringReader(string s)
	{
	}

	/// <summary>Closes the <see cref="T:System.IO.StringReader" />.</summary>
	public override void Close()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StringReader" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Returns the next available character but does not consume it.</summary>
	/// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the stream does not support seeking.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current reader is closed.</exception>
	public override int Peek()
	{
		return 0;
	}

	/// <summary>Reads the next character from the input string and advances the character position by one character.</summary>
	/// <returns>The next character from the underlying string, or -1 if no more characters are available.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current reader is closed.</exception>
	public override int Read()
	{
		return 0;
	}

	/// <summary>Reads a block of characters from the input string and advances the character position by <paramref name="count" />.</summary>
	/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
	/// <param name="index">The starting index in the buffer.</param>
	/// <param name="count">The number of characters to read.</param>
	/// <returns>The total number of characters read into the buffer. This can be less than the number of characters requested if that many characters are not currently available, or zero if the end of the underlying string has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The current reader is closed.</exception>
	public override int Read([In][Out] char[] buffer, int index, int count)
	{
		return 0;
	}

	/// <summary>Reads all characters from the current position to the end of the string and returns them as a single string.</summary>
	/// <returns>The content from the current position to the end of the underlying string.</returns>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The current reader is closed.</exception>
	public override string ReadToEnd()
	{
		return null;
	}

	/// <summary>Reads a line of characters from the current string and returns the data as a string.</summary>
	/// <returns>The next line from the current string, or <see langword="null" /> if the end of the string is reached.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current reader is closed.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
	public override string ReadLine()
	{
		return null;
	}

	/// <summary>Reads a specified maximum number of characters from the current string asynchronously and writes the data to a buffer, beginning at the specified index.</summary>
	/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
	/// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
	/// <param name="count">The maximum number of characters to read. If the end of the string is reached before the specified number of characters is written into the buffer, the method returns.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the string has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The string reader has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation.</exception>
	[ComVisible(false)]
	public override Task<int> ReadAsync(char[] buffer, int index, int count)
	{
		return null;
	}
}
