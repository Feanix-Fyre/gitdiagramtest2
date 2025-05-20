using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security;

public class SslClientAuthenticationOptions
{
	private EncryptionPolicy _encryptionPolicy;

	private X509RevocationMode _checkCertificateRevocation;

	private SslProtocols _enabledSslProtocols;

	private bool _allowRenegotiation;

	public bool AllowRenegotiation => false;

	public LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get; set; }

	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; }

	public string TargetHost { get; set; }

	public X509CertificateCollection ClientCertificates { get; set; }

	public X509RevocationMode CertificateRevocationCheckMode
	{
		set
		{
		}
	}

	public EncryptionPolicy EncryptionPolicy
	{
		set
		{
		}
	}

	public SslProtocols EnabledSslProtocols
	{
		get
		{
			return default(SslProtocols);
		}
		set
		{
		}
	}
}
