using System.IO;

namespace System.Data.SqlTypes;

internal sealed class SqlXmlStreamWrapper : Stream
{
	private Stream _stream;

	private long _lPosition;

	private bool _isClosed;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

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

	internal SqlXmlStreamWrapper(Stream stream)
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override int ReadByte()
	{
		return 0;
	}

	public override void WriteByte(byte value)
	{
	}

	public override void SetLength(long value)
	{
	}

	public override void Flush()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void ThrowIfStreamCannotSeek(string method)
	{
	}

	private void ThrowIfStreamCannotRead(string method)
	{
	}

	private void ThrowIfStreamCannotWrite(string method)
	{
	}

	private void ThrowIfStreamClosed(string method)
	{
	}

	private bool IsStreamClosed()
	{
		return false;
	}
}
