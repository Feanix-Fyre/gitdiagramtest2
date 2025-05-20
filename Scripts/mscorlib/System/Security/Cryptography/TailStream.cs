using System.IO;

namespace System.Security.Cryptography;

internal sealed class TailStream : Stream
{
	private byte[] _Buffer;

	private int _BufferSize;

	private int _BufferIndex;

	private bool _BufferFull;

	public byte[] Buffer => null;

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

	public TailStream(int bufferSize)
	{
	}

	public void Clear()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override void Flush()
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

	public override void Write(byte[] buffer, int offset, int count)
	{
	}
}
