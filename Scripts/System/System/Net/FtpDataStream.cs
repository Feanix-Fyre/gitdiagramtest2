using System.IO;
using System.Net.Sockets;

namespace System.Net;

internal class FtpDataStream : Stream, ICloseEx
{
	private FtpWebRequest _request;

	private NetworkStream _networkStream;

	private bool _writeable;

	private bool _readable;

	private bool _isFullyRead;

	private bool _closing;

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

	public override bool CanTimeout => false;

	public override int ReadTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
	}

	private void CheckError()
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
	}

	private void AsyncReadCallback(IAsyncResult ar)
	{
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	public override int EndRead(IAsyncResult ar)
	{
		return 0;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	public override void Flush()
	{
	}

	public override void SetLength(long value)
	{
	}

	internal void SetSocketTimeoutOption(int timeout)
	{
	}
}
