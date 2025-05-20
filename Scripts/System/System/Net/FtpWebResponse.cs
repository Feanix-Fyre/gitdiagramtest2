using System.IO;

namespace System.Net;

/// <summary>Encapsulates a File Transfer Protocol (FTP) server's response to a request.</summary>
public class FtpWebResponse : WebResponse, IDisposable
{
	internal sealed class EmptyStream : MemoryStream
	{
		internal EmptyStream()
		{
		}
	}

	internal Stream _responseStream;

	private long _contentLength;

	private Uri _responseUri;

	private FtpStatusCode _statusCode;

	private string _statusLine;

	private WebHeaderCollection _ftpRequestHeaders;

	private DateTime _lastModified;

	private string _bannerMessage;

	private string _welcomeMessage;

	private string _exitMessage;

	/// <summary>Gets an empty <see cref="T:System.Net.WebHeaderCollection" /> object.</summary>
	/// <returns>An empty <see cref="T:System.Net.WebHeaderCollection" /> object.</returns>
	public override WebHeaderCollection Headers => null;

	/// <summary>Gets the URI that sent the response to the request.</summary>
	/// <returns>A <see cref="T:System.Uri" /> instance that identifies the resource associated with this response.</returns>
	public override Uri ResponseUri => null;

	/// <summary>Gets the most recent status code sent from the FTP server.</summary>
	/// <returns>An <see cref="T:System.Net.FtpStatusCode" /> value that indicates the most recent status code returned with this response.</returns>
	public FtpStatusCode StatusCode => default(FtpStatusCode);

	internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
	{
	}

	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
	{
	}

	/// <summary>Retrieves the stream that contains response data sent from an FTP server.</summary>
	/// <returns>A readable <see cref="T:System.IO.Stream" /> instance that contains data returned with the response; otherwise, <see cref="F:System.IO.Stream.Null" /> if no response data was returned by the server.</returns>
	/// <exception cref="T:System.InvalidOperationException">The response did not return a data stream.</exception>
	public override Stream GetResponseStream()
	{
		return null;
	}

	internal void SetResponseStream(Stream stream)
	{
	}

	/// <summary>Frees the resources held by the response.</summary>
	public override void Close()
	{
	}
}
