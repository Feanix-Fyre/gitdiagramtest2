using System.Text;

namespace System.Net.Http;

/// <summary>Provides HTTP content based on a string.</summary>
public class StringContent : ByteArrayContent
{
	/// <summary>Creates a new instance of the <see cref="T:System.Net.Http.StringContent" /> class.</summary>
	/// <param name="content">The content used to initialize the <see cref="T:System.Net.Http.StringContent" />.</param>
	/// <param name="encoding">The encoding to use for the content.</param>
	/// <param name="mediaType">The media type to use for the content.</param>
	public StringContent(string content, Encoding encoding, string mediaType)
		: base(null)
	{
	}

	private static byte[] GetByteArray(string content, Encoding encoding)
	{
		return null;
	}
}
