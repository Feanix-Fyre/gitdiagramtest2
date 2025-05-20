using System.IO;

namespace System.Data.SqlTypes;

internal abstract class SqlStreamChars
{
	public abstract long Length { get; }

	public abstract long Position { get; }

	public abstract int Read(char[] buffer, int offset, int count);

	public abstract long Seek(long offset, SeekOrigin origin);
}
