using System;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity;

internal class UnityTlsProvider : MobileTlsProvider
{
	public override string Name => null;

	public override Guid ID => default(Guid);

	public override bool SupportsSslStream => false;

	public override bool SupportsMonoExtensions => false;

	public override bool SupportsConnectionInfo => false;

	internal override bool SupportsCleanShutdown => false;

	public override SslProtocols SupportedProtocols => default(SslProtocols);

	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
	{
		return null;
	}

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
	private unsafe static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
	{
		return default(UnityTls.unitytls_x509verify_result);
	}

	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11)
	{
		return false;
	}
}
