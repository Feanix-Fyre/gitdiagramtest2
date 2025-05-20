using System.Collections.Generic;

namespace System.Security.Cryptography.X509Certificates;

internal class X509CertificateImplCollection : IDisposable
{
	private List<X509CertificateImpl> list;

	public int Count => 0;

	public X509CertificateImpl this[int index] => null;

	public X509CertificateImplCollection()
	{
	}

	private X509CertificateImplCollection(X509CertificateImplCollection other)
	{
	}

	public void Add(X509CertificateImpl impl, bool takeOwnership)
	{
	}

	public X509CertificateImplCollection Clone()
	{
		return null;
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~X509CertificateImplCollection()
	{
	}
}
