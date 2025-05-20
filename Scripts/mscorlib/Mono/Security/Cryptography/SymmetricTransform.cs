using System;
using System.Security.Cryptography;

namespace Mono.Security.Cryptography;

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
{
	protected SymmetricAlgorithm algo;

	protected bool encrypt;

	protected int BlockSizeByte;

	protected byte[] temp;

	protected byte[] temp2;

	private byte[] workBuff;

	private byte[] workout;

	protected PaddingMode padmode;

	protected int FeedBackByte;

	private bool m_disposed;

	protected bool lastBlock;

	private RandomNumberGenerator _rng;

	public virtual bool CanTransformMultipleBlocks => false;

	public virtual int InputBlockSize => 0;

	public virtual int OutputBlockSize => 0;

	private bool KeepLastBlock => false;

	public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV)
	{
	}

	~SymmetricTransform()
	{
	}

	void IDisposable.Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	protected virtual void Transform(byte[] input, byte[] output)
	{
	}

	protected abstract void ECB(byte[] input, byte[] output);

	protected virtual void CBC(byte[] input, byte[] output)
	{
	}

	protected virtual void CFB(byte[] input, byte[] output)
	{
	}

	protected virtual void OFB(byte[] input, byte[] output)
	{
	}

	protected virtual void CTS(byte[] input, byte[] output)
	{
	}

	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
	{
	}

	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return 0;
	}

	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return 0;
	}

	private void Random(byte[] buffer, int start, int length)
	{
	}

	private void ThrowBadPaddingException(PaddingMode padding, int length, int position)
	{
	}

	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}

	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}

	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}
}
