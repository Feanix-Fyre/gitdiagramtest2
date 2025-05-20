namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents an element of an X.509 chain.</summary>
public class X509ChainElement
{
	private X509Certificate2 certificate;

	private X509ChainStatus[] status;

	private string info;

	private X509ChainStatusFlags compressed_status_flags;

	/// <summary>Gets the X.509 certificate at a particular chain element.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</returns>
	public X509Certificate2 Certificate => null;

	/// <summary>Gets the error status of the current X.509 certificate in a chain.</summary>
	/// <returns>An array of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatus" /> objects.</returns>
	public X509ChainStatus[] ChainElementStatus => null;

	internal X509ChainStatusFlags StatusFlags
	{
		get
		{
			return default(X509ChainStatusFlags);
		}
		set
		{
		}
	}

	internal X509ChainElement(X509Certificate2 certificate)
	{
	}

	private int Count(X509ChainStatusFlags flags)
	{
		return 0;
	}

	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
	{
	}

	internal void UncompressFlags()
	{
	}
}
