using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

/// <summary>Represents a reader that can read a sequential series of characters.</summary>
[Serializable]
public abstract class TextReader : MarshalByRefObject, IDisposable
{
	[Serializable]
	private sealed class NullTextReader : TextReader
	{
		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		public override string ReadLine()
		{
			return null;
		}
	}

	[Serializable]
	internal sealed class SyncTextReader : TextReader
	{
		internal readonly TextReader _in;

		internal SyncTextReader(TextReader t)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Close()
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		protected override void Dispose(bool disposing)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int Peek()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int Read()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override string ReadLine()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override string ReadToEnd()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			return null;
		}
	}

	/// <summary>Provides a <see langword="TextReader" /> with no data to read from.</summary>
	public static readonly TextReader Null;

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.TextReader" /> class.</summary>
	protected TextReader()
	{
	}

	/// <summary>Closes the <see cref="T:System.IO.TextReader" /> and releases any system resources associated with the <see langword="TextReader" />.</summary>
	public virtual void Close()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.IO.TextReader" /> object.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.TextReader" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Reads the next character without changing the state of the reader or the character source. Returns the next available character without actually reading it from the reader.</summary>
	/// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the reader does not support seeking.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual int Peek()
	{
		return 0;
	}

	/// <summary>Reads the next character from the text reader and advances the character position by one character.</summary>
	/// <returns>The next character from the text reader, or -1 if no more characters are available. The default implementation returns -1.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual int Read()
	{
		return 0;
	}

	/// <summary>Reads a specified maximum number of characters from the current reader and writes the data to a buffer, beginning at the specified index.</summary>
	/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
	/// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
	/// <param name="count">The maximum number of characters to read. If the end of the reader is reached before the specified number of characters is read into the buffer, the method returns.</param>
	/// <returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether the data is available within the reader. This method returns 0 (zero) if it is called when no more characters are left to read.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public virtual int Read(char[] buffer, int index, int count)
	{
		return 0;
	}

	public virtual int Read(Span<char> buffer)
	{
		return 0;
	}

	/// <summary>Reads all characters from the current position to the end of the text reader and returns them as one string.</summary>
	/// <returns>A string that contains all characters from the current position to the end of the text reader.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" /></exception>
	public virtual string ReadToEnd()
	{
		return null;
	}

	/// <summary>Reads a line of characters from the text reader and returns the data as a string.</summary>
	/// <returns>The next line from the reader, or <see langword="null" /> if all characters have been read.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" /></exception>
	public virtual string ReadLine()
	{
		return null;
	}

	/// <summary>Reads a specified maximum number of characters from the current text reader asynchronously and writes the data to a buffer, beginning at the specified index.</summary>
	/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
	/// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
	/// <param name="count">The maximum number of characters to read. If the end of the text is reached before the specified number of characters is read into the buffer, the current method returns.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the text has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation.</exception>
	public virtual Task<int> ReadAsync(char[] buffer, int index, int count)
	{
		return null;
	}

	internal virtual ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
	{
		return default(ValueTask<int>);
	}

	/// <summary>Creates a thread-safe wrapper around the specified <see langword="TextReader" />.</summary>
	/// <param name="reader">The <see langword="TextReader" /> to synchronize.</param>
	/// <returns>A thread-safe <see cref="T:System.IO.TextReader" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="reader" /> is <see langword="null" />.</exception>
	public static TextReader Synchronized(TextReader reader)
	{
		return null;
	}
}
