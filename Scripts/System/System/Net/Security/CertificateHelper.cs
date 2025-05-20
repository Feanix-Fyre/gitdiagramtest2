using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security;

internal static class CertificateHelper
{
	internal static X509Certificate2 GetEligibleClientCertificate(X509CertificateCollection candidateCerts)
	{
		return null;
	}

	internal static X509Certificate2 GetEligibleClientCertificate(X509Certificate2Collection candidateCerts)
	{
		return null;
	}

	private static bool IsValidClientCertificate(X509Certificate2 cert)
	{
		return false;
	}

	private static bool IsValidForClientAuthenticationEKU(X509EnhancedKeyUsageExtension eku)
	{
		return false;
	}

	private static bool IsValidForDigitalSignatureUsage(X509KeyUsageExtension ku)
	{
		return false;
	}

	internal static X509Certificate2 GetEligibleClientCertificate()
	{
		return null;
	}
}
