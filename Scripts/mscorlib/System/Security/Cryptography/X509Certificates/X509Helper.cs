using Microsoft.Win32.SafeHandles;
using Mono;

namespace System.Security.Cryptography.X509Certificates;

internal static class X509Helper
{
	private static ISystemCertificateProvider CertificateProvider => null;

	public static X509CertificateImpl InitFromCertificate(X509Certificate cert)
	{
		return null;
	}

	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
	{
		return null;
	}

	public static bool IsValid(X509CertificateImpl impl)
	{
		return false;
	}

	internal static void ThrowIfContextInvalid(X509CertificateImpl impl)
	{
	}

	internal static Exception GetInvalidContextException()
	{
		return null;
	}

	public static X509CertificateImpl Import(byte[] rawData)
	{
		return null;
	}

	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
	{
		return null;
	}
}
