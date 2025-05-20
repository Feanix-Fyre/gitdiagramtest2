using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace System.Drawing;

internal sealed class ComIStreamWrapper : IStream
{
	private readonly Stream baseStream;

	private long position;

	internal ComIStreamWrapper(Stream stream)
	{
	}

	private void SetSizeToPosition()
	{
	}

	public void Read(byte[] pv, int cb, IntPtr pcbRead)
	{
	}

	public void Write(byte[] pv, int cb, IntPtr pcbWritten)
	{
	}

	public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
	{
	}

	public void SetSize(long libNewSize)
	{
	}

	public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
	{
	}

	public void Commit(int grfCommitFlags)
	{
	}

	public void Revert()
	{
	}

	public void LockRegion(long libOffset, long cb, int dwLockType)
	{
	}

	public void UnlockRegion(long libOffset, long cb, int dwLockType)
	{
	}

	public void Stat(out STATSTG pstatstg, int grfStatFlag)
	{
		pstatstg = default(STATSTG);
	}

	public void Clone(out IStream ppstm)
	{
		ppstm = null;
	}
}
