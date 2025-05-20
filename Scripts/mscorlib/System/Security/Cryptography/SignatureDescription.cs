using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Contains information about the properties of a digital signature.</summary>
[ComVisible(true)]
public class SignatureDescription
{
	private string _strKey;

	private string _strDigest;

	private string _strFormatter;

	private string _strDeformatter;

	/// <summary>Gets or sets the key algorithm for the signature description.</summary>
	/// <returns>The key algorithm for the signature description.</returns>
	public string KeyAlgorithm
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the digest algorithm for the signature description.</summary>
	/// <returns>The digest algorithm for the signature description.</returns>
	public string DigestAlgorithm
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the formatter algorithm for the signature description.</summary>
	/// <returns>The formatter algorithm for the signature description.</returns>
	public string FormatterAlgorithm
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the deformatter algorithm for the signature description.</summary>
	/// <returns>The deformatter algorithm for the signature description.</returns>
	public string DeformatterAlgorithm
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SignatureDescription" /> class.</summary>
	public SignatureDescription()
	{
	}
}
