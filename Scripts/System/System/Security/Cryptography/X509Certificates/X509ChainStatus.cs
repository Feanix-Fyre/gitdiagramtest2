namespace System.Security.Cryptography.X509Certificates;

/// <summary>Provides a simple structure for storing X509 chain status and error information.</summary>
public struct X509ChainStatus
{
	private X509ChainStatusFlags status;

	private string info;

	/// <summary>Specifies the status of the X509 chain.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatusFlags" /> value.</returns>
	public X509ChainStatusFlags Status
	{
		get
		{
			return default(X509ChainStatusFlags);
		}
		set
		{
		}
	}

	/// <summary>Specifies a description of the <see cref="P:System.Security.Cryptography.X509Certificates.X509Chain.ChainStatus" /> value.</summary>
	/// <returns>A localizable string.</returns>
	public string StatusInformation
	{
		set
		{
		}
	}

	internal X509ChainStatus(X509ChainStatusFlags flag)
	{
		status = default(X509ChainStatusFlags);
		info = null;
	}

	internal static string GetInformation(X509ChainStatusFlags flags)
	{
		return null;
	}
}
