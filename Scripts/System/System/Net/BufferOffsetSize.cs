namespace System.Net;

internal class BufferOffsetSize
{
	internal byte[] Buffer;

	internal int Offset;

	internal int Size;

	internal BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer)
	{
	}

	internal BufferOffsetSize(byte[] buffer, bool copyBuffer)
	{
	}
}
