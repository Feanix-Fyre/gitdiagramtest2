using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

/// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing characters to a stream in a particular encoding.</summary>
[Serializable]
public class StreamWriter : TextWriter
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWriteAsyncInternal_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int charPos;

		public int charLen;

		public StreamWriter _this;

		public char[] charBuffer;

		public char value;

		public bool appendNewLine;

		public char[] coreNewLine;

		public bool autoFlush;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__2;

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
	private struct _003CWriteAsyncInternal_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string value;

		public int charPos;

		public int charLen;

		public StreamWriter _this;

		public char[] charBuffer;

		public bool appendNewLine;

		public char[] coreNewLine;

		public bool autoFlush;

		private int _003Ccount_003E5__2;

		private int _003Cindex_003E5__3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__4;

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
	private struct _003CWriteAsyncInternal_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int charPos;

		public int charLen;

		public StreamWriter _this;

		public char[] charBuffer;

		public CancellationToken cancellationToken;

		public ReadOnlyMemory<char> source;

		public bool appendNewLine;

		public char[] coreNewLine;

		public bool autoFlush;

		private int _003Ccopied_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__3;

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
	private struct _003CFlushAsyncInternal_003Ed__74 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool haveWrittenPreamble;

		public StreamWriter _this;

		public Encoding encoding;

		public Stream stream;

		public CancellationToken cancellationToken;

		public Encoder encoder;

		public char[] charBuffer;

		public int charPos;

		public byte[] byteBuffer;

		public bool flushEncoder;

		public bool flushStream;

		private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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

	/// <summary>Provides a <see langword="StreamWriter" /> with no backing store that can be written to, but not read from.</summary>
	public new static readonly StreamWriter Null;

	private Stream _stream;

	private Encoding _encoding;

	private Encoder _encoder;

	private byte[] _byteBuffer;

	private char[] _charBuffer;

	private int _charPos;

	private int _charLen;

	private bool _autoFlush;

	private bool _haveWrittenPreamble;

	private bool _closable;

	private Task _asyncWriteTask;

	private static Encoding UTF8NoBOM => null;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.IO.StreamWriter" /> will flush its buffer to the underlying stream after every call to <see cref="M:System.IO.StreamWriter.Write(System.Char)" />.</summary>
	/// <returns>
	///   <see langword="true" /> to force <see cref="T:System.IO.StreamWriter" /> to flush its buffer; otherwise, <see langword="false" />.</returns>
	public virtual bool AutoFlush
	{
		set
		{
		}
	}

	/// <summary>Gets the underlying stream that interfaces with a backing store.</summary>
	/// <returns>The stream this <see langword="StreamWriter" /> is writing to.</returns>
	public virtual Stream BaseStream => null;

	internal bool LeaveOpen => false;

	/// <summary>Gets the <see cref="T:System.Text.Encoding" /> in which the output is written.</summary>
	/// <returns>The <see cref="T:System.Text.Encoding" /> specified in the constructor for the current instance, or <see cref="T:System.Text.UTF8Encoding" /> if an encoding was not specified.</returns>
	public override Encoding Encoding => null;

	private int CharPos_Prop
	{
		set
		{
		}
	}

	private bool HaveWrittenPreamble_Prop
	{
		set
		{
		}
	}

	private void CheckAsyncTaskInProgress()
	{
	}

	private static void ThrowAsyncIOInProgress()
	{
	}

	internal StreamWriter()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using UTF-8 encoding and the default buffer size.</summary>
	/// <param name="stream">The stream to write to.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> is not writable.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	public StreamWriter(Stream stream)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using the specified encoding and the default buffer size.</summary>
	/// <param name="stream">The stream to write to.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> is not writable.</exception>
	public StreamWriter(Stream stream, Encoding encoding)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
	/// <param name="stream">The stream to write to.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <param name="bufferSize">The buffer size, in bytes.</param>
	/// <param name="leaveOpen">
	///   <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.StreamWriter" /> object is disposed; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> is not writable.</exception>
	public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file by using the default encoding and buffer size.</summary>
	/// <param name="path">The complete file path to write to. <paramref name="path" /> can be a file name.</param>
	/// <exception cref="T:System.UnauthorizedAccessException">Access is denied.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string ("").  
	/// -or-  
	/// <paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public StreamWriter(string path)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file by using the default encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary>
	/// <param name="path">The complete file path to write to.</param>
	/// <param name="append">
	///   <see langword="true" /> to append data to the file; <see langword="false" /> to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file.</param>
	/// <exception cref="T:System.UnauthorizedAccessException">Access is denied.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is empty.  
	/// -or-  
	/// <paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public StreamWriter(string path, bool append)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file by using the specified encoding and default buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary>
	/// <param name="path">The complete file path to write to.</param>
	/// <param name="append">
	///   <see langword="true" /> to append data to the file; <see langword="false" /> to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <exception cref="T:System.UnauthorizedAccessException">Access is denied.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is empty.  
	/// -or-  
	/// <paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public StreamWriter(string path, bool append, Encoding encoding)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file on the specified path, using the specified encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary>
	/// <param name="path">The complete file path to write to.</param>
	/// <param name="append">
	///   <see langword="true" /> to append data to the file; <see langword="false" /> to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file.</param>
	/// <param name="encoding">The character encoding to use.</param>
	/// <param name="bufferSize">The buffer size, in bytes.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string ("").  
	/// -or-  
	/// <paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> or <paramref name="encoding" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">Access is denied.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	public StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
	{
	}

	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
	{
	}

	/// <summary>Closes the current <see langword="StreamWriter" /> object and the underlying stream.</summary>
	/// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair.</exception>
	public override void Close()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StreamWriter" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	/// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair.</exception>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The current writer is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error has occurred.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair.</exception>
	public override void Flush()
	{
	}

	private void Flush(bool flushStream, bool flushEncoder)
	{
	}

	/// <summary>Writes a character to the stream.</summary>
	/// <param name="value">The character to write to the stream.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream.</exception>
	public override void Write(char value)
	{
	}

	/// <summary>Writes a character array to the stream.</summary>
	/// <param name="buffer">A character array containing the data to write. If <paramref name="buffer" /> is <see langword="null" />, nothing is written.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(char[] buffer)
	{
	}

	/// <summary>Writes a subarray of characters to the stream.</summary>
	/// <param name="buffer">A character array that contains the data to write.</param>
	/// <param name="index">The character position in the buffer at which to start reading data.</param>
	/// <param name="count">The maximum number of characters to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(char[] buffer, int index, int count)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine)
	{
	}

	/// <summary>Writes a string to the stream.</summary>
	/// <param name="value">The string to write to the stream. If <paramref name="value" /> is null, nothing is written.</param>
	/// <exception cref="T:System.ObjectDisposedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteLine(string value)
	{
	}

	/// <summary>Writes a character to the stream asynchronously.</summary>
	/// <param name="value">The character to write to the stream.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
	public override Task WriteAsync(char value)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteAsyncInternal_003Ed__57))]
	private static Task WriteAsyncInternal(StreamWriter _this, char value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine)
	{
		return null;
	}

	/// <summary>Writes a string to the stream asynchronously.</summary>
	/// <param name="value">The string to write to the stream. If <paramref name="value" /> is <see langword="null" />, nothing is written.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
	public override Task WriteAsync(string value)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteAsyncInternal_003Ed__59))]
	private static Task WriteAsyncInternal(StreamWriter _this, string value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine)
	{
		return null;
	}

	/// <summary>Writes a subarray of characters to the stream asynchronously.</summary>
	/// <param name="buffer">A character array that contains the data to write.</param>
	/// <param name="index">The character position in the buffer at which to begin reading data.</param>
	/// <param name="count">The maximum number of characters to write.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
	public override Task WriteAsync(char[] buffer, int index, int count)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CWriteAsyncInternal_003Ed__62))]
	private static Task WriteAsyncInternal(StreamWriter _this, ReadOnlyMemory<char> source, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Clears all buffers for this stream asynchronously and causes any buffered data to be written to the underlying device.</summary>
	/// <returns>A task that represents the asynchronous flush operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	public override Task FlushAsync()
	{
		return null;
	}

	private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, char[] sCharBuffer, int sCharPos, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CFlushAsyncInternal_003Ed__74))]
	private static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, byte[] byteBuffer, Stream stream, CancellationToken cancellationToken)
	{
		return null;
	}
}
