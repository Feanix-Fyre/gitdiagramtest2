namespace System;

/// <summary>Provides a custom constructor for uniform resource identifiers (URIs) and modifies URIs for the <see cref="T:System.Uri" /> class.</summary>
public class UriBuilder
{
	private bool _changed;

	private string _fragment;

	private string _host;

	private string _password;

	private string _path;

	private int _port;

	private string _query;

	private string _scheme;

	private string _schemeDelimiter;

	private Uri _uri;

	private string _username;

	/// <summary>Gets or sets the Domain Name System (DNS) host name or IP address of a server.</summary>
	/// <returns>The DNS host name or IP address of the server.</returns>
	public string Host
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the path to the resource referenced by the URI.</summary>
	/// <returns>The path to the resource referenced by the URI.</returns>
	public string Path
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets any query information included in the URI.</summary>
	/// <returns>The query information included in the URI.</returns>
	public string Query
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the scheme name of the URI.</summary>
	/// <returns>The scheme of the URI.</returns>
	/// <exception cref="T:System.ArgumentException">The scheme cannot be set to an invalid scheme name.</exception>
	public string Scheme
	{
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Uri" /> instance constructed by the specified <see cref="T:System.UriBuilder" /> instance.</summary>
	/// <returns>A <see cref="T:System.Uri" /> that contains the URI constructed by the <see cref="T:System.UriBuilder" />.</returns>
	/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.  
	///
	///
	///
	///
	///  The URI constructed by the <see cref="T:System.UriBuilder" /> properties is invalid.</exception>
	public Uri Uri => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class.</summary>
	public UriBuilder()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified <see cref="T:System.Uri" /> instance.</summary>
	/// <param name="uri">An instance of the <see cref="T:System.Uri" /> class.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="uri" /> is <see langword="null" />.</exception>
	public UriBuilder(Uri uri)
	{
	}

	private void Init(Uri uri)
	{
	}

	/// <summary>Compares an existing <see cref="T:System.Uri" /> instance with the contents of the <see cref="T:System.UriBuilder" /> for equality.</summary>
	/// <param name="rparam">The object to compare with the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="rparam" /> represents the same <see cref="T:System.Uri" /> as the <see cref="T:System.Uri" /> constructed by this <see cref="T:System.UriBuilder" /> instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object rparam)
	{
		return false;
	}

	/// <summary>Returns the hash code for the URI.</summary>
	/// <returns>The hash code generated for the URI.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	private void SetFieldsFromUri(Uri uri)
	{
	}

	/// <summary>Returns the display string for the specified <see cref="T:System.UriBuilder" /> instance.</summary>
	/// <returns>The string that contains the unescaped display string of the <see cref="T:System.UriBuilder" />.</returns>
	/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.  
	///
	///
	///
	///
	///  The <see cref="T:System.UriBuilder" /> instance has a bad password.</exception>
	public override string ToString()
	{
		return null;
	}
}
