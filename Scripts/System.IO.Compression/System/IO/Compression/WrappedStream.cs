namespace System.IO.Compression;

internal sealed class WrappedStream : Stream
{
	private readonly Stream _baseStream;

	private readonly bool _closeBaseStream;

	private readonly Action<ZipArchiveEntry> _onClosed;

	private readonly ZipArchiveEntry _zipArchiveEntry;

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

	internal WrappedStream(Stream baseStream, bool closeBaseStream)
	{
	}

	private WrappedStream(Stream baseStream, bool closeBaseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed)
	{
	}

	internal WrappedStream(Stream baseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed)
	{
	}

	private void ThrowIfDisposed()
	{
	}

	private void ThrowIfCantRead()
	{
	}

	private void ThrowIfCantWrite()
	{
	}

	private void ThrowIfCantSeek()
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
