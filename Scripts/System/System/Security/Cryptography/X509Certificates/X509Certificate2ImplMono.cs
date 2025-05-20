using Microsoft.Win32.SafeHandles;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates;

internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
{
	private X509CertificateImplCollection intermediateCerts;

	private Mono.Security.X509.X509Certificate _cert;

	private static string empty_error;

	private static byte[] signedData;

	public override bool IsValid => false;

	private Mono.Security.X509.X509Certificate Cert => null;

	public override bool HasPrivateKey => false;

	public override AsymmetricAlgorithm PrivateKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal override X509CertificateImplCollection IntermediateCertificates => null;

	internal Mono.Security.X509.X509Certificate MonoCertificate => null;

	public X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert)
	{
	}

	private X509Certificate2ImplMono(X509Certificate2ImplMono other)
	{
	}

	public X509Certificate2ImplMono(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
	{
	}

	public override X509CertificateImpl Clone()
	{
		return null;
	}

	protected override byte[] GetRawCertData()
	{
		return null;
	}

	public override RSA GetRSAPrivateKey()
	{
		return null;
	}

	public override DSA GetDSAPrivateKey()
	{
		return null;
	}

	private Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password)
	{
		return null;
	}

	private Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password)
	{
		return null;
	}

	[System.MonoTODO("by default this depends on the incomplete X509Chain")]
	public override bool Verify(X509Certificate2 thisCertificate)
	{
		return false;
	}
}
