using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal abstract class WebConnectionStream : Stream
{
	protected bool closed;

	private bool disposed;

	private object locker;

	private int read_timeout;

	private int write_timeout;

	internal HttpWebRequest Request { get; }

	internal WebConnection Connection { get; }

	internal WebOperation Operation { get; }

	internal ServicePoint ServicePoint => null;

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

	public override bool CanSeek => false;

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

	protected WebConnectionStream(WebConnection cnc, WebOperation operation)
	{
	}

	protected Exception GetException(Exception e)
	{
		return null;
	}

	protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
	{
		return null;
	}

	public override int EndRead(IAsyncResult r)
	{
		return 0;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
	{
		return null;
	}

	public override void EndWrite(IAsyncResult r)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	internal void InternalClose()
	{
	}

	protected abstract void Close_internal(ref bool disposed);

	public override void Close()
	{
	}

	public override long Seek(long a, SeekOrigin b)
	{
		return 0L;
	}

	public override void SetLength(long a)
	{
	}
}
