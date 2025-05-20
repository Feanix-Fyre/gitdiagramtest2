namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents an X509 extension.</summary>
public class X509Extension : AsnEncodedData
{
	private bool _critical;

	/// <summary>Gets a Boolean value indicating whether the extension is critical.</summary>
	/// <returns>
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</returns>
	public bool Critical
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> class.</summary>
	protected X509Extension()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> class.</summary>
	/// <param name="oid">A string representing the object identifier.</param>
	/// <param name="rawData">The encoded data used to create the extension.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise <see langword="false" />.</param>
	public X509Extension(string oid, byte[] rawData, bool critical)
	{
	}

	/// <summary>Copies the extension properties of the specified <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
	/// <param name="asnEncodedData">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> to be copied.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asnEncodedData" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="asnEncodedData" /> does not have a valid X.509 extension.</exception>
	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal string FormatUnkownData(byte[] data)
	{
		return null;
	}
}
