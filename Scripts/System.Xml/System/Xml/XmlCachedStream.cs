using System.IO;

namespace System.Xml;

internal class XmlCachedStream : MemoryStream
{
	private Uri uri;

	internal XmlCachedStream(Uri uri, Stream stream)
	{
	}
}
