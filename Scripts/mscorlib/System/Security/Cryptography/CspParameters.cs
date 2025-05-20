using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Contains parameters that are passed to the cryptographic service provider (CSP) that performs cryptographic computations. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class CspParameters
{
	/// <summary>Represents the provider type code for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
	public int ProviderType;

	/// <summary>Represents the provider name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
	public string ProviderName;

	/// <summary>Represents the key container name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
	public string KeyContainerName;

	/// <summary>Specifies whether an asymmetric key is created as a signature key or an exchange key.</summary>
	public int KeyNumber;

	private int m_flags;

	/// <summary>Represents the flags for <see cref="T:System.Security.Cryptography.CspParameters" /> that modify the behavior of the cryptographic service provider (CSP).</summary>
	/// <returns>An enumeration value, or a bitwise combination of enumeration values.</returns>
	/// <exception cref="T:System.ArgumentException">Value is not a valid enumeration value.</exception>
	public CspProviderFlags Flags
	{
		get
		{
			return default(CspProviderFlags);
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class.</summary>
	public CspParameters()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code.</summary>
	/// <param name="dwTypeIn">A provider type code that specifies the kind of provider to create.</param>
	public CspParameters(int dwTypeIn)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code and name, and the specified container name.</summary>
	/// <param name="dwTypeIn">The provider type code that specifies the kind of provider to create.</param>
	/// <param name="strProviderNameIn">A provider name.</param>
	/// <param name="strContainerNameIn">A container name.</param>
	public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
	{
	}

	internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
	{
	}
}
