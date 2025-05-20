namespace System.IO.Compression;

internal sealed class SubReadStream : Stream
{
	private readonly long _startInSuperStream;

	private long _positionInSuperStream;

	private readonly long _endInSuperStream;

	private readonly Stream _superStream;

	private bool _canRead;

	private bool _isDisposed;

	public override long Length => 0L;

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

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public SubReadStream(Stream superStream, long startPosition, long maxLength)
	{
	}

	private void ThrowIfDisposed()
	{
	}

	private void ThrowIfCantRead()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Flush()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
