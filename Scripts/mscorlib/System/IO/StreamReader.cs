using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

/// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads characters from a byte stream in a particular encoding.</summary>
[Serializable]
public class StreamReader : TextReader
{
	private class NullStreamReader : StreamReader
	{
		public override Stream BaseStream => null;

		public override Encoding CurrentEncoding => null;

		internal NullStreamReader()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override int Peek()
		{
			return 0;
		}

		public override int Read()
		{
			return 0;
		}

		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		public override string ReadLine()
		{
			return null;
		}

		public override string ReadToEnd()
		{
			return null;
		}

		internal override int ReadBuffer()
		{
			return 0;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadAsyncInternal_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder<int> _003C_003Et__builder;

		public StreamReader _003C_003E4__this;

		public Memory<char> buffer;

		public CancellationToken cancellationToken;

		private int _003CcharsRead_003E5__2;

		private bool _003CreadToUserBuffer_003E5__3;

		private byte[] _003CtmpByteBuffer_003E5__4;

		private Stream _003CtmpStream_003E5__5;

		private int _003Ccount_003E5__6;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private int _003Cn_003E5__7;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReadBufferAsync_003Ed__69 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public StreamReader _003C_003E4__this;

		private byte[] _003CtmpByteBuffer_003E5__2;

		private Stream _003CtmpStream_003E5__3;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	/// <summary>A <see cref="T:System.IO.StreamReader" /> object around an empty stream.</summary>
	public new static readonly StreamReader Null;

	private Stream _stream;

	private Encoding _encoding;

	private Decoder _decoder;

	private byte[] _byteBuffer;

	private char[] _charBuffer;

	private int _charPos;

	private int _charLen;

	private int _byteLen;

	private int _bytePos;

	private int _maxCharsPerBuffer;

	private bool _detectEncoding;

	private bool _checkPreamble;

	private bool _isBlocked;

	private bool _closable;

	private Task _asyncReadTask;

	/// <summary>Gets the current character encoding that the current <see cref="T:System.IO.StreamReader" /> object is using.</summary>
	/// <returns>The current character encoding used by the current reader. The value can be different after the first call to any <see cref="Overload:System.IO.StreamReader.Read" /> method of <see cref="T:System.IO.StreamReader" />, since encoding autodetection is not done until the first call to a <see cref="Overload:System.IO.StreamReader.Read" /> method.</returns>
	public virtual Encoding CurrentEncoding => null;

	/// <summary>Returns the underlying stream.</summary>
	/// <returns>The underlying stream.</returns>
	public virtual Stream BaseStream => null;

	internal bool LeaveOpen => false;

	private void CheckAsyncTaskInProgress()
	{
	}

	private static void ThrowAsyncIOInProgress()
	{
	}

	internal StreamReader()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream.</summary>
	/// <param name="stream">The stream to be read.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> does not support reading.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	public StreamReader(Stream stream)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified byte order mark detection option.</summary>
	/// <param name="stream">The stream to be read.</param>
	/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> does not support reading.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified character encoding.</summary>
	/// <param name="stream">The stream to be read.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> does not support reading.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	public StreamReader(Stream stream, Encoding encoding)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary>
	/// <param name="stream">The stream to read.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <param name="detectEncodingFromByteOrderMarks">
	///   <see langword="true" /> to look for byte order marks at the beginning of the file; otherwise, <see langword="false" />.</param>
	/// <param name="bufferSize">The minimum buffer size.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, <see langword="false" />.</param>
	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name.</summary>
	/// <param name="path">The complete file path to be read.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string ("").</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label.</exception>
	public StreamReader(string path)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified byte order mark detection option.</summary>
	/// <param name="path">The complete file path to be read.</param>
	/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string ("").</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label.</exception>
	public StreamReader(string path, bool detectEncodingFromByteOrderMarks)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding.</summary>
	/// <param name="path">The complete file path to be read.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string ("").</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label.</exception>
	public StreamReader(string path, Encoding encoding)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding and byte order mark detection option.</summary>
	/// <param name="path">The complete file path to be read.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string ("").</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label.</exception>
	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
	/// <param name="path">The complete file path to be read.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
	/// <param name="bufferSize">The minimum buffer size, in number of 16-bit characters.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string ("").</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="buffersize" /> is less than or equal to zero.</exception>
	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
	{
	}

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
	{
	}

	internal void Init(Stream stream)
	{
	}

	/// <summary>Closes the <see cref="T:System.IO.StreamReader" /> object and the underlying stream, and releases any system resources associated with the reader.</summary>
	public override void Close()
	{
	}

	/// <summary>Closes the underlying stream, releases the unmanaged resources used by the <see cref="T:System.IO.StreamReader" />, and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Returns the next available character but does not consume it.</summary>
	/// <returns>An integer representing the next character to be read, or -1 if there are no characters to be read or if the stream does not support seeking.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public override int Peek()
	{
		return 0;
	}

	/// <summary>Reads the next character from the input stream and advances the character position by one character.</summary>
	/// <returns>The next character from the input stream represented as an <see cref="T:System.Int32" /> object, or -1 if no more characters are available.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public override int Read()
	{
		return 0;
	}

	/// <summary>Reads a specified maximum of characters from the current stream into a buffer, beginning at the specified index.</summary>
	/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (index + count - 1) replaced by the characters read from the current source.</param>
	/// <param name="index">The index of <paramref name="buffer" /> at which to begin writing.</param>
	/// <param name="count">The maximum number of characters to read.</param>
	/// <returns>The number of characters that have been read, or 0 if at the end of the stream and no data was read. The number will be less than or equal to the <paramref name="count" /> parameter, depending on whether the data is available within the stream.</returns>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs, such as the stream is closed.</exception>
	public override int Read(char[] buffer, int index, int count)
	{
		return 0;
	}

	public override int Read(Span<char> buffer)
	{
		return 0;
	}

	private int ReadSpan(Span<char> buffer)
	{
		return 0;
	}

	/// <summary>Reads all characters from the current position to the end of the stream.</summary>
	/// <returns>The rest of the stream as a string, from the current position to the end. If the current position is at the end of the stream, returns an empty string ("").</returns>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public override string ReadToEnd()
	{
		return null;
	}

	private void CompressBuffer(int n)
	{
	}

	private void DetectEncoding()
	{
	}

	private bool IsPreamble()
	{
		return false;
	}

	internal virtual int ReadBuffer()
	{
		return 0;
	}

	private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer)
	{
		readToUserBuffer = default(bool);
		return 0;
	}

	/// <summary>Reads a line of characters from the current stream and returns the data as a string.</summary>
	/// <returns>The next line from the input stream, or <see langword="null" /> if the end of the input stream is reached.</returns>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	public override string ReadLine()
	{
		return null;
	}

	/// <summary>Reads a specified maximum number of characters from the current stream asynchronously and writes the data to a buffer, beginning at the specified index.</summary>
	/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
	/// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
	/// <param name="count">The maximum number of characters to read. If the end of the stream is reached before the specified number of characters is written into the buffer, the current method returns.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of characters read into the buffer. The result value can be less than the number of characters requested if the number of characters currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation.</exception>
	public override Task<int> ReadAsync(char[] buffer, int index, int count)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReadAsyncInternal_003Ed__66))]
	internal override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
	{
		return default(ValueTask<int>);
	}

	[AsyncStateMachine(typeof(_003CReadBufferAsync_003Ed__69))]
	private Task<int> ReadBufferAsync()
	{
		return null;
	}

	internal bool DataAvailable()
	{
		return false;
	}
}
