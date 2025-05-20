using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Net.Http;

/// <summary>A base class representing an HTTP entity body and content headers.</summary>
public abstract class HttpContent : IDisposable
{
	private sealed class FixedMemoryStream : MemoryStream
	{
		private readonly long maxSize;

		public FixedMemoryStream(long maxSize)
		{
		}

		private void CheckOverflow(int count)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadIntoBufferAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HttpContent _003C_003E4__this;

		public long maxBufferSize;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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
	private struct _003CReadAsStringAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public HttpContent _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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

	private FixedMemoryStream buffer;

	private bool disposed;

	private HttpContentHeaders headers;

	/// <summary>Gets the HTTP content headers as defined in RFC 2616.</summary>
	/// <returns>The content headers as defined in RFC 2616.</returns>
	public HttpContentHeaders Headers => null;

	internal long? LoadedBufferLength => null;

	/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
	/// <param name="stream">The target stream.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	public Task CopyToAsync(Stream stream)
	{
		return null;
	}

	/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
	/// <param name="stream">The target stream.</param>
	/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be <see langword="null" />.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	public Task CopyToAsync(Stream stream, TransportContext context)
	{
		return null;
	}

	private static FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize)
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources and disposes of the managed resources used by the <see cref="T:System.Net.Http.HttpContent" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Http.HttpContent" /> and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
	/// <returns>The task object representing the asynchronous operation.</returns>
	public Task LoadIntoBufferAsync()
	{
		return null;
	}

	/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
	/// <param name="maxBufferSize">The maximum size, in bytes, of the buffer to use.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	[AsyncStateMachine(typeof(_003CLoadIntoBufferAsync_003Ed__17))]
	public Task LoadIntoBufferAsync(long maxBufferSize)
	{
		return null;
	}

	/// <summary>Serialize the HTTP content to a string as an asynchronous operation.</summary>
	/// <returns>The task object representing the asynchronous operation.</returns>
	[AsyncStateMachine(typeof(_003CReadAsStringAsync_003Ed__20))]
	public Task<string> ReadAsStringAsync()
	{
		return null;
	}

	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength)
	{
		return null;
	}

	private static int StartsWith(byte[] array, int length, byte[] value)
	{
		return 0;
	}

	/// <summary>Serialize the HTTP content to a stream as an asynchronous operation.</summary>
	/// <param name="stream">The target stream.</param>
	/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be <see langword="null" />.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	/// <summary>Determines whether the HTTP content has a valid length in bytes.</summary>
	/// <param name="length">The length in bytes of the HTTP content.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="length" /> is a valid length; otherwise, <see langword="false" />.</returns>
	protected internal abstract bool TryComputeLength(out long length);

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpContent" /> class.</summary>
	protected HttpContent()
	{
	}
}
