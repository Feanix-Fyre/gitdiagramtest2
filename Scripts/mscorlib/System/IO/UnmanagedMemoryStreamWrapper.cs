using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

internal sealed class UnmanagedMemoryStreamWrapper : MemoryStream
{
	private UnmanagedMemoryStream _unmanagedStream;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override int Capacity
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

	internal UnmanagedMemoryStreamWrapper(UnmanagedMemoryStream stream)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override void Flush()
	{
	}

	public override byte[] GetBuffer()
	{
		return null;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int Read(Span<byte> buffer)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	public override long Seek(long offset, SeekOrigin loc)
	{
		return 0L;
	}

	public override byte[] ToArray()
	{
		return null;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Write(ReadOnlySpan<byte> buffer)
	{
	}

	public override void WriteByte(byte value)
	{
	}

	public override void SetLength(long value)
	{
	}

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask<int>);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
	{
		return default(ValueTask);
	}
}
