namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents the distinguished name of an X509 certificate. This class cannot be inherited.</summary>
[System.MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
public sealed class X500DistinguishedName : AsnEncodedData
{
	private string name;

	private byte[] canonEncoding;

	/// <summary>Gets the comma-delimited distinguished name from an X500 certificate.</summary>
	/// <returns>The comma-delimited distinguished name of the X509 certificate.</returns>
	public string Name => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" /> class using information from the specified byte array.</summary>
	/// <param name="encodedDistinguishedName">A byte array that contains distinguished name information.</param>
	public X500DistinguishedName(byte[] encodedDistinguishedName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" /> class using information from the specified string.</summary>
	/// <param name="distinguishedName">A string that represents the distinguished name.</param>
	public X500DistinguishedName(string distinguishedName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" /> class using the specified string and <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags" /> flag.</summary>
	/// <param name="distinguishedName">A string that represents the distinguished name.</param>
	/// <param name="flag">A bitwise combination of the enumeration values that specify the characteristics of the distinguished name.</param>
	public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag)
	{
	}

	/// <summary>Decodes a distinguished name using the characteristics specified by the <paramref name="flag" /> parameter.</summary>
	/// <param name="flag">A bitwise combination of the enumeration values that specify the characteristics of the distinguished name.</param>
	/// <returns>The decoded distinguished name.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate has an invalid name.</exception>
	public string Decode(X500DistinguishedNameFlags flag)
	{
		return null;
	}

	/// <summary>Returns a formatted version of an X500 distinguished name for printing or for output to a text window or to a console.</summary>
	/// <param name="multiLine">
	///   <see langword="true" /> if the return string should contain carriage returns; otherwise, <see langword="false" />.</param>
	/// <returns>A formatted string that represents the X500 distinguished name.</returns>
	public override string Format(bool multiLine)
	{
		return null;
	}

	private static string GetSeparator(X500DistinguishedNameFlags flag)
	{
		return null;
	}

	private void DecodeRawData()
	{
	}

	private static string Canonize(string s)
	{
		return null;
	}

	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2)
	{
		return false;
	}
}
