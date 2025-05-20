using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression;

internal sealed class PositionPreservingWriteOnlyStreamWrapper : Stream
{
	private readonly Stream _stream;

	private long _position;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public override bool CanTimeout => false;

	public override int ReadTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override long Length => 0L;

	public PositionPreservingWriteOnlyStreamWrapper(Stream stream)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	public override void WriteByte(byte value)
	{
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override void Close()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}
}
