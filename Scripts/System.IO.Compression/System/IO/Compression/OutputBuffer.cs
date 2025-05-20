namespace System.IO.Compression;

internal sealed class OutputBuffer
{
	internal readonly struct BufferState
	{
		internal readonly int _pos;

		internal readonly uint _bitBuf;

		internal readonly int _bitCount;

		internal BufferState(int pos, uint bitBuf, int bitCount)
		{
			_pos = 0;
			_bitBuf = 0u;
			_bitCount = 0;
		}
	}

	private byte[] _byteBuffer;

	private int _pos;

	private uint _bitBuf;

	private int _bitCount;

	internal int BytesWritten => 0;

	internal int FreeBytes => 0;

	internal int BitsInBuffer => 0;

	internal void UpdateBuffer(byte[] output)
	{
	}

	internal void WriteUInt16(ushort value)
	{
	}

	internal void WriteBits(int n, uint bits)
	{
	}

	internal void FlushBits()
	{
	}

	internal void WriteBytes(byte[] byteArray, int offset, int count)
	{
	}

	private void WriteBytesUnaligned(byte[] byteArray, int offset, int count)
	{
	}

	private void WriteByteUnaligned(byte b)
	{
	}

	internal BufferState DumpState()
	{
		return default(BufferState);
	}

	internal void RestoreState(BufferState state)
	{
	}
}
