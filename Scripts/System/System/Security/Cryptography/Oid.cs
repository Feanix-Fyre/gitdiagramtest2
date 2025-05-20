namespace System.Security.Cryptography;

/// <summary>Represents a cryptographic object identifier. This class cannot be inherited.</summary>
public sealed class Oid
{
	private string _value;

	private string _friendlyName;

	private OidGroup _group;

	/// <summary>Gets or sets the dotted number of the identifier.</summary>
	/// <returns>The dotted number of the identifier.</returns>
	public string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the friendly name of the identifier.</summary>
	/// <returns>The friendly name of the identifier.</returns>
	public string FriendlyName => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class.</summary>
	public Oid()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using a string value of an <see cref="T:System.Security.Cryptography.Oid" /> object.</summary>
	/// <param name="oid">An object identifier.</param>
	public Oid(string oid)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using the specified value and friendly name.</summary>
	/// <param name="value">The dotted number of the identifier.</param>
	/// <param name="friendlyName">The friendly name of the identifier.</param>
	public Oid(string value, string friendlyName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using the specified <see cref="T:System.Security.Cryptography.Oid" /> object.</summary>
	/// <param name="oid">The object identifier information to use to create the new object identifier.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="oid" /> is <see langword="null" />.</exception>
	public Oid(Oid oid)
	{
	}

	/// <summary>Creates an <see cref="T:System.Security.Cryptography.Oid" /> object by using the specified OID value and group.</summary>
	/// <param name="oidValue">The OID value.</param>
	/// <param name="group">The group to search in.</param>
	/// <returns>A new instance of an <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="oidValue" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The friendly name for the OID value was not found.</exception>
	public static Oid FromOidValue(string oidValue, OidGroup group)
	{
		return null;
	}

	private Oid(string value, string friendlyName, OidGroup group)
	{
	}
}
