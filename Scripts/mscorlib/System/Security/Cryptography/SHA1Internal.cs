namespace System.Security.Cryptography;

internal class SHA1Internal
{
	private uint[] _H;

	private ulong count;

	private byte[] _ProcessingBuffer;

	private int _ProcessingBufferCount;

	private uint[] buff;

	public void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
	}

	public byte[] HashFinal()
	{
		return null;
	}

	public void Initialize()
	{
	}

	private void ProcessBlock(byte[] inputBuffer, uint inputOffset)
	{
	}

	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset)
	{
	}

	private static void FillBuff(uint[] buff)
	{
	}

	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
	}

	internal void AddLength(ulong length, byte[] buffer, int position)
	{
	}
}
