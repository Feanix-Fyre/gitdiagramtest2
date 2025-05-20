using System.IO;
using System.Text;
using System.Threading;

namespace System.Diagnostics;

internal class AsyncStreamReader
{
	private Stream stream;

	private Encoding encoding;

	private Decoder decoder;

	private byte[] byteBuffer;

	private char[] charBuffer;

	private bool cancelOperation;

	private ManualResetEvent eofEvent;

	private object syncObject;

	private IAsyncResult asyncReadResult;

	public virtual void Close()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal void CancelOperation()
	{
	}
}
