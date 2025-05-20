using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity;

internal class UnityTlsContext : MobileTlsContext
{
	private unsafe UnityTls.unitytls_tlsctx* tlsContext;

	private unsafe UnityTls.unitytls_x509list* requestedClientCertChain;

	private unsafe UnityTls.unitytls_key* requestedClientKey;

	private UnityTls.unitytls_tlsctx_read_callback readCallback;

	private UnityTls.unitytls_tlsctx_write_callback writeCallback;

	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback;

	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback;

	private X509Certificate localClientCertificate;

	private X509Certificate2 remoteCertificate;

	private MonoTlsConnectionInfo connectioninfo;

	private bool isAuthenticated;

	private bool hasContext;

	private bool closedGraceful;

	private byte[] writeBuffer;

	private byte[] readBuffer;

	private GCHandle handle;

	private Exception lastException;

	public override bool IsAuthenticated => false;

	internal override X509Certificate LocalClientCertificate => null;

	public override X509Certificate2 RemoteCertificate => null;

	public UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		: base(null, null)
	{
	}

	private unsafe static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey)
	{
		Unsafe.As<UnityTls.unitytls_x509list*, @null>(ref nativeCertChain) = null;
		Unsafe.As<UnityTls.unitytls_key*, @null>(ref nativeKey) = null;
	}

	public override void Flush()
	{
	}

	public override (int, bool) Read(byte[] buffer, int offset, int count)
	{
		return default((int, bool));
	}

	public override (int, bool) Write(byte[] buffer, int offset, int count)
	{
		return default((int, bool));
	}

	public override void Renegotiate()
	{
	}

	public override bool PendingRenegotiation()
	{
		return false;
	}

	public override void Shutdown()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override void StartHandshake()
	{
	}

	public override bool ProcessHandshake()
	{
		return false;
	}

	public override void FinishHandshake()
	{
	}

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
	private unsafe static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
	{
		return (IntPtr)0;
	}

	private unsafe IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
	{
		return (IntPtr)0;
	}

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
	private unsafe static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
	{
		return (IntPtr)0;
	}

	private unsafe IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
	{
		return (IntPtr)0;
	}

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
	private unsafe static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
	{
		return default(UnityTls.unitytls_x509verify_result);
	}

	private unsafe UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
	{
		return default(UnityTls.unitytls_x509verify_result);
	}

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
	private unsafe static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
	{
	}

	private unsafe void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
	{
	}
}
