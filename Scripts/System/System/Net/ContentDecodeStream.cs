using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class ContentDecodeStream : WebReadStream
{
	internal enum Mode
	{
		GZip = 0,
		Deflate = 1
	}

	private Stream OriginalInnerStream { get; }

	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode)
	{
		return null;
	}

	private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream)
		: base(null, null)
	{
	}

	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
	{
		return null;
	}

	internal override Task FinishReading(CancellationToken cancellationToken)
	{
		return null;
	}
}
