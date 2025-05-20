using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Interface;

namespace Mono.Unity;

internal static class UnityTlsConversions
{
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols)
	{
		return default(UnityTls.unitytls_protocol);
	}

	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols)
	{
		return default(UnityTls.unitytls_protocol);
	}

	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol)
	{
		return default(TlsProtocols);
	}

	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError)
	{
		return default(AlertDescription);
	}

	public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult)
	{
		return default(SslPolicyErrors);
	}

	public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult)
	{
		return default(X509ChainStatusFlags);
	}
}
