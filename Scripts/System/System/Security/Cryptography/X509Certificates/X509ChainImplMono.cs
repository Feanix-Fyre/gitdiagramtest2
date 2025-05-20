using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates;

internal class X509ChainImplMono : X509ChainImpl
{
	private StoreLocation location;

	private X509ChainElementCollection elements;

	private X509ChainPolicy policy;

	private X509ChainStatus[] status;

	private static X509ChainStatus[] Empty;

	private int max_path_length;

	private X500DistinguishedName working_issuer_name;

	private AsymmetricAlgorithm working_public_key;

	private X509ChainElement bce_restriction;

	private X509Certificate2Collection roots;

	private X509Certificate2Collection cas;

	private X509Store root_store;

	private X509Store ca_store;

	private X509Store user_root_store;

	private X509Store user_ca_store;

	private X509Certificate2Collection collection;

	public override bool IsValid => false;

	public override X509ChainElementCollection ChainElements => null;

	public override X509ChainPolicy ChainPolicy => null;

	public override X509ChainStatus[] ChainStatus => null;

	private X509Certificate2Collection Roots => null;

	private X509Certificate2Collection CertificateAuthorities => null;

	private X509Store LMRootStore => null;

	private X509Store UserRootStore => null;

	private X509Store LMCAStore => null;

	private X509Store UserCAStore => null;

	private X509Certificate2Collection CertificateCollection => null;

	public X509ChainImplMono(bool useMachineContext)
	{
	}

	public override void AddStatus(X509ChainStatusFlags error)
	{
	}

	[System.MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	public override bool Build(X509Certificate2 certificate)
	{
		return false;
	}

	public override void Reset()
	{
	}

	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate)
	{
		return default(X509ChainStatusFlags);
	}

	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c)
	{
		return null;
	}

	private X509Certificate2 FindParent(X509Certificate2 certificate)
	{
		return null;
	}

	private bool IsChainComplete(X509Certificate2 certificate)
	{
		return false;
	}

	private bool IsSelfIssued(X509Certificate2 certificate)
	{
		return false;
	}

	private void ValidateChain(X509ChainStatusFlags flag)
	{
	}

	private void Process(int n)
	{
	}

	private void PrepareForNextCertificate(int n)
	{
	}

	private void WrapUp()
	{
	}

	private void ProcessCertificateExtensions(X509ChainElement element)
	{
	}

	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey)
	{
		return false;
	}

	private string GetSubjectKeyIdentifier(X509Certificate2 certificate)
	{
		return null;
	}

	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate)
	{
		return null;
	}

	private static string GetAuthorityKeyIdentifier(X509Crl crl)
	{
		return null;
	}

	private static string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext)
	{
		return null;
	}

	private void CheckRevocationOnChain(X509ChainStatusFlags flag)
	{
	}

	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online)
	{
		return default(X509ChainStatusFlags);
	}

	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online)
	{
		return default(X509ChainStatusFlags);
	}

	private static X509Crl CheckCrls(string subject, string ski, Mono.Security.X509.X509Store store)
	{
		return null;
	}

	private X509Crl FindCrl(X509Certificate2 caCertificate)
	{
		return null;
	}

	private bool ProcessCrlExtensions(X509Crl crl)
	{
		return false;
	}

	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry)
	{
		return false;
	}
}
