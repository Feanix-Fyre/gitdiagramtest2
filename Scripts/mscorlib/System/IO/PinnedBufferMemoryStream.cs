using System.Runtime.InteropServices;

namespace System.IO;

internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
{
	private byte[] _array;

	private GCHandle _pinningHandle;

	internal PinnedBufferMemoryStream(byte[] array)
	{
	}

	public override int Read(Span<byte> buffer)
	{
		return 0;
	}

	public override void Write(ReadOnlySpan<byte> buffer)
	{
	}

	~PinnedBufferMemoryStream()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
