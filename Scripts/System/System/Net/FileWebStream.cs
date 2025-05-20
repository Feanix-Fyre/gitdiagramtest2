using System.IO;

namespace System.Net;

internal sealed class FileWebStream : FileStream, ICloseEx
{
	private FileWebRequest m_request;

	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing)
		: base(null, default(FileMode))
	{
	}

	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async)
		: base(null, default(FileMode))
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	public override void Write(byte[] buffer, int offset, int size)
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

	public override void EndWrite(IAsyncResult ar)
	{
	}

	private void CheckError()
	{
	}
}
