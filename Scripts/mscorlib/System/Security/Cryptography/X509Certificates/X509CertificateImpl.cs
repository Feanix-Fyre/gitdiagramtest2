using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509CertificateImpl : IDisposable
{
	public abstract bool IsValid { get; }

	public abstract string Issuer { get; }

	public abstract string Subject { get; }

	public abstract byte[] RawData { get; }

	public abstract DateTime NotAfter { get; }

	public abstract DateTime NotBefore { get; }

	public abstract byte[] Thumbprint { get; }

	public abstract string KeyAlgorithm { get; }

	public abstract byte[] KeyAlgorithmParameters { get; }

	public abstract byte[] PublicKeyValue { get; }

	public abstract byte[] SerialNumber { get; }

	public abstract bool HasPrivateKey { get; }

	protected void ThrowIfContextInvalid()
	{
	}

	public abstract X509CertificateImpl Clone();

	public sealed override int GetHashCode()
	{
		return 0;
	}

	public abstract RSA GetRSAPrivateKey();

	public abstract DSA GetDSAPrivateKey();

	public abstract byte[] Export(X509ContentType contentType, SafePasswordHandle password);

	public sealed override bool Equals(object obj)
	{
		return false;
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~X509CertificateImpl()
	{
	}
}
