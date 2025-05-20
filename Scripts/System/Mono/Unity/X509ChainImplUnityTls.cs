using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Unity;

internal class X509ChainImplUnityTls : X509ChainImpl
{
	private X509ChainElementCollection elements;

	private UnityTls.unitytls_x509list_ref nativeCertificateChain;

	private X509ChainPolicy policy;

	private List<X509ChainStatus> chainStatusList;

	private bool reverseOrder;

	public override bool IsValid => false;

	internal UnityTls.unitytls_x509list_ref NativeCertificateChain => default(UnityTls.unitytls_x509list_ref);

	public override X509ChainElementCollection ChainElements => null;

	public override X509ChainPolicy ChainPolicy => null;

	public override X509ChainStatus[] ChainStatus => null;

	internal X509ChainImplUnityTls(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false)
	{
	}

	public override void AddStatus(X509ChainStatusFlags error)
	{
	}

	public override bool Build(X509Certificate2 certificate)
	{
		return false;
	}

	public override void Reset()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
