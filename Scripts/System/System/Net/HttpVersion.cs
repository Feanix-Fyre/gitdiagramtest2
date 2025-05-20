namespace System.Net;

/// <summary>Defines the HTTP version numbers that are supported by the <see cref="T:System.Net.HttpWebRequest" /> and <see cref="T:System.Net.HttpWebResponse" /> classes.</summary>
public class HttpVersion
{
	public static readonly Version Unknown;

	/// <summary>Defines a <see cref="T:System.Version" /> instance for HTTP 1.0.</summary>
	public static readonly Version Version10;

	/// <summary>Defines a <see cref="T:System.Version" /> instance for HTTP 1.1.</summary>
	public static readonly Version Version11;

	public static readonly Version Version20;
}
