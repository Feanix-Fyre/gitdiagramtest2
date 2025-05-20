using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class NetworkStreamWrapper : Stream
{
	private TcpClient _client;

	private NetworkStream _networkStream;

	protected bool UsingSecureStream => false;

	internal IPAddress ServerAddress => null;

	internal Socket Socket => null;

	internal NetworkStream NetworkStream
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

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

	internal NetworkStreamWrapper(TcpClient client)
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

	protected override void Dispose(bool disposing)
	{
	}

	internal void CloseSocket()
	{
	}

	public void Close(int timeout)
	{
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	public override void SetLength(long value)
	{
	}

	internal void SetSocketTimeoutOption(int timeout)
	{
	}
}
