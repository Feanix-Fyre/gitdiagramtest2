namespace System.Security.Cryptography;

/// <summary>Represents Abstract Syntax Notation One (ASN.1)-encoded data.</summary>
public class AsnEncodedData
{
	internal Oid _oid;

	internal byte[] _raw;

	/// <summary>Gets or sets the <see cref="T:System.Security.Cryptography.Oid" /> value for an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
	public Oid Oid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the Abstract Syntax Notation One (ASN.1)-encoded data represented in a byte array.</summary>
	/// <returns>A byte array that represents the Abstract Syntax Notation One (ASN.1)-encoded data.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value is <see langword="null" />.</exception>
	public byte[] RawData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</summary>
	protected AsnEncodedData()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using a byte array.</summary>
	/// <param name="oid">A string that represents <see cref="T:System.Security.Cryptography.Oid" /> information.</param>
	/// <param name="rawData">A byte array that contains Abstract Syntax Notation One (ASN.1)-encoded data.</param>
	public AsnEncodedData(string oid, byte[] rawData)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using an <see cref="T:System.Security.Cryptography.Oid" /> object and a byte array.</summary>
	/// <param name="oid">An <see cref="T:System.Security.Cryptography.Oid" /> object.</param>
	/// <param name="rawData">A byte array that contains Abstract Syntax Notation One (ASN.1)-encoded data.</param>
	public AsnEncodedData(Oid oid, byte[] rawData)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class using an instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</summary>
	/// <param name="asnEncodedData">An instance of the <see cref="T:System.Security.Cryptography.AsnEncodedData" /> class.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asnEncodedData" /> is <see langword="null" />.</exception>
	public AsnEncodedData(AsnEncodedData asnEncodedData)
	{
	}

	/// <summary>Copies information from an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
	/// <param name="asnEncodedData">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object to base the new object on.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asnEncodedData" /> is <see langword="null" />.</exception>
	public virtual void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	/// <summary>Returns a formatted version of the Abstract Syntax Notation One (ASN.1)-encoded data as a string.</summary>
	/// <param name="multiLine">
	///   <see langword="true" /> if the return string should contain carriage returns; otherwise, <see langword="false" />.</param>
	/// <returns>A formatted string that represents the Abstract Syntax Notation One (ASN.1)-encoded data.</returns>
	public virtual string Format(bool multiLine)
	{
		return null;
	}

	internal virtual string ToString(bool multiLine)
	{
		return null;
	}

	internal string Default(bool multiLine)
	{
		return null;
	}

	internal string BasicConstraintsExtension(bool multiLine)
	{
		return null;
	}

	internal string EnhancedKeyUsageExtension(bool multiLine)
	{
		return null;
	}

	internal string KeyUsageExtension(bool multiLine)
	{
		return null;
	}

	internal string SubjectKeyIdentifierExtension(bool multiLine)
	{
		return null;
	}

	internal string SubjectAltName(bool multiLine)
	{
		return null;
	}

	internal string NetscapeCertType(bool multiLine)
	{
		return null;
	}
}
