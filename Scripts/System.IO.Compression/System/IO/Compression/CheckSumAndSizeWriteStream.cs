namespace System.IO.Compression;

internal sealed class CheckSumAndSizeWriteStream : Stream
{
	private readonly Stream _baseStream;

	private readonly Stream _baseBaseStream;

	private long _position;

	private uint _checksum;

	private readonly bool _leaveOpenOnClose;

	private bool _canWrite;

	private bool _isDisposed;

	private bool _everWritten;

	private long _initialPosition;

	private readonly ZipArchiveEntry _zipArchiveEntry;

	private readonly EventHandler _onClose;

	private readonly Action<long, long, uint, Stream, ZipArchiveEntry, EventHandler> _saveCrcAndSizes;

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

	public CheckSumAndSizeWriteStream(Stream baseStream, Stream baseBaseStream, bool leaveOpenOnClose, ZipArchiveEntry entry, EventHandler onClose, Action<long, long, uint, Stream, ZipArchiveEntry, EventHandler> saveCrcAndSizes)
	{
	}

	private void ThrowIfDisposed()
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
